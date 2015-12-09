using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveNavigateGo : IUBotCommand
    {
        public WebDriveNavigateGo()
        {
            _parameters.Add(new UBotParameterDefinition("URL", UBotType.String));
        }

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            var url = parameters["URL"].Trim();

            Node.WebDriverConnect.Navigate().GoToUrl(url);
        }

        public string Category
        {
            get { return "WebDriver Browser"; }
        }

        public string CommandName
        {
            get { return "web drive navigate go"; }
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