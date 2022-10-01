using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApplication1.Models.Process
{
    public class StringProcess : Controller
    {
        public string RemoveRemainingSpace(string strInput)
        {
            string strResult = "";
            //Xoa bo khoang trang o dau va cuoi chuoi
            strInput = strInput.Trim();

            //delete space o giua dong chuoi
            //int index = strInput.IndexOf(" ");
            //Xoa bo cac khoang trang con thua trong chuoi
            while(strInput.IndexOf("  ") > 0)
            {
                strResult = strInput.Replace("  ", " ");
            }
            return strResult;
        }
        public string LowerToUpperString(string strInput)
        {
            string strResult = "";
            strResult = strInput.ToUpper();

            return strResult;
        }

        public string UpperToLowerString(string strInput)
        {
            return strInput.ToLower();
        }

        public string CapitalizeOneFirstCharacter(string strInput)
        {


            return strInput;
        }
    }
}
