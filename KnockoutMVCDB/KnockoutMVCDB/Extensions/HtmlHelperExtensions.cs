﻿using System;
using System.Web.Mvc;
using System.Web;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace KnockoutMVCDB.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };

            return new HtmlString(JsonConvert.SerializeObject(model, settings));
        }
    }
}