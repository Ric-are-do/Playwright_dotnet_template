using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlaywrightFrameworkTest;
using PlaywrightFrameworkTest.Automation;
using PlaywrightFrameworkTest.Automation.Common.Utilities;


namespace PlaywrightFrameworkTest
{
    public class ScriptOne : Automation.Common.Automation
    {
        public string name = CreateCustomer.GenerateName();
        public string ID =  IdNumberGenerator.Generate();

        [Test]
        public async Task RunTest()
        {
            // Start writing script from here onwards
            await Page.GotoAsync("https://playwright.dev/dotnet");
            await Page.GotoAsync("https://www.google.com/");
            
            //Extra Content 
            // Screen recorder 
            //await Page.Context.Tracing.StopAsync()
            
        }
    }
}