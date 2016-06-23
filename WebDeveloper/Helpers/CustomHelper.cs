using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            var result = string.Empty;
            if (price == 0.0)
            {
                result = "<span>Free!!!</span>";
            }
            else {
                result = $"<span>{price}</span>";
            }

            return new HtmlString(result);
        }

        public static IHtmlString DisplayPriceExtension( this HtmlHelper helper,double price)
        {
            var result = string.Empty;
            if (price == 0.0)
            {
                result = "<span>Free!!!</span>";
            }
            else {
                result = $"<span>{price}</span>";
            }

            return new HtmlString(result);

        }
        public static IHtmlString DisplayDateORNull(this HtmlHelper helper, DateTime fecha)
        {
            var result = string.Empty;
            if (fecha.ToShortDateString()== "01/01/0001")
            {
                result = "<span>-</span>";
            }
            
            else {
                result = $"<span>{fecha.ToShortDateString()}</span>";
            }

            return new HtmlString(result);

        }


    }
}
