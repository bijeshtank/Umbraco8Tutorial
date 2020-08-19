using System.Web;

namespace CleanUmbraco.Core.Helpers
{
    public static class QueryStringHelper
    {
        public static int GetIntfromQueryString(HttpRequestBase request, string key, int fallbackValue = 0)
        {
            var stringValue = request.QueryString[key];
            if(stringValue != null && !string.IsNullOrWhiteSpace(stringValue) && int.TryParse(stringValue, out var numericValue))
            {
                return numericValue;
            }

            return fallbackValue;
        }
    }
}
