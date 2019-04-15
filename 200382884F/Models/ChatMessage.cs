using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200382884F.Models
{
    // GIT URL https://github.com/paramvir1/FinalAssignment
    public class ChatMessage
    {
        
        public virtual int ChatMessageId { get; set; }
        [Required]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Message { get; set; }
        public DateTime? PostedAt { get; set; }




    }
}