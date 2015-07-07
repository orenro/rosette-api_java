﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBinding;
using System.Web.Script.Serialization;

namespace CAPIExamples
{
    class TokensExample
    {
        public void TokensEx()
        {
            //Tokens
            CAPI TokensCAPI = new CAPI("your API key");
            Dictionary<string, Object> TokensResult = TokensCAPI.Tokens("The brown fox's mother jumped over 3 lazy dogs. Yes she did.");
            Console.WriteLine(new JavaScriptSerializer().Serialize(TokensResult));
        }
    }
}
