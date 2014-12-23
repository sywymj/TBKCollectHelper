using System;
using System.Collections.Generic;
using System.Text;

namespace TBKCollectTool
{
    public class ProductItem
    {
        public string ID;
        public string sourceID;
        public string Image;
        public string Titel;
        public string Price;
        public string OrigPrice;

        public string _IsPost;
        public string _IsSale;
        public string _dtBegin;
        public string _dtFinish;
        public string _cateID;

        public string _IsTmall;

        public string _dtAdd;


        public static int IsPost;
        public static int IsSale;
        public static string dtBegin;
        public static string dtFinish;
        public static string cateID;

        public object[] ToArray()
        {
            object[] objArra = new object[10];
            objArra[0] = this.ID;
            objArra[1] = this.sourceID;
            objArra[2] = this.Titel;
            objArra[3] = this._cateID;
            objArra[4] = this._IsPost;
            objArra[5] = this._IsSale;
            objArra[6] = this._IsTmall;
            objArra[7] = this._dtBegin;
            objArra[8] = this._dtFinish;
            objArra[9] = this._dtAdd;

            return objArra;
        }
    }
}
