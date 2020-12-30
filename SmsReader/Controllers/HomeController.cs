using SmsReader.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SmsReader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string computer_name = System.Net.Dns.GetHostName();
            string file_path;
            ViewBag.MyPhoneNumber = ConfigurationManager.AppSettings["MyPhoneNumber"];

            if (computer_name == "markm-1040G3")
            {
                file_path = @"C:\Work\Other\SmsReader\sms-example.xml";
            }
            else
            {
                file_path = @"C:\Users\MainPC\Documents\Personal\Backups & Old Devices\SMS\sms-19800106014633.xml";
            }
            SmsManager sms_manager = new SmsManager(file_path);

            return View(sms_manager);
        }

    }
}