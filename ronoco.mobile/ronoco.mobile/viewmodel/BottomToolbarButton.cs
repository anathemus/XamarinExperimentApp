using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    class BottomToolbarButton
    {
        public event EventHandler ButtonTapped;

        public enum ButtonType
        {
            Policies,
            Assets,
            Score,
            Advice
        }

        protected virtual void OnBottomButtonTapped(EventArgs e)
        {
            EventHandler handler = ButtonTapped;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public StackLayout GetBottomToolbarButton(ButtonType button)
        {
            Icon buttonIcon = new Icon();
            string buttonText = "";
            Label buttonTextLabel = new Label { Text = buttonText };
            StackLayout bottomToolbarButton = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {buttonIcon, buttonTextLabel}
            };

            switch (button)
            {
                case ButtonType.Policies:
                    buttonIcon = new Icon { FontIcon = "fas-shield-alt", IconColor = Color.FromRgb(80, 80, 100) };
                    buttonText = "Policies";
                    buttonTextLabel.Text = buttonText;
                    bottomToolbarButton.Children.Clear();
                    bottomToolbarButton.Children.Add(buttonIcon);
                    bottomToolbarButton.Children.Add(buttonTextLabel);
                    break;
                case ButtonType.Assets:
                    break;
                case ButtonType.Score:
                    break;
                case ButtonType.Advice:
                    break;
                default:
                    break;
            }
            return bottomToolbarButton;
        }
    }
}
