using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_Traning2.Common
{
    public static class SubmitButtonHelper
    {
        public static IHtmlContent SubmitButton(this IHtmlHelper helper, string value, string name)
        {
            string str = " <input type='submit' value=' " + value + "' name= " + name + "/>";
            return new HtmlString(str);
        }
    }
}
