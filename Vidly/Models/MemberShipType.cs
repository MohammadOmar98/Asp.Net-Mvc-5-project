﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public short SignUp { get; set; }
        public byte DurationInMonths { get; set; }
        public byte Discounts { get; set; }
    }
}