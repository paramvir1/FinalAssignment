using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace _200382884F.Models
{
    public class MessageContextInitializer : DropCreateDatabaseAlways<_200382884FContext>
    {
        protected override void Seed(_200382884FContext context)
        {
           context.ChatMessages.Add( new ChatMessage { Name = "Paramvir", Message = "Hi everyone"});

            context.ChatMessages.Add( new ChatMessage { Name = "Daaman", Message = "Hello" });

            context.ChatMessages.Add( new ChatMessage { Name = "Amarjeet", Message = "My name is amarjeet" });

            base.Seed(context);
        }
    }

   
}