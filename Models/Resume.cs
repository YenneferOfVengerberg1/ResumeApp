﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp
{
    [Serializable]
    public class Resume
    {
        public User User { get; set; }
        public IFormat Format { get; set; }
    }
}
