using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Translators
{
    public class TranslatorAPIUrl
    {
        public String Leetspeak { get { return @"https://api.funtranslations.com/translate/leetspeak.json?text="; } }
        public String Yoda { get { return @"https://api.funtranslations.com/translate/yoda.json?text="; } }
    }
}
