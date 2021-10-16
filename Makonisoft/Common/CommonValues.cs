using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Makonisoft.Common
{
    public class CommonValues
    {
        public static readonly string PersonalInfomationSavePath = ConfigurationManager.AppSettings["personalinfomationSavePath"].ToString();
        public static readonly string PersonalInformationFilename = ConfigurationManager.AppSettings["personalInfomationFilename"].ToString();
    }
}