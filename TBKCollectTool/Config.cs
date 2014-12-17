using System;
using System.Collections.Generic;
using System.Text;

namespace TBKCollectTool
{
    enum ExportType
    {
        csv=0,
        mySql=1
    }
    class Config
    {
        public ExportType exportType;
        public string csvFilePath;

    }
}
