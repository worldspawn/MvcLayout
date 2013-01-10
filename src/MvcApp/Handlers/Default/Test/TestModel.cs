using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp.Handlers.Default.Test
{
    public class TestModel
    {
        [UIHint("Thing")]
        public string Thing { get; set; }
    }
}