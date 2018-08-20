using GenerateKey.Models;
using System.Xml;
using Newtonsoft.Json;

namespace GenerateKey.Utilities
{
    public static class Helper
    {
        public static WOModel ConvertXMLTOWorkOrder(string value)
        {//TODO: Implement the method
            return new WOModel();
        }
        public static XmlDocument ConvertWOTOXML(WOModel model)
        {
            //TODO: Implement the method
            return new XmlDocument();
        }
        public static string ConvertToJSON(WOModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}
