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

            InitCards();
        }

        public void InitCards()
        {
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/AH.png", "Ace of Hearts"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/AS.png", "Ace of Spades"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/AD.png", "Ace of Diamonds" ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/AC.png", "Ace of Clovthing"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/2H.png", "Ace of Hearts"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/2S.png", "Ace of Spades"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/2D.png", "Ace of Diamonds" ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/2C.png", "Ace of Clovthing"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/3H.png", "Ace of Hearts"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/3S.png", "Ace of Spades"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/3D.png", "Ace of Diamonds" ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/3C.png", "Ace of Clovthing"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/4H.png", "Ace of Hearts"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/4S.png", "Ace of Spades"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/4D.png", "Ace of Diamonds" ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/4C.png", "Ace of Clovthing"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/5H.png", "Ace of Hearts"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/5S.png", "Ace of Spades"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/5D.png", "Ace of Diamonds" ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/5C.png", "Ace of Clovthing"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/6H.png", "Ace of Hearts"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/6S.png", "Ace of Spades"   ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/6D.png", "Ace of Diamonds" ));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/6C.png", "Ace of Clovthing"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/7H.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/7S.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/7D.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/7C.png", "Ace of Hearts"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/8H.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/8S.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/8D.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/8C.png", "Ace of Hearts"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/9H.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/9S.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/9D.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/9C.png", "Ace of Hearts"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/10H.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/10S.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/10D.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/10C.png", "Ace of Hearts"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/JH.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/JS.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/JD.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/JC.png", "Ace of Hearts"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/QH.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/QS.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/QD.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/QC.png", "Ace of Hearts"));

            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/KH.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/KS.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/KD.png", "Ace of Hearts"));
            CardsList.AddCard(CardsListViewModel.CreateCard("/Resources/KC.png", "Ace of Hearts"));
        }
    }
}
