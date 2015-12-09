using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveGetPageSource : IUBotFunction
    {

        private string _returnValue = "";

        public WebDriveGetPageSource()
        {
        }

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            _returnValue = Node.WebDriverConnect.PageSource;
        }

        public string Category
        {
            get { return "WebDriver Browser"; }
        }

        public string FunctionName
        {
            get { return "$web drive get page source"; }
        }

        public object ReturnValue
        {
            get { return _returnValue; }
        }

        public bool IsContainer
        {
            get { return false; }
        }

        private readonly List<UBotParameterDefinition> _parameters = new List<UBotParameterDefinition>();

        public IEnumerable<UBotParameterDefinition> ParameterDefinitions
        {
            get { return _parameters; }
        }

        public UBotVersion UBotVersion
        {
            get { return UBotVersion.Standard; }
        }

        public UBotType ReturnValueType
        {
            get { return UBotType.String; }
        }
    }
}