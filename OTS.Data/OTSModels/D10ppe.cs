﻿using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10ppe
    {
        public int Ppekey { get; set; }
        public int ClientKey { get; set; }
        public string Name { get; set; }
        public string ValueType { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual D10client ClientKeyNavigation { get; set; }
    }
}
