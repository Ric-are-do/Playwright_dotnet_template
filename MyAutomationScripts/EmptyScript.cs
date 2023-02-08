using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlaywrightFrameworkTest;
using PlaywrightFrameworkTest.Automation;
using PlaywrightFrameworkTest.Automation.Common.Utilities;

namespace PlaywrightFrameworkTest.MyAutomationScripts
{
    public class EmptyScript : Automation.Common.Automation
    {
        [Test]
        public async Task GenericTest()
        {
            // test details go here 
            await Page.GotoAsync("http/google.com");
        }
    }
}