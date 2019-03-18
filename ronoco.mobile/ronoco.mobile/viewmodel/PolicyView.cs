using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ronoco.mobile.tests;

using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class PolicyView : ContentView
    {
        public StackLayout TopToolbar { get; set; }
        public PolicyView()
        {
            Image policyImages = new Image();
            FileImageSource policyImageSource = new FileImageSource();
            policyImageSource.SetBinding(FileImageSource.FileProperty, new Binding("PolicyImageFileString"));
            policyImages.Source = policyImageSource;
            policyImages.HorizontalOptions = LayoutOptions.CenterAndExpand;
            policyImages.VerticalOptions = LayoutOptions.CenterAndExpand;
            policyImages.Aspect = Aspect.AspectFit;

            Image policyIcon = new Image();
            FileImageSource policyIconSource = new FileImageSource();
            policyIconSource.SetBinding(FileImageSource.FileProperty, new Binding("PolicyIconFileString"));
            policyIcon.Source = policyIconSource;
            policyIcon.HorizontalOptions = LayoutOptions.Center;
            policyIcon.VerticalOptions = LayoutOptions.Center;

            StackLayout policyIconLayout = new StackLayout
            {
                // Horizontal StackLayout with custom right side Thickness to align policyIcon
                Padding = new Thickness(0, 0, 50, 0),
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = { policyIcon }
            };

            Label policyNameLabel = new Label();
            policyNameLabel.FontFamily = "SFUIText-Bold";
            policyNameLabel.FontSize = 18;
            policyNameLabel.FontAttributes = FontAttributes.Bold;
            policyNameLabel.TextColor = Color.FromRgb(80, 80, 100);
            policyNameLabel.SetBinding(Label.TextProperty, new Binding("PolicyName"));
            policyNameLabel.VerticalOptions = LayoutOptions.Center;
            policyNameLabel.HorizontalOptions = LayoutOptions.Center;

            // instantiate StaticLabel class to simplify creation of StaticLabels
            StaticLabel staticLabel = new StaticLabel();

            Label companyStaticLabel = new Label();
            companyStaticLabel = staticLabel.CreateStaticLabel("Company");

            // companyLabel text color is in blue, so cannot apply VariableLabel class
            Label companyLabel = new Label();
            companyLabel.FontFamily = "SFUIText-Semibold";
            companyLabel.FontSize = 16;
            companyLabel.TextColor = Color.FromRgb(70, 120, 200);
            companyLabel.HorizontalTextAlignment = TextAlignment.End;
            companyLabel.VerticalOptions = LayoutOptions.Center;
            companyLabel.SetBinding(Label.TextProperty, new Binding("CompanyName"));

            Label policyNumberStaticLabel = new Label();
            policyNumberStaticLabel = staticLabel.CreateStaticLabel("Policy Number");

            // instantiate VariableLabel to simplify further creation of VariableLabels
            VariableLabel variableLabel = new VariableLabel();

            Label policyNumberLabel = new Label();
            policyNumberLabel = variableLabel.CreateVariableLabel(new Binding("PolicyNumber"));

            Label expirationDateStaticLabel = new Label();
            expirationDateStaticLabel = staticLabel.CreateStaticLabel("Expires");

            Label expirationDateLabel = new Label();
            expirationDateLabel = variableLabel.CreateVariableLabel(new Binding("PolicyExpirationDateString"));

            Label premiumStaticLabel = new Label();
            premiumStaticLabel = staticLabel.CreateStaticLabel("Premium");

            Label premiumLabel = new Label();
            premiumLabel = variableLabel.CreateVariableLabel(new Binding("PolicyPremiumString"));

            RonocoToolbar bottomToolbar = new RonocoToolbar().MakeBottomRonocoToolbar(Color.FromRgb(202, 202, 208), Color.FromRgb(80, 80, 100));

            Label titleLabel = new Label
            {
                FontFamily = "SFUIText-Semibold",
                FontSize = 16,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("PolicyTypeString"));
            titleLabel.Text += " Policy";

            Icon plusIcon = new Icon().MakeIconImage(viewmodel.Icon.IconType.Solid, "\uf067", Color.White);
            TapGestureRecognizer plusTap = new TapGestureRecognizer();

            RonocoToolbarButton plusMiniMenuButton = new RonocoToolbarButton
            {
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Children = { plusIcon }
            };
            plusMiniMenuButton.GestureRecognizers.Add(plusTap);
            plusTap.Tapped += new view.PolicyPage().PlusMiniMenuButton_Clicked;

            RonocoToolbar topToolbar = new RonocoToolbar().MakeRonocoToolbar(Color.FromRgb(70, 120, 200));
            topToolbar.Padding = new Thickness(10, 0);
            topToolbar.Children.Add(titleLabel);
            topToolbar.Children.Add(plusMiniMenuButton);
            TopToolbar = topToolbar;

            Grid policyGrid = new Grid();
            constants.RonocoGrid constantsGrid = new constants.RonocoGrid();
            policyGrid = constantsGrid.RonocoPolicyViewGrid;

            policyGrid.Children.Add(policyImages, 0, 0);
            Grid.SetColumnSpan(policyImages, 4);

            //BoxView to create grey row appearance for policyIcon and policyNameLabel
            BoxView greyPolicyNameView = new BoxView
            {
                Color = Color.FromRgb(230, 230, 230)
            };

            //instantiate GreyRowLine classes to create lines between rows in main policy page content
            GreyRowLine rowLine = new GreyRowLine();
            BoxView rowLineOne = new BoxView();
            BoxView rowLineTwo = new BoxView();
            BoxView rowLineThree = new BoxView();
            rowLineOne = rowLine.AddGreyRowLine();
            rowLineTwo = rowLine.AddGreyRowLine();
            rowLineThree = rowLine.AddGreyRowLine();

            policyGrid.Children.Add(greyPolicyNameView, 0, 1);
            Grid.SetColumnSpan(greyPolicyNameView, 4);

            policyGrid.Children.Add(policyIconLayout, 0, 1);
            Grid.SetColumnSpan(policyIconLayout, 2);

            policyGrid.Children.Add(policyNameLabel, 0, 1);
            Grid.SetColumnSpan(policyNameLabel, 4);

            policyGrid.Children.Add(companyStaticLabel, 1,3);

            policyGrid.Children.Add(companyLabel, 2, 3);

            policyGrid.Children.Add(rowLineOne, 1, 3);
            Grid.SetColumnSpan(rowLineOne, 2);

            policyGrid.Children.Add(policyNumberStaticLabel, 1, 4);

            policyGrid.Children.Add(policyNumberLabel, 2, 4);

            policyGrid.Children.Add(rowLineTwo, 1, 4);
            Grid.SetColumnSpan(rowLineTwo, 2);

            policyGrid.Children.Add(expirationDateStaticLabel, 1, 5);

            policyGrid.Children.Add(expirationDateLabel, 2, 5);

            policyGrid.Children.Add(rowLineThree, 1, 5);
            Grid.SetColumnSpan(rowLineThree, 2);

            policyGrid.Children.Add(premiumStaticLabel, 1, 6);

            policyGrid.Children.Add(premiumLabel, 2, 6);

            policyGrid.Children.Add(bottomToolbar, 0, 8);
            Grid.SetColumnSpan(bottomToolbar, 4);

            ScrollView policyScroller = new ScrollView
            {
                Content = policyGrid,
                HeightRequest = App.Current.MainPage.Height
            };

            Content = policyScroller;
        }
    }
}