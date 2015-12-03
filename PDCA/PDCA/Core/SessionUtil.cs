#define DEBUG_AUTHEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PDCA.Core
{
    public class SessionUtil
    {
        public static int GetUserId()
        {
            if (HttpContext.Current.Session["SESSION_USER_ID"] != null)
            {
                return int.Parse(HttpContext.Current.Session["SESSION_USER_ID"].ToString());
            }
            else
            {
#if DEBUG_AUTHEN
                HttpContext.Current.Session["SESSION_USER_FULLNAME"] = "Test User";
                return 1;
#else
                return -1;
#endif
            }
        }
    }
}
