using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if IOS
using IOS.WeChat;
using UIKit;
#endif

namespace MauiBlazorDemo.Pages
{
    public partial class Index
    {
        private void Test()
        {
#if IOS
            WXApi.RegisterApp("wx3f94d21d67c4ae76");
            SendMessageToWXReq req = new SendMessageToWXReq();
            req.Text = "213";
            req.BText = true;
            req.Scene = 1;
            WXApi.SendReq(req);
#endif
        }
    }
}
