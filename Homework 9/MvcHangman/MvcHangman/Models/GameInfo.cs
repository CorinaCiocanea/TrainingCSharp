﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHangman.Models
{
    public class GameInfo
    {
        public int numberChoices { get; set; }
        public string letterUsed { get; set; }
        public string lettersAvailable { get; set; }
        public string letterNext { get; set; }
   

    }
}