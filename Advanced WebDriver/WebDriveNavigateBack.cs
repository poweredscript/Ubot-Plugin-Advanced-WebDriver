using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveNavigateBack : IUBotCommand
    {
        public WebDriveNavigateBack()
        {
        }

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            Node.WebDriverConnect.Navigate().Back();
        }

        public string Category
        {
            get { return "WebDriver Browser"; }
        }

        public string CommandName
        {
            get { return "web drive navigate back"; }
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