﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Success
        {
            public int total { get; set; }
        }

        public class Contents
        {
            public string translated { get; set; }
            public string text { get; set; }
            public string translation { get; set; }
        }

        public class Root
        {
            public Success success { get; set; }
            public Contents contents { get; set; }
        }
    }

