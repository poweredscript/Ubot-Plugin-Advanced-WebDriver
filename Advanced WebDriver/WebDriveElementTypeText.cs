using OpenQA.Selenium;
using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveElementTypeText : IUBotCommand //IUBotFunction,IUBotCommand, IWizardEnabled
    {
        private const string CatName = "WebDriver Element";
        private const string CaFName = "web drive element type text";
        private string _returnValue = "";//List<string> _returnValue = new List<string>();

        //public static IUBotStudio UbotStudio;
        //public static Dictionary<string, string> Parameters;
        public WebDriveElementTypeText()
        {
            _parameters.Add(new UBotParameterDefinition("Select", UBotType.String));
            _parameters.Add(new UBotParameterDefinition("Keys", UBotType.String));
        }

        //private object obj = new object();
        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            var select = parameters["Select"].Trim();
            var keys = parameters["Keys"];

            var element = Node.WebDriverConnect.FindElement(By.XPath(select));
            element.SendKeys(keys);
        }

        public string Category { get { return "Apichai " + CatName + (GetType().GetInterface("IUBotFunction") == null ? " Commands" : " Functions"); } }
        public string CommandName { get { return CaFName; } }
        public string FunctionName { get { return "$" + CaFName; } }
        public object ReturnValue { get { return _returnValue; } }
        public bool IsContainer { get { return false; } }
        private readonly List<UBotParameterDefinition> _parameters = new List<UBotParameterDefinition>();
        public IEnumerable<UBotParameterDefinition> ParameterDefinitions { get { return _parameters; } }
        public UBotVersion UBotVersion { get { return UBotVersion.Standard; } }
        public UBotType ReturnValueType { get { var returnType = _returnValue.GetType().Name; return returnType.Contains("String[,]") ? UBotType.UBotTable : (returnType.Contains("List") ? UBotType.UBotList : UBotType.String); } }
    }
}