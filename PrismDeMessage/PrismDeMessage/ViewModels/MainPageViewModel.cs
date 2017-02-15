using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDeMessage.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismDeMessage.ViewModels
{
    public class TListItem
    {
        public string Title { get; set; }
        public string Detail { get; set; }
    }


    public class MainPageViewModel : BindableBase
    {
        public ICommand ScrollToTopCommand { get; }
        public List<TListItem> ListItems { get; }

        public MainPageViewModel()
        {
            ScrollToTopCommand = new DelegateCommand(ScrollToTop);

            ListItems = new List<TListItem>();
            for (int i = 0; i < 100; i++)
            {
                ListItems.Add(new TListItem() { Title = $"title-{i}", Detail = $"detail-{i}" });
            }
        }

        private void ScrollToTop()
        {
            MessagingCenter.Send<object>(ListItems[0], ListViewMethodBehavior.ScrollTo);
        }
    }
}
