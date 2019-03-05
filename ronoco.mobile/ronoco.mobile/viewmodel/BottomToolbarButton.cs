using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    class BottomToolbarButton
    {
        public event EventHandler ButtonTapped;

        protected virtual void OnBottomButtonTapped(EventArgs e)
        {
            EventHandler handler = ButtonTapped;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public StackLayout GetBottomToolbarButton()
        {
            StackLayout bottomToolbarButton = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
            };

            return bottomToolbarButton;
        }
    }
}
