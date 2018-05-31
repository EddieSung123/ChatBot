using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webhook.Controllers
{
    public class LineBotWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "TR4Cd8nrqYRdhLRe18XZJUUh6RM440/OGGVrebFpbSzTvJL/GUhnpRkHh8pyN1oClEJ9NMa6CEdnjLw2Km/pnJ/jyb//OT1U8H5+RT3xlR+3YD2T/I7AhsK1LB4qlPZCfqYTnWDWWuT6YJh2MpyJWAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U2cb5f3b6d2e79519bff4dffc93a804ac";

        [Route("api/LineWebHookSample")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //回覆訊息
                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.type == "text") //收到文字
                        this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);
                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken,1,2);
                    if (LineEvent.message.type == "image") //收到圖片
                        this.ReplyMessage(LineEvent.replyToken, new Uri("https://avatars1.githubusercontent.com/u/26271905?s=460&v=4"));
                }
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //如果發生錯誤，傳訊息給Admin
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
