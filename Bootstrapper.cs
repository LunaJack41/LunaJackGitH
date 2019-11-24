using Caliburn.Micro;
using OurDevices.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace OurDevices
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
			//Adding a comment just to test Git
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
