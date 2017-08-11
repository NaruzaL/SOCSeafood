using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOCSeafood.Models
{
    [Table("NewsletterSubscribers")]
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }
        public string Interest { get; set; }
        public bool IsSignedUp { get; set;}
        public DateTime SubscribeDate { get; set; }
        public virtual ApplicationUser User { get; set;}
    }
}
