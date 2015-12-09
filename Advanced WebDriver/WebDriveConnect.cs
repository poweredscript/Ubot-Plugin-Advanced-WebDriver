using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveConnect : IUBotCommand
    {
        public WebDriveConnect()
        {
            _parameters.Add(new UBotParameterDefinition("Command Timeout", UBotType.String)
            {
                Options = new[] {"", "60", "90", "120", "180"},
                DefaultValue = "60"
            });
            _parameters.Add(new UBotParameterDefinition("Hide Command Prompt Window", UBotType.String)
            {
                Options = new[] {"True", "False"},
                DefaultValue = "True"
            });
            _parameters.Add(new UBotParameterDefinition("Chrome Driver", UBotType.String));
        }

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            var chromeDriver = parameters["Chrome Driver"].Trim();
            var commandTimeout = int.Parse(parameters["Command Timeout"].Trim());
            var hideCommandPromptWindow = bool.Parse(parameters["Hide Command Prompt Window"]);
            TimeSpan tTimeOut = TimeSpan.FromSeconds(commandTimeout);

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(chromeDriver);
            chromeDriverService.HideCommandPromptWindow = hideCommandPromptWindow;
            Node.WebDriverConnect = new ChromeDriver(chromeDriverService, new ChromeOptions(), tTimeOut);
        }

        public string Category
        {
            get { return "WebDriver"; }
        }

        public string CommandName
        {
            get { return "web drive connect"; }
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