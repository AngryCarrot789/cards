using cardsArefun.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsArefun.ViewModels
{
    public class CardItemViewModel : BaseViewModel
    {
        private string _imageSource;
        public string ImageSource
        {
            get => _imageSource; set => RaisePropertyChanged(ref _imageSource, value);
        }

        private string _cardName;
        public string CardName
        {
            get => _cardName;
            set => RaisePropertyChanged(ref _cardName, value);
        }
    }
}
