using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlaywrightFrameworkTest;


namespace PlaywrightFrameworkTest
{
    public class ScriptOne : Automation.Common.Automation
    {
        [Test]
        public async Task RunTest()
        {
            await Page.GotoAsync("https://playwright.dev/dotnet");
            await Page.GotoAsync("https://www.google.com/");
            await Page.PauseAsync();
        }
    }
}