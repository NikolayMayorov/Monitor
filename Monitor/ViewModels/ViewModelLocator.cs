using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            var service = SimpleIoc.Default;
            service.Register<MainWindowViewModel>();
        }

        public MainWindowViewModel MainWindowViewModel { get => ServiceLocator.Current.GetInstance<MainWindowViewModel>(); }
    }
}
