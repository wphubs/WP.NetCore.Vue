﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP.NetCore.Model.EntityModel
{
    public class JobLog
    {
        public int id { get; set; }

        public string Timestamp { get; set; }

  
        public string Level { get; set; }
        public string Message { get; set; }
        public string Properties { get; set; }


        public string Exception { get; set; }


        public DateTime? _ts { get; set; }

     
    }
}
