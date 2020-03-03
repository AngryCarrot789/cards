using cardsArefun.Cards;
using cardsArefun.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsArefun.ViewModels
{
    public class CardsListViewModel : BaseViewModel
    {
        private ObservableCollection<CardListItem> _cardsList = new ObservableCollection<CardListItem>();
        public ObservableCollection<CardListItem> CardsList
        {
            get => _cardsList;
            set => RaisePropertyChanged(ref _cardsList, value);
        }

        private CardListItem _selectedCard;
        public CardListItem SelectedCard
        {
            get => _selectedCard;
            set
            {
                RaisePropertyChanged(ref _selectedCard, value);
                SelectedCardViewModel = value.DataContext as CardItemViewModel;
            }
        }

        private CardItemViewModel _selectedCardVM;
        public CardItemViewModel SelectedCardViewModel
        {
            get => _selectedCardVM;
            set => RaisePropertyChanged(ref _selectedCardVM, value);
        }

        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set => RaisePropertyChanged(ref _selectedIndex, value);
        }

        public void AddCard(CardListItem cli)
        {
            CardsList.Add(cli);
        }

        public static CardListItem CreateCard(string imageSource, string cardName)
        {
            CardItemViewModel civm = new CardItemViewModel();
            CardListItem cli = new CardListItem();
            cli.DataContext = civm;

            civm.ImageSource = imageSource;
            civm.CardName = cardName;

            return cli;
        }

        public void RemoveCard(CardListItem cli)
        {
            CardsList.Remove(cli);
        }
    }
}
