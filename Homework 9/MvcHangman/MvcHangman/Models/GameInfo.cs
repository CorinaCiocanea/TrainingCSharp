using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcHangman.Models
{
    public class GameInfo
    {
        public int numberChoices { get; set; }
        public string letterUsed { get; set; }

        public string lettersAvailable { get; set; }
        public string str { get; set; }

        //[RegularExpression("([a-zA-Z0-9 .&'-]+)", ErrorMessage = "Enter only alphabets and numbers of First Name")]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [RegularExpression("[a-zA-Z]", ErrorMessage = "only alphabet")]
        public char letterNext { get; set; }
        public string hiddenWorld { get; set; }
   

    }
}