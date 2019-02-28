using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.model;

namespace ronoco.mobile.viewmodel
{
    public class PolicyCell : ViewCell
    {
        public static readonly BindableProperty GridProperty =
            BindableProperty.Create("PolicyGrid", typeof(Grid), typeof(PolicyCell), null);
        public Grid PolicyGrid
        {
            get { return (Grid)GetValue(GridProperty); }
            set { SetValue(GridProperty, value); }
        }

        public static readonly BindableProperty TypeLabelProperty =
    BindableProperty.Create(nameof(TypeLabel), typeof(string), typeof(PolicyCell), null);
        public string TypeLabel
        {
            get { return (string)GetValue(TypeLabelProperty); }
            set { SetValue(TypeLabelProperty, value); }
        }

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(nameof(Icon), typeof(string), typeof(PolicyCell), null);
        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly BindableProperty PremiumLabelProperty =
            BindableProperty.Create(nameof(PremiumLabel), typeof(decimal), typeof(PolicyCell), null);
        public decimal PremiumLabel
        {
            get { return (decimal)GetValue(PremiumLabelProperty); }
            set { SetValue(PremiumLabelProperty, value); }
        }

        public static readonly BindableProperty CompanyLabelProperty =
            BindableProperty.Create(nameof(CompanyLabel), typeof(string), typeof(PolicyCell), null);
        public string CompanyLabel
        {
            get { return (string)GetValue(CompanyLabelProperty); }
            set { SetValue(CompanyLabelProperty, value); }
        }

        public static readonly BindableProperty ExpirationLabelProperty =
            BindableProperty.Create(nameof(ExpirationLabel), typeof(DateTime), typeof(PolicyCell), null);
        public DateTime ExpirationLabel
        {
            get { return (DateTime)GetValue(ExpirationLabelProperty); }
            set { SetValue(ExpirationLabelProperty, value); }
        }

        public static readonly BindableProperty ExpirationBarProperty =
            BindableProperty.Create(nameof(ExpirationBar), typeof(double), typeof(PolicyCell), null);
        public double ExpirationBar
        {
            get { return (double)GetValue(ExpirationBarProperty); }
            set { SetValue(ExpirationBarProperty, value); }
        }

        public PolicyCell()
        {
            Label cellTypeLabel = new Label { Text = PolicyTypes.PolicyType.Boat.ToString() };

            Image cellIcon = new Image();
            switch (TypeLabel)
            {
                case "Boat":
                    cellIcon.Source = ImageSource.FromFile(Icon);
                    break;
                default:
                    cellIcon.Source = ImageSource.FromFile("policyIconBoat.png");
                    break;
            }
            cellIcon.VerticalOptions = LayoutOptions.StartAndExpand;
            cellIcon.HorizontalOptions = LayoutOptions.CenterAndExpand;
            
            PremiumLabel = new decimal(1.0);
            Label cellPremiumLabel = new Label { Text = PremiumLabel.ToString() };
            Label cellCompanyLabel = new Label(); //{ Text = CompanyLabel };
            cellCompanyLabel.SetBinding(Label.TextProperty, new Binding("CompanyName"));
            Label cellExpirationLabel = new Label { Text = ExpirationLabel.ToShortDateString() };
            ProgressBar cellExpirationBar = new ProgressBar { Progress = ExpirationBar };

            Grid PolicyGrid = new Grid();

            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(11, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(15, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(78, GridUnitType.Absolute) });
            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) });

            PolicyGrid.Children.Add(cellIcon, 0, 0);
            Grid.SetRowSpan(cellIcon, 6);
            

            PolicyGrid.Children.Add(cellTypeLabel, 1, 1);
            PolicyGrid.Children.Add(cellCompanyLabel, 1, 3);
            PolicyGrid.Children.Add(cellExpirationBar, 1, 5);
            Grid.SetColumnSpan(cellExpirationBar, 2);
            PolicyGrid.Children.Add(cellPremiumLabel, 2, 1);
            PolicyGrid.Children.Add(cellExpirationLabel, 2, 3);
            PolicyGrid.Padding = new Thickness(0, 10);

            View = PolicyGrid;
        }
    }
}
