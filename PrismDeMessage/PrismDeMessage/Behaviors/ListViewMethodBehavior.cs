using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismDeMessage.Behaviors
{
    public class ListViewMethodBehavior : Behavior<ListView>
    {
        static public string ScrollTo = "ListView.ScrollTo";


        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            MessagingCenter.Subscribe<object>(this, ScrollTo, (item) =>
                {
                    bindable.ScrollTo(item, ScrollToPosition.Start, true);
                });
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);

            MessagingCenter.Unsubscribe<object>(this, ScrollTo);
        }
    }
}
