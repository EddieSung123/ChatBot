using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("TR4Cd8nrqYRdhLRe18XZJUUh6RM440/OGGVrebFpbSzTvJL/GUhnpRkHh8pyN1oClEJ9NMa6CEdnjLw2Km/pnJ/jyb//OT1U8H5+RT3xlR+3YD2T/I7AhsK1LB4qlPZCfqYTnWDWWuT6YJh2MpyJWAdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("U2cb5f3b6d2e79519bff4dffc93a804ac","Yeeeeee");
            bot.PushMessage("U2cb5f3b6d2e79519bff4dffc93a804ac",1,2);
            bot.PushMessage("U2cb5f3b6d2e79519bff4dffc93a804ac", new Uri("https://avatars1.githubusercontent.com/u/26271905?s=460&v=4"));
        }
    }
}