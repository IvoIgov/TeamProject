using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno;
using TestStack.Seleno.Configuration;

namespace Blog.UI.Tests
{
    public static class Host
    {

        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl = @"http://localhost:60634/Article/List";
        static Host()
        {
            Instance.Run("Blog", 60634, w => w.WithRemoteWebDriver(BrowserFactory.FireFox));
        }
    }
}
