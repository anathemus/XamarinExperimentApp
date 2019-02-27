using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.model;

namespace ronoco.mobile.viewmodel
{
    public class PolicyCell : ViewCell
    {        
        public PolicyCell()
        { 
            Image Icon = new Image();
            Label TypeLabel = new Label();
            Label PremiumLabel = new Label();
            Label CompanyLabel = new Label();
            Label ExpirationLabel = new Label();
            ProgressBar ExpirationBar = new ProgressBar();

            TypeLabel.SetBinding(Label.TextProperty, "PolicyType");

            switch (TypeLabel.Text)
            {
                case "Boat":
                    Icon.Source = ImageSource.FromFile("policyIconBoat.png");
                    break;
                default:
                    break;
            }

            PremiumLabel.SetBinding(Label.TextProperty, "PolicyPremium");
            CompanyLabel.SetBinding(Label.TextProperty, "CompanyName");
            ExpirationLabel.SetBinding(Label.TextProperty, "PolicyExpirationDate");
            ExpirationBar.SetBinding(ProgressBar.ProgressProperty, "PolicyExpirationDateFractionDouble");

            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(21, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(15, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(78, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) });

            grid.Children.Add(Icon, 0, 0);
            Grid.SetRowSpan(Icon, 6);
            grid.Children.Add(TypeLabel, 1, 1);
            grid.Children.Add(CompanyLabel, 1, 3);
            grid.Children.Add(ExpirationBar, 1, 5);
            Grid.SetColumnSpan(ExpirationBar, 2);
            grid.Children.Add(PremiumLabel, 2, 1);
            grid.Children.Add(ExpirationLabel, 2, 3);

            View = grid;
        }
    }
}
