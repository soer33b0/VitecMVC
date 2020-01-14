using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitecMVC.TagHelpers
{
    public class EmailTaghelper : TagHelper
    {
        public string Address { get; set; }

        public string Content { get; set; }
    }
}
