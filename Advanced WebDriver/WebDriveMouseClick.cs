using OpenQA.Selenium;
using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveMouseClick : IUBotCommand
    {
        public WebDriveMouseClick()
        {
            _parameters.Add(new UBotParameterDefinition("Select", UBotType.String));
        }

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            var select = parameters["Select"].Trim();
            var element = Node.WebDriverConnect.FindElement(By.XPath(select));
            element.Click();
        }

        public string Category
        {
            get
            {
                return "WebDriver Element";
            }
        }

        public string CommandName
        {
            get { return "web drive mouse click"; }
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