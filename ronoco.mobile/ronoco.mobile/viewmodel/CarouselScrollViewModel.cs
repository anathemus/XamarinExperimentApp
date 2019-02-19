using System.Collections.ObjectModel;
using System.Linq;

namespace ronoco.mobile.viewmodel
{
    public class CarouselScrollViewModel
    {
        public CarouselScrollViewModel()
        {
            Items = new ObservableCollection<object>(Enumerable.Range(1, 3).Select(i => new { Number = i }).ToArray());
        }

        public ObservableCollection<object> Items { get; }
    }
}
