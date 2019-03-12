using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    class EntryField : Frame
    {
        public EntryField CreateEntryField(Icon icon, Keyboard keyboard, bool isPassword)
        {
            BackgroundColor = Color.FromRgb(230, 230, 230);
            Padding = new Thickness(20,0,20,0);
            CornerRadius = 25;
            WidthRequest = 232;

            Entry entry = new Entry
            {
                BackgroundColor = Color.FromRgb(230,230,230),
                Keyboard = keyboard,
                FontFamily = "SFUIText-Semibold",
                FontSize = 16,
                WidthRequest = 215,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                IsPassword = isPassword
            };

            icon.HorizontalOptions = LayoutOptions.End;

            StackLayout layout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                WidthRequest = 232,
                Children = { entry, icon }
            };

            Content = layout;

            return this;
        }
    }
}