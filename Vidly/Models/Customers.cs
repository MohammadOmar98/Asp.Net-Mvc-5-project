using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter{ get; set; }
        public MemberShipType MemberShipTypes { get; set; }
        public byte MemberShipTypeID { get; set; }
    }
}