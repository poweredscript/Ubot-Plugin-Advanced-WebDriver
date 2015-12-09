using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveNavigateForward : IUBotCommand
    {
        public WebDriveNavigateForward()
        {
        }

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            Node.WebDriverConnect.Navigate().Forward();
        }

        public string Category
        {
            get { return "WebDriver Browser"; }
        }

        public string CommandName
        {
            get { return "web drive navigate forward"; }
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
    }
}