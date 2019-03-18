using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ronoco.mobile.constants
{
    public class RonocoGrid : Grid
    {
        public static Grid RonocoBackArrowGrid = new Grid
        {
            RowDefinitions =
            {
                // new RowDefinition { Height = new GridLength(64, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(34, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(27, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(8, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(50, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(16, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) }
            },

            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(272, GridUnitType.Absolute) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }

        };

        public static Grid RonocoBottomToolbarTabsGrid = new Grid
        {
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.FillAndExpand,
            ColumnSpacing = 0,
            RowSpacing = 0,
            Padding = 0,

            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) }
            },

            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
        };

        public Grid RonocoPolicyViewGrid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(72, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(28, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(41, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(41, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(41, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(41, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(48, GridUnitType.Absolute) }
            },

            ColumnDefinitions = new ColumnDefinitionCollection
            {

                new ColumnDefinition { Width = new GridLength(48, GridUnitType.Absolute) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(48, GridUnitType.Absolute) }
            },

            ColumnSpacing = 0,
            RowSpacing = 0
        };

        public Grid RonocoMenuGrid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(104, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) }
            },

            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(56, GridUnitType.Absolute) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
        };
    }
    // push to GitHub
}
