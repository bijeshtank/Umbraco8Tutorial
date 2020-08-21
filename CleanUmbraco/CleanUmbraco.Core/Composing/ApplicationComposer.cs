using SlackBotMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using System.Web.Configuration;
using SlackBotMessages.Models;

namespace CleanUmbraco.Core.Composing
{
    public class ApplicationComposer : ComponentComposer<ApplicationComponent>
    {

    }

    public class ApplicationComponent : IComponent
    {
        public void Initialize() 
        {
            var client = new SbmClient(WebConfigurationManager.AppSettings["SlackBokMessagesWebHookUrl"]);

            var message = new Message
            {
                Username = "Alien",
                Text = "Hello from an Alien",
                IconEmoji = Emoji.Alien
            };

            client.Send(message);
        }

        public void Terminate() { }
    }
}
