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
            ButtonTapped?.Invoke(this, e);
        }

        public StackLayout GetBottomToolbarButton(ButtonType button)
        {
            Icon buttonIcon = new Icon();
            string buttonText = "";
            Label buttonTextLabel = new Label { Text = buttonText };

            switch (button)
            {
                case ButtonType.Policies:
                    buttonIcon = buttonIcon.MakeIcon(Icon.IconType.Solid, "\uf3ed", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Policies";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                case ButtonType.Assets:
                    buttonIcon = buttonIcon.MakeIcon(Icon.IconType.Solid, "\uf550", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Assets";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                case ButtonType.Score:
                    buttonIcon = buttonIcon.MakeIcon(Icon.IconType.Solid, "\uf3fd", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Score";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                case ButtonType.Advice:
                    buttonIcon = buttonIcon.MakeIcon(Icon.IconType.Solid, "\uf470", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Advice";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                default:
                    break;
            }

            StackLayout bottomToolbarButton = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { buttonIcon, buttonTextLabel }
            };

            return bottomToolbarButton;
        }
    }
}
