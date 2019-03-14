using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class RonocoToolbarButton : StackLayout
    {
        public enum ButtonType
        {
            Policies,
            Assets,
            Score,
            Advice
        }

        public RonocoToolbarButton GetNavToolbarButton(Icon.IconType type, string unicodeIcon, Color color)
        {
            Icon icon = new Icon().MakeIconImage(type, unicodeIcon, color);
            TapGestureRecognizer tap = new TapGestureRecognizer();

            RonocoToolbarButton toolbarButton = new RonocoToolbarButton
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { icon }
            };
            toolbarButton.GestureRecognizers.Add(tap);

            return toolbarButton;
        }

        public RonocoToolbarButton GetTabToolbarButton(string iconText, Color color)
        {
            Icon icon = new Icon().MakeIconText(iconText, color);
            TapGestureRecognizer tap = new TapGestureRecognizer();

            RonocoToolbarButton toolbarButton = new RonocoToolbarButton
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = { icon }
            };
            toolbarButton.GestureRecognizers.Add(tap);

            return toolbarButton;
        }

        public RonocoToolbarButton GetBottomToolbarButton(ButtonType button)
        {
            Icon buttonIcon = new Icon();
            string buttonText = "";
            Label buttonTextLabel = new Label { Text = buttonText };

            switch (button)
            {
                case ButtonType.Policies:
                    buttonIcon = buttonIcon.MakeIconImage(Icon.IconType.Solid, "\uf3ed", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Policies";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                case ButtonType.Assets:
                    buttonIcon = buttonIcon.MakeIconImage(Icon.IconType.Solid, "\uf550", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Assets";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                case ButtonType.Score:
                    buttonIcon = buttonIcon.MakeIconImage(Icon.IconType.Solid, "\uf3fd", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Score";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                case ButtonType.Advice:
                    buttonIcon = buttonIcon.MakeIconImage(Icon.IconType.Solid, "\uf470", Color.FromRgb(80, 80, 100));
                    buttonIcon.VerticalOptions = LayoutOptions.Center;
                    buttonIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
                    buttonText = "Advice";
                    buttonTextLabel = new Label { Text = buttonText };
                    break;
                default:
                    break;
            }

            RonocoToolbarButton bottomToolbarButton = new RonocoToolbarButton
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = { buttonIcon, buttonTextLabel }
            };
            bottomToolbarButton.GestureRecognizers.Add(new TapGestureRecognizer());

            return bottomToolbarButton;
        }
    }
}
