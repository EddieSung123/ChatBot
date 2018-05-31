using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webhook
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "TR4Cd8nrqYRdhLRe18XZJUUh6RM440/OGGVrebFpbSzTvJL/GUhnpRkHh8pyN1oClEJ9NMa6CEdnjLw2Km/pnJ/jyb//OT1U8H5+RT3xlR+3YD2T/I7AhsK1LB4qlPZCfqYTnWDWWuT6YJh2MpyJWAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U2cb5f3b6d2e79519bff4dffc93a804ac";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}