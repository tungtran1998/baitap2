using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BT2.Models
{
    public class GenKeyAuto
    {
        public string generatekey (string id)
        {
            string strkey = "";
            string numPart = "", strPart = "";
            numPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;
            int phanso = (Convert.ToInt32(numPart) + 1);
            if(phanso.ToString().Length > 1)
            {
                strkey = strPart + phanso.ToString();
            }
            else
            {
                strkey = strPart + "0" + phanso.ToString();
            }
            return strkey;
        }
    }
}