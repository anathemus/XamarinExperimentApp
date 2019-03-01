using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ronoco.mobile.model;
using ronoco.mobile.interfaces;

namespace ronoco.mobile.viewmodel
{
    public class PolicyCell : ViewCell, IPolicyCell
    {
    //    public static readonly BindableProperty TypeLabelProperty =
    //BindableProperty.Create(nameof(TypeLabel), typeof(string), typeof(PolicyCell), null);
        public Label TypeLabel { get; set; }
    //    {
    //        get { return (string)GetValue(TypeLabelProperty); }
    //        set { SetValue(TypeLabelProperty, value); }
    //    }

    //    public static readonly BindableProperty IconProperty =
    //        BindableProperty.Create(nameof(Icon), typeof(string), typeof(PolicyCell), null);
        public Image Icon { get; set; }
    //    {
    //        get { return (string)GetValue(IconProperty); }
    //        set { SetValue(IconProperty, value); }
    //    }

    //    public static readonly BindableProperty PremiumLabelProperty =
    //        BindableProperty.Create(nameof(PremiumLabel), typeof(decimal), typeof(PolicyCell), null);
        public Label PremiumLabel { get; set; }
    //    {
    //        get { return (decimal)GetValue(PremiumLabelProperty); }
    //        set { SetValue(PremiumLabelProperty, value); }
    //    }

    //    public static readonly BindableProperty CompanyLabelProperty =
    //        BindableProperty.Create(nameof(CompanyLabel), typeof(string), typeof(PolicyCell), null);
        public Label CompanyLabel { get; set; }
        //    {
        //        get { return (string)GetValue(CompanyLabelProperty); }
        //        set { SetValue(CompanyLabelProperty, value); }
        //    }

        //public static readonly BindableProperty ExpirationLabelDateProperty =
        //    BindableProperty.Create(nameof(ExpirationLabel), typeof(DateTime), typeof(PolicyCell), null);
        //public DateTime ExpirationLabelDate
        //{
        //    get { return (DateTime) GetValue(ExpirationLabelDateProperty); }
        //    set { SetValue(ExpirationLabelDateProperty, value); }
        //}
        public Label ExpirationLabel { get; set; }

        //    public static readonly BindableProperty ExpirationBarProperty =
        //        BindableProperty.Create(nameof(ExpirationBar), typeof(double), typeof(PolicyCell), null);
        public ProgressBar ExpirationBar { get; set; }

        //    {
        //        get { return (double)GetValue(ExpirationBarProperty); }
        //        set { SetValue(ExpirationBarProperty, value); }
        //    }

        public PolicyCell()
        {
            TypeLabel = new Label();
            TypeLabel.SetBinding(Label.TextProperty, new Binding("PolicyTypeString"));

            Icon = new Image();
            switch (TypeLabel.Text)
            {
                case "Boat":
                    Icon.Source = ImageSource.FromFile("policyIconBoat.png");
                    break;
                default:
                    Icon.Source = ImageSource.FromFile("policyIconBoat.png");
                    break;
            }
            Icon.VerticalOptions = LayoutOptions.StartAndExpand;
            Icon.HorizontalOptions = LayoutOptions.CenterAndExpand;

            PremiumLabel = new Label();
            PremiumLabel.SetBinding(Label.TextProperty, new Binding("PolicyPremiumString"));
            CompanyLabel = new Label { FontFamily = "SFUIDisplay-Light", FontSize = 10 };
            CompanyLabel.SetBinding(Label.TextProperty, new Binding("CompanyName"));
            ExpirationLabel = new Label();
            ExpirationLabel.SetBinding(Label.TextProperty, new Binding("PolicyExpirationDateString"));
            ExpirationBar = new ProgressBar();
            ExpirationBar.SetBinding(ProgressBar.ProgressProperty, new Binding("PolicyExpirationDateFractionDouble"));

            Grid PolicyGrid = new Grid();

            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(15, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(7, GridUnitType.Absolute) });
            PolicyGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(78, GridUnitType.Absolute) });
            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            PolicyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) });

            PolicyGrid.HorizontalOptions = LayoutOptions.FillAndExpand;
            PolicyGrid.VerticalOptions = LayoutOptions.FillAndExpand;

            PolicyGrid.Children.Add(Icon, 0, 0);
            Grid.SetRowSpan(Icon, 6);
            

            PolicyGrid.Children.Add(TypeLabel, 1, 1);
            PolicyGrid.Children.Add(CompanyLabel, 1, 3);
            PolicyGrid.Children.Add(ExpirationBar, 1, 5);
            Grid.SetColumnSpan(ExpirationBar, 2);
            PolicyGrid.Children.Add(PremiumLabel, 2, 1);
            PolicyGrid.Children.Add(ExpirationLabel, 2, 3);
            PolicyGrid.Padding = new Thickness(0, 14);

            View = PolicyGrid;
        }
    }
}
