using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightFrameworkTest.Automation.Common
{
    [TestFixture]
    public partial class Automation
    {
        // The trick here is the static keyword
        private static IPlaywright _playwright = null!;
        private static IBrowser _browser = null!;

        protected IPage Page = null!;

        // Run ahead of each test
        // Creates a ew page object... therefore you will be enforcing the GOTO on each of your test as the first
        [SetUp]
        public async Task OnTestRunSetup()
        {
            var context = await _browser.NewContextAsync();
            Page = await context.NewPageAsync();
        }
        
        [TearDown]
        public async Task TearDown()
        {
            await Page.CloseAsync();
            
        }

    // Run once for all our test.
    // Create a playwright instance which provides us with a reference to our browser
    [OneTimeSetUp]
    public async Task SetUpGlobals()
    {   
        _playwright = await Playwright.CreateAsync();
        var chromium = _playwright.Chromium;
        _browser = await chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
                    SlowMo = 50,
        });
    }

    }
}