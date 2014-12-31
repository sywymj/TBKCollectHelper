using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Text.RegularExpressions;
namespace TBKCollectTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GlobalHotkeys hotkey;
        string HomeUrl = "http://zx.mytaomi.com/uz";
        List<ProductItem> lsProducts = null;
        string configFileName = "config.dat";
        Random myRand = new Random();

        SMS8080Helper.AppConfig appconifg = new SMS8080Helper.AppConfig();

        string[] captionProductGrid = new string[] { "ID", "商品编码", "商品名称", "分类", "包邮", "拍下减", "天猫", "开始时间", "结束时间","添加时间" };
        string[] colNameProductGrid = new string[] { "id", "numiid", "title", "catiid", "ems", "pxj", "tmall", "dtbegin", "dtfinish", "dtadd" };
        delegate void delegateGridBind(DataGridView flexGrid, DataTable dt, string[] captionArray);

        void gridBind(DataGridView flexGrid, DataTable dt, string[] captionArray)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delegateGridBind(gridBind), new object[] { flexGrid, dt, captionArray });
                return;
            }


            flexGrid.DataSource = dt.DefaultView;
            string lastCol = string.Empty;
            for (int i = 0; i < captionArray.Length; i++)
            {
                if (string.IsNullOrEmpty(captionArray[i]))
                {
                    flexGrid.Columns[i].Visible = false;
                }
                else
                {
                    flexGrid.Columns[i].HeaderText = captionArray[i];
                    lastCol = flexGrid.Columns[i].Name;
                }

            }
            flexGrid.AutoResizeColumns();
            flexGrid.Columns[lastCol].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(HomeUrl);
            lsProducts = new List<ProductItem>();
            //this.dateTimePicker1.Value = DateTime.Now.AddYears(-1);
            //this.dateTimePicker2.Value = DateTime.Now.AddYears(1);

            //this.dateTimePickerModifyB.Value = this.dateTimePicker1.Value;
            //this.dateTimePickerModifyF.Value = this.dateTimePicker2.Value;
            DateTime dtInit = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
            this.dateTimePickerModifyB.Value = dtInit;
            this.dateTimePickerModifyF.Value = dtInit;
            this.dateTimePickerQueryB.Value = dtInit;
            this.dateTimePickerQueryE.Value = dtInit;
            this.dateTimePickerAddB.Value = dtInit;
            this.dateTimePickerAddF.Value = dtInit;


            this.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            this.backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            this.backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;

            appconifg.ReadConfig(configFileName);
            if (string.IsNullOrEmpty(appconifg.ReadConfig(configFileName)))
            {
                this.textBoxDbServer.Text = appconifg.ServerAdd;
                this.textBoxDbPort.Text = appconifg.ServerPort;
                this.textBoxDbUser.Text = appconifg.UserID;
                this.textBoxDbPass.Text = appconifg.Password;
                this.textBoxDbName.Text = appconifg.DataBase;
                this.textBoxProductTableName.Text = appconifg.ProductTableName;
            }

            dt = new DataTable();
            for (int i = 0; i < captionProductGrid.Length; i++)
            {
                //DataColumn col=dt.Columns.Add(captionProductGrid[i]);
                DataColumn col = dt.Columns.Add(colNameProductGrid[i]);
            }

            hotkey = new GlobalHotkeys();
            hotkey.RegisterGlobalHotKey((int)Keys.F1, 0,this.Handle);

            UpdateTreeNode(string.Empty);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            switch (m.Msg)
            {
                case WM_HOTKEY:
                    {
                        if ((short)m.WParam == hotkey.HotkeyID)
                        {
                            // do your thing
                            this.toolStripButtonCollect.PerformClick();
                        }
                        break;
                    }
                default:
                    {
                        base.WndProc(ref m);
                        break;
                    }
            }
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
            this.toolStripProgressBarToDb.Value = e.ProgressPercentage+1;
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            this.toolStrip1.Enabled = true;

            this.groupBoxModify.Enabled = true;
            this.groupBoxQuery.Enabled = true;

            MessageBox.Show("导入数据库任务完成！");


        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < lsProducts.Count;i++ )
            {
                if (this.backgroundWorker1.CancellationPending)
                {
                    break;
                }
                try
                {
                    string cmdStr = string.Empty;
                    ProductItem _item=lsProducts[i];
                    if (string.IsNullOrEmpty(_item.ID))
                    {
                        cmdStr = string.Format(@"INSERT IGNORE INTO `{11}` VALUES (NULL,'9999','{0}','0','1','{1}','{2}',NULL,NULL,'萌黛儿旗舰店',NULL,'1','admin','{3}',NULL,'{4}',NULL,'2277','0.00','0','{5}','6700','{6}','{7}','1','underway',NULL,'{12}',NULL,'{8}','{9}',NULL,NULL,NULL,'0','1','9844','0',NULL,NULL,NULL,'{10}','0','0',NULL)",
                            //ProductItem.cateID,
                            lsProducts[i]._cateID,
                           lsProducts[i].sourceID,
                           lsProducts[i].Titel,
                           lsProducts[i].Image,
                           lsProducts[i].OrigPrice,
                           lsProducts[i].Price,
                           //ProductItem.dtBegin,
                           //ProductItem.dtFinish,
                           //ProductItem.IsPost,
                           //ProductItem.IsSale,
                           lsProducts[i]._dtBegin,
                           lsProducts[i]._dtFinish,
                           lsProducts[i]._IsPost,
                           lsProducts[i]._IsSale,

                           //GetTimeStampShort(),
                           lsProducts[i]._dtAdd,
                           DBHelperServer.ProductTableName,
                           lsProducts[i]._IsTmall
                            );
                    } 
                    else
                    {
                        cmdStr = string.Format(@"Update {0} set coupon_start_time='{1}',coupon_end_time='{2}',ems='{3}',pxj='{4}',cate_id='{6}',shop_type='{7}',add_time='{8}',title='{9}'  where id='{5}'",
                            DBHelperServer.ProductTableName,_item._dtBegin, _item._dtFinish, _item._IsPost, _item._IsSale,_item.ID,_item._cateID,_item._IsTmall,_item._dtAdd,_item.Titel);
                    }

                    int hr=DBHelperServer.ExecuteCommand(cmdStr);
                    if (hr<=0)
                    {
                        SetLog(string.Format("{0} 库中已存在！", lsProducts[i].sourceID));
                    } 
                    else
                    {
                        SetLog(string.Format("{0}入库成功！", lsProducts[i].sourceID));
                    }
                    
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    SetLog(string.Format("商品{0}入库错误！", lsProducts[i].sourceID));
                }
                this.backgroundWorker1.ReportProgress(i);
            }
        }

        void SetLog(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(SetLog), new object[] { msg });
                return;
                
            }
            this.toolStripStatusLabelLog.Text = msg;
        }

        private void toolStripButtonCollect_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.HtmlDocument frameDoc = this.webBrowser1.Document;
            try
            {         
                HtmlAgilityPack.HtmlDocument hapDoc = new HtmlAgilityPack.HtmlDocument();
                hapDoc.LoadHtml(frameDoc.Body.InnerHtml);
                HtmlNodeCollection htmlItems = hapDoc.DocumentNode.SelectNodes(@"//ul[@id='goodslist']/li[div[contains(@class,'selected')]]");
                foreach (HtmlNode _item in htmlItems)
                {
                    //Console.WriteLine(_item.ToString());
                    try
                    {
                        ProductItem product = new ProductItem();
                        product.sourceID = _item.GetAttributeValue("data-itemid", string.Empty);
                        product.Image = _item.SelectSingleNode("div[contains(@class,'img')]//img").GetAttributeValue("src", string.Empty);
                        //product.Image = System.Text.RegularExpressions.Regex.Replace(product.Image, @"(?<=jpg)_(\S+?)\.jpg$", string.Empty);
                        product.Image = System.Text.RegularExpressions.Regex.Replace(product.Image, @"_\d+x\d+\.\S+$", string.Empty);


                        product.Titel = _item.SelectSingleNode("div[contains(@class,'title')]").InnerText;
                        product.Price = _item.SelectSingleNode("div[contains(@class,'desc')]//span").InnerText;
                        product.OrigPrice = _item.SelectSingleNode("div[contains(@class,'sold')]//span").InnerText;





                        lsProducts.Add(product);

                    }
                    catch (System.Exception)
                    {}
                }

                //DisplaySelectProducts();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabelSelectCount.Text = string.Format("已选择 {0}  条商品", lsProducts.Count);
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要清除已选择商品吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)!=DialogResult.OK)
            {
                return;
            }
            lsProducts.Clear();
            //this.richTextBoxDisp.Clear();
            DisplaySelectProducts();
        }
        public static string GetTimeStampShort()
        {
            string stampString = string.Empty;
            try
            {
                TimeSpan ts = DateTime.Now.AddHours(-8) - new DateTime(1970, 1, 1, 0, 0, 0);
                stampString = ((int)ts.TotalSeconds).ToString();
                //stampString = ((long)ts.TotalMilliseconds).ToString();
            }
            catch (System.Exception)
            {
            }
            return stampString;
        }
        public static string GetTimeStampShort(DateTime dtValue)
        {
            string stampString = string.Empty;
            try
            {
                TimeSpan ts = dtValue.AddHours(-8) - new DateTime(1970, 1, 1, 0, 0, 0);
                stampString = ((int)ts.TotalSeconds).ToString();
                //stampString = ((long)ts.TotalMilliseconds).ToString();
            }
            catch (System.Exception)
            {
            }
            return stampString;
        }
        private bool CheckParam()
        {
            try
            {
                if (string.IsNullOrEmpty(this.textBoxCateID.Text))
                {
                    throw new Exception("cateID is null");
                }

                ProductItem.cateID = this.textBoxCateID.Text.Trim();
                ProductItem.dtBegin = GetTimeStampShort(this.dateTimePicker1.Value);
                ProductItem.dtFinish = GetTimeStampShort(this.dateTimePicker2.Value);
                ProductItem.IsPost = this.checkBoxEms.Checked ? 1 : 0;
                ProductItem.IsSale = this.checkBoxPxj.Checked ? 1 : 0;

                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private void toolStripButtonSaveCSV_Click(object sender, EventArgs e)
        {
            //if (!CheckParam())
            //{
            //    MessageBox.Show("部分字段参数或者数据库连接参数有误，请检查！");
            //    return;
            //}
            if (this.saveFileDialog1.ShowDialog()!=DialogResult.OK)
            {
                return;
            }
            string filename = this.saveFileDialog1.FileName;
            try
            {
                using (StreamWriter sr = new StreamWriter(filename, true, Encoding.UTF8))
                {
                    for (int i = 0; i < lsProducts.Count;i++ )
                    {
                        string line = string.Format(@"NULL;""9999"";""{0}"";""0"";""1"";""{1}"";""{2}"";NULL;NULL;""萌黛儿旗舰店"";NULL;""1"";""admin"";""{3}"";NULL;""{4}"";NULL;""2277"";""0.00"";""0"";""{5}"";""6700"";""{6}"";""{7}"";""1"";""underway"";NULL;""{11}"";NULL;""{8}"";""{9}"";NULL;;NULL;""0"";""1"";""9844"";""0"";NULL;NULL;NULL;""{10}"";""0"";""0"";NULL",
                           //ProductItem.cateID,
                           lsProducts[i]._cateID,
                           lsProducts[i].sourceID,
                           lsProducts[i].Titel,
                           lsProducts[i].Image,
                           lsProducts[i].OrigPrice,
                           lsProducts[i].Price,

                           lsProducts[i]._dtBegin,
                           lsProducts[i]._dtFinish,
                           lsProducts[i]._IsPost,
                           lsProducts[i]._IsSale,
                           //ProductItem.dtBegin,
                           //ProductItem.dtFinish,
                           //ProductItem.IsPost,
                           //ProductItem.IsSale,
                           lsProducts[i]._dtAdd,
                           lsProducts[i]._IsTmall
                            );
                        sr.WriteLine(line);
                    }
                    sr.Close();
                }

                MessageBox.Show("保存为CSV文件成功！\r\n" + filename);
                //lsProducts.Clear();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(HomeUrl);
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoBack();
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoForward();
        }

        private void toolStripButtonFresh_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Refresh();
        }

        private void toolStripTextBoxUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode!=Keys.Enter)
            {
                return;
            }
            string url = this.toolStripTextBoxUrl.Text.Trim().ToLower();
            if (!url.StartsWith("http"))
            {
                url = @"http://" + url;
            }
            this.toolStripTextBoxUrl.Text = url;
            this.webBrowser1.Navigate(url);
        }


        private bool CheckDbParam()
        {
            DBHelperServer.ServerAdd = this.textBoxDbServer.Text.Trim();
            DBHelperServer.ServerPort = this.textBoxDbPort.Text.Trim();
            DBHelperServer.UserID = this.textBoxDbUser.Text.Trim();
            DBHelperServer.Password = this.textBoxDbPass.Text.Trim();
            DBHelperServer.DataBase = this.textBoxDbName.Text.Trim();
            DBHelperServer.ProductTableName = this.textBoxProductTableName.Text.Trim();
            if (string.IsNullOrEmpty(DBHelperServer.ServerAdd)||string.IsNullOrEmpty(DBHelperServer.ServerPort)||string.IsNullOrEmpty(DBHelperServer.UserID)||string.IsNullOrEmpty(DBHelperServer.Password)||string.IsNullOrEmpty(DBHelperServer.DataBase)||string.IsNullOrEmpty(DBHelperServer.ProductTableName))
            {
                
                return false;
            }
            return true;
        }
        private void toolStripButtonExportToDB_Click(object sender, EventArgs e)
        {
            if (!CheckDbParam() || lsProducts.Count<=0)
            {
                MessageBox.Show("数据库参数错误或者商品列表为空，请检查！");
                return;
            }
            if (MessageBox.Show("您确认要将"+lsProducts.Count+"条数据导入数据库吗？")!=DialogResult.OK)
            {
                return;
            }
            this.toolStrip1.Enabled = false;
            this.toolStripProgressBarToDb.Minimum = 0;
            this.toolStripProgressBarToDb.Maximum = lsProducts.Count;
            this.toolStripProgressBarToDb.Value = 0;
            this.backgroundWorker1.RunWorkerAsync();

            this.groupBoxModify.Enabled = false;
            this.groupBoxQuery.Enabled = false;
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            appconifg.ServerAdd = this.textBoxDbServer.Text.Trim();
            appconifg.ServerPort = this.textBoxDbPort.Text.Trim();
            appconifg.UserID = this.textBoxDbUser.Text.Trim();
            appconifg.Password = this.textBoxDbPass.Text.Trim();
            appconifg.DataBase = this.textBoxDbName.Text.Trim();
            appconifg.ProductTableName = this.textBoxProductTableName.Text.Trim();

            if (string.IsNullOrEmpty(appconifg.SaveConfig(configFileName)))
            {
                MessageBox.Show("保存配置成功！");
            } 
            else
            {
                MessageBox.Show("保存配置文件失败");
            }
        }

        private void toolStripButtonDisp_Click(object sender, EventArgs e)
        {
            DisplaySelectProducts();
        }

        
        void DisplaySelectProducts()
        {
            this.tabControl1.SelectedIndex = 2;
            //this.richTextBoxDisp.Clear();
            dt.Clear();
            for (int i = 0; i < lsProducts.Count;i++ )
            {
                ProductItem _item=lsProducts[i];
                //this.richTextBoxDisp.AppendText(string.Format("{0}\t{1}\t{2}\r\n", _item.ID, _item.sourceID, _item.Titel));
                dt.Rows.Add(_item.ToArray());
               
            }
            gridBind(this.dataGridViewProduct, dt, captionProductGrid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckDbParam())
            {
                MessageBox.Show("数据库参数错误，请检查！");
                return;
            }
            if (MessageBox.Show("从库中查询数据将清空您已经选择的商品，您确定要查询吗？","提示",MessageBoxButtons.OKCancel)!=DialogResult.OK)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            lsProducts.Clear();
            //this.richTextBoxDisp.Clear();
            DisplaySelectProducts();

            //string queryBeginDate = GetTimeStampShort(DateTime.Parse(this.dateTimePickerQueryB.Value.ToString("yyyy-MM-dd 00:00:00")));
            //string queryFinishDate = GetTimeStampShort(DateTime.Parse(this.dateTimePickerQueryE.Value.ToString("yyyy-MM-dd 23:59:59")));
            string queryBeginDate = GetTimeStampShort(this.dateTimePickerQueryB.Value);
            string queryFinishDate = GetTimeStampShort(this.dateTimePickerQueryE.Value);
            string queryCateID=this.textBoxQueryCateID.Text.Trim();
            string queryKey=this.textBoxQueryKey.Text.Trim();
            string queryNumIID = this.textBoxQueryNumiiD.Text.Trim();
            try
            {
                if (string.IsNullOrEmpty(queryNumIID))
                {
                    sb.Append(string.Format("select * from {0} where add_time>='{1}' and add_time<='{2}' ",
                DBHelperServer.ProductTableName,
                queryBeginDate, queryFinishDate

                ));
                    if (!string.IsNullOrEmpty(queryCateID))
                    {
                        sb.Append(string.Format(" and cate_id='{0}'", queryCateID));
                    }
                    if (!string.IsNullOrEmpty(queryKey))
                    {
                        sb.Append(string.Format(" and title like '%{0}%'", queryKey));
                    }
                } 
                else
                {
                    sb.Append(string.Format("select * from {0} where num_iid in(",DBHelperServer.ProductTableName));
                    MatchCollection mc=Regex.Matches(queryNumIID,@"\S+");
                    foreach (Match _m in mc)
                    {
                        sb.Append("'").Append(_m.Value).Append("',");
                    }
                    sb.Append("'')");
                }
                



                MySql.Data.MySqlClient.MySqlDataReader mySqlRd= DBHelperServer.GetReader(sb.ToString());
                while(mySqlRd.Read())
                {
       
                    ProductItem _item = new ProductItem();
                    _item.ID = mySqlRd.GetInt32("id").ToString();
                    _item.sourceID = mySqlRd.GetString("num_iid");
                    _item.Image = mySqlRd.GetString("pic_url");
                    _item.Titel = mySqlRd.GetString("title");
                    _item.Price = mySqlRd.GetDecimal("coupon_price").ToString(); 
                    _item.OrigPrice =mySqlRd.GetDecimal("price").ToString();
                    _item._IsPost = mySqlRd.GetInt32("ems").ToString();
                    _item._IsSale = mySqlRd.GetInt32("pxj").ToString();
                    _item._dtBegin = mySqlRd.GetInt32("coupon_start_time").ToString();
                    _item._dtFinish = mySqlRd.GetInt32("coupon_end_time").ToString();
                    _item._cateID = mySqlRd.GetInt32("cate_id").ToString();

                    _item._IsTmall=mySqlRd.GetString("shop_type");
                    _item._dtAdd = mySqlRd.GetInt32("add_time").ToString();

                    lsProducts.Add(_item);
                }
                mySqlRd.Close();
                SetLog(string.Format(@"查询到 {0} 条商品！！", lsProducts.Count));
                DisplaySelectProducts();
            }
            catch (System.Exception ex)
            {
               // this.richTextBoxDisp.AppendText(ex.Message);
                SetLog(ex.Message);
            }

            
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            bool? _isEms = null;
            if (this.checkBoxModifyEms.CheckState!=CheckState.Indeterminate)
            {
                _isEms = this.checkBoxModifyEms.Checked;
            }


            bool? _isPxj = null;
            if (this.checkBoxModifyPxj.CheckState!=CheckState.Indeterminate)
            {
                _isPxj = this.checkBoxModifyPxj.Checked;
            }

            bool? _isTmall = null;
            if (this.checkBoxIsTmall.CheckState!=CheckState.Indeterminate)
            {
                _isTmall = this.checkBoxIsTmall.Checked;
            }


            string _begin = GetTimeStampShort(this.dateTimePickerModifyB.Value);
            string _finish = GetTimeStampShort(this.dateTimePickerModifyF.Value);
            string _catiid = this.textBoxModifyCatiID.Text.Trim();

            DateTime dateAddB = this.dateTimePickerAddB.Value;
            TimeSpan dateAddRange = this.dateTimePickerAddF.Value - this.dateTimePickerAddB.Value;
            double addMinRange = dateAddRange.TotalMinutes;


            try
            {
                for (int i = 0; i < lsProducts.Count;i++ )
                {
                    ProductItem _item = lsProducts[i];
                    if (_isEms.HasValue)
                    {
                        _item._IsPost = _isEms.Value ? "1" : "0";
                    }
                    if (_isPxj.HasValue)
                    {
                        _item._IsSale = _isPxj.Value ? "1" : "0";
                    }
                    if (_isTmall.HasValue)
                    {
                        _item._IsTmall = _isTmall.Value ? "B" : "C";
                    }
                   
                   

                    

                    _item._dtBegin = _begin;
                    _item._dtFinish = _finish;

                    _item._dtAdd = GetTimeStampShort(dateAddB.AddMinutes(addMinRange * myRand.NextDouble()));

                    if (!string.IsNullOrEmpty(_catiid))
                    {
                        _item._cateID = _catiid;
                    }
                }
                DisplaySelectProducts();
            }
            catch (System.Exception ex)
            {
                SetLog(ex.Message);
            }
        }

        private void toolStripButtonMakeLink_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                for (int i = 0; i < lsProducts.Count;i++ )
                {
                    sb.Append(string.Format("http://detail.tmall.com/item.htm?id={0}\r\n",lsProducts[i].sourceID));
                }
                Clipboard.SetData(DataFormats.Text, sb.ToString());
                MessageBox.Show(string.Format(@"已复制 {0} 条数据链接到粘贴板！！", lsProducts.Count));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModifyToDB_Click(object sender, EventArgs e)
        {
            this.toolStripButtonExportToDB.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hotkey.UnregisterGlobalHotKey();
        }

        private void dateTimePickerQueryB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTreeNode(string inStr)
        {
            try
            {
                MatchCollection mc=null;
                this.treeViewEmsSeparate.Nodes.Clear();
                string pattern = string.Empty;
                inStr += "\n";

                pattern = @"http://[\s\S]+?\n";
                mc=Regex.Matches(inStr,pattern);
                this.treeViewEmsSeparate.Nodes.Add("All", string.Format("全部商品【{0}】条",mc.Count)).Tag=mc;

                pattern = @"http://[^\n]+?邮费[^\n]+?\n";
                mc = Regex.Matches(inStr, pattern);
                TreeNode emsNode = this.treeViewEmsSeparate.Nodes["All"].Nodes.Add("Ems", string.Format("不包邮商品【{0}】条", mc.Count));
                emsNode.Tag = mc;

                //5元邮费pxj
                //pattern = @"http://[^\n]+?邮费[^\n]*?(?<!\d)5[^\n]*?拍[^\n]*?\n";
                pattern = @"http://[^\n]+?邮费[^\n\d]*5[^\n]*拍[^\n]*\n";
                mc = Regex.Matches(inStr, pattern);
                emsNode.Nodes.Add("Ems+5+pxj", string.Format("5元邮费+拍下减 【{0}】条", mc.Count)).Tag = mc;
                //5元邮费
                //pattern = @"http://[^\n]+?邮费[^\n]*?(?<!\d)5\.((?!拍)[^\n])+?\n";
                pattern = @"http://[^\n]+?邮费[^\n\d]*5((?!拍)[^\n])*?\n";
                mc = Regex.Matches(inStr, pattern);
                emsNode.Nodes.Add("Ems+5", string.Format("5元邮费 【{0}】条", mc.Count)).Tag = mc;
                //其它邮费
                //pattern = @"http://[^\n]+?邮费((?<!5\.)[^\n])+?\n";
                pattern = @"http://[^\n]+?邮费[^\n\d]*((?!5)\d)+?[^\n]*\n";
                mc = Regex.Matches(inStr, pattern);
                emsNode.Nodes.Add("Ems+other", string.Format("其它邮费 【{0}】条", mc.Count)).Tag = mc;



                pattern = @"http://((?!邮费)[^\n])+\n";
                mc = Regex.Matches(inStr, pattern);
                TreeNode noEmsNode=this.treeViewEmsSeparate.Nodes["All"].Nodes.Add("NoEms", string.Format("包邮【{0}】条", mc.Count));
                noEmsNode.Tag = mc;

                //拍下减
                pattern = @"http://((?!邮费)[^\n])+拍[^\n]+?\n";
                mc = Regex.Matches(inStr, pattern);
                noEmsNode.Nodes.Add("NoEms+pxj", string.Format("拍下减【{0}】条", mc.Count)).Tag = mc;
                //其它
                pattern = @"http://((?!邮费|拍)[^\n])+\n";
                mc = Regex.Matches(inStr, pattern);
                noEmsNode.Nodes.Add("NoEms+other", string.Format("其它包邮【{0}】条", mc.Count)).Tag = mc;

                this.treeViewEmsSeparate.ExpandAll();

            }
            catch (System.Exception ex)
            {
                SetLog(string.Format("邮费分离错误：{0}", ex.Message));
            }

           
            
        }


        private void buttonEmsSeparate_Click(object sender, EventArgs e)
        {
            UpdateTreeNode(this.richTextBoxLinkEmsSeparater.Text);
        }

        private void treeViewEmsSeparate_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.richTextBoxLinkEmsSeparater.Clear();
            MatchCollection mc = null;
            if ((mc=(e.Node.Tag as MatchCollection))!=null)
            {
                foreach (Match _m in mc)
                {
                    this.richTextBoxLinkEmsSeparater.AppendText(_m.Value);
                }
            }
        }

        private void buttonEmsCopyID_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                MatchCollection mc = Regex.Matches(this.richTextBoxLinkEmsSeparater.Text, @"(?<=id\=)\d+");
                foreach (Match _m in mc)
                {
                    sb.Append(string.Format("{0}\r\n", _m.Value));
                }
                Clipboard.SetData(DataFormats.Text, sb.ToString());
               //MessageBox.Show(string.Format(@"已复制 {0} 条数据链接到粘贴板！！", mc.Count));
                SetLog(string.Format(@"已复制 {0} 条数据链接到粘贴板！！", mc.Count));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex<0 || e.RowIndex<0)
            {
                return;
            }
            ProductItem curItem = lsProducts.Find((x =>
            {
                if (x.sourceID==this.dataGridViewProduct.Rows[e.RowIndex].Cells["numiid"].Value.ToString())
                {
                    return true;
                }
                return false;
            }));

            string curCellValue = this.dataGridViewProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string;
            if (curItem!=null)
            {
                switch (this.dataGridViewProduct.Columns[e.ColumnIndex].Name)
                {
                    case "title":
                        {
                            curItem.Titel = curCellValue;
                        }
                        break;
                    case "catiid":
                        {
                            curItem._cateID = curCellValue;
                        }
                        break;
                    case "ems":
                        {
                            curItem._IsPost = curCellValue;
                        }
                        break;
                    case "pxj":
                        {
                            curItem._IsSale = curCellValue;
                        }
                        break;
                    case "tmall":
                        {
                            curItem._IsTmall = curCellValue;
                        }
                        break;
                    case "dtbegin":
                        {
                            curItem._dtBegin = curCellValue;
                        }
                        break;
                    case "dtfinish":
                        {
                            curItem._dtFinish = curCellValue;
                        }
                        break;
                    case "dtadd":
                        {
                            curItem._dtAdd = curCellValue;
                        }
                        break;
                }
            }

        }

        private void dataGridViewProduct_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex<=1)
            {
                e.Cancel = true;
            }
        }

        private void textBoxQueryNumiiD_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            //{
            //    ((TextBox)sender).SelectAll();
            //} 
        }

        private void textBoxQueryNumiiD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            } 
        }

        private void treeViewEmsSeparate_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.buttonEmsCopyID.PerformClick();
        }
    }
}
