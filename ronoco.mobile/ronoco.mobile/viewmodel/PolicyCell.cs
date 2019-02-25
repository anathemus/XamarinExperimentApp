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
            Image icon = new Image();
            Label typeLabel = new Label();
            Label premiumLabel = new Label();
            Label companyLabel = new Label();
            Label expirationLabel = new Label();
            ProgressBar expirationBar = new ProgressBar();

            typeLabel.SetBinding(Label.TextProperty, "PolicyType");

            switch (typeLabel.Text)
            {
                case "Boat":
                    icon.Source = ImageSource.FromFile("policyIconBoat.png");
                    break;
                default:
                    break;
            }

            premiumLabel.SetBinding(Label.TextProperty, "PolicyPremium");
            companyLabel.SetBinding(Label.TextProperty, "CompanyName");
            expirationLabel.SetBinding(Label.TextProperty, "PolicyExpirationDate");
            expirationBar.SetBinding(ProgressBar.ProgressProperty, "PolicyExpirationDateFractionDouble");

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

            grid.Children.Add(icon, 0, 0);
            Grid.SetRowSpan(icon, 6);
            grid.Children.Add(typeLabel, 1, 1);
            grid.Children.Add(companyLabel, 1, 3);
            grid.Children.Add(expirationBar, 1, 5);
            Grid.SetColumnSpan(expirationBar, 2);
            grid.Children.Add(premiumLabel, 2, 1);
            grid.Children.Add(expirationLabel, 2, 3);

            View = grid;
        }
    }
}
