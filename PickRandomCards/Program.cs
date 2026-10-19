using PickRandomCards;
class Program
{
    static void Main(string[] args)
    {


        Console.Write("Wpisz liczbę generowanych kart: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int numberOfCards))
        {

            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }

        }
        else
        {
            Console.Write("Wpisz prawidłową liczbę.");
        }
    }
}