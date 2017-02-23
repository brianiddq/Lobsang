using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lobsang.Models
{
    public class LiftChair
    {
        public int Id { get; set; }
        public byte Section { get; set; }
        public ushort RPM { get; set; }
    }
}