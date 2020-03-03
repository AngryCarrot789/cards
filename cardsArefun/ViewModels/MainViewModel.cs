using cardsArefun.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsArefun.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public CardsListViewModel CardsList { get; set; }

        public MainViewModel()
        {
            CardsList = new CardsListViewModel();
        }
    }
}
