using System;
using Frame.ServiceContainer;
using Frame.ServiceContainer.External;

namespace Frame.Host
{
    public class Global : System.Web.HttpApplication
    {


        private readonly IContainer _container = ContainerFactory.GetContainer();
        //private readonly ISystemLogger _logger = LoggerIoc.GetLogger();

        protected void Application_Start(object sender, EventArgs e)
        {
            var appHost = new AppHost();
            //appHost.Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}