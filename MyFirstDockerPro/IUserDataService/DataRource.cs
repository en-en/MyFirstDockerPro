using System;
using System.Collections.Generic;
using System.Text;
using UserDataService;

namespace IUserDataService
{
   public class DataRource: IDataRource
    {
        public string GetData()
        {
            var str = "Hello Word";
            return str;
        }
    }
}
