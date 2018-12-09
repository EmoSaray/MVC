using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Duration { get; set; }
        public byte DiscountRate { get; set; }
    }
}