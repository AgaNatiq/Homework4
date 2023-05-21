namespace Qaralama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankCard card= new BankCard();
            card.BankName = "Kapital Bank";
            card.CardHolder = "Natig";
            card.CardNumber = 1342465596547415;
            card.CVV = 321;
            card.ExpDate = "09/23";
            
            card.IncreaseBalance(850m);
            card.DecreaseBalance(325m);

            Console.WriteLine(card.CardBalance);
        }

    }
}