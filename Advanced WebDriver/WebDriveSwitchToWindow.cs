using System.Collections.Generic;
using UBotPlugin;

namespace Advanced_WebDriver
{
    internal class WebDriveSwitchToWindow : IUBotCommand
    {
        public WebDriveSwitchToWindow()
        {
            _parameters.Add(new UBotParameterDefinition("Window/Tab Title", UBotType.String));
        }

        //private object obj = new object();
        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            var title = parameters["Window/Tab Title"].Trim();
            Node.WebDriverConnect.SwitchTo().Window(title);
        }

        public string Category
        {
            get { return "WebDriver Browser"; }
        }

        public string CommandName
        {
            get { return "web drive switch to window"; }
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