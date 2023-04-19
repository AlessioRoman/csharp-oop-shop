using items;
using linkedlist;

LinkedList myList = new LinkedList();

Console.WriteLine("Ciao quanti prodotti vuoi inserire?");
int numberOfProducts = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfProducts; i++)
{
    Console.WriteLine("Inserisci il nome del prodotto: ");
    string itemName = Console.ReadLine();
    Console.WriteLine("Inserisci la descrizione del prodotto: ");
    string itemDescription = Console.ReadLine();
    Console.WriteLine("Inserisci il prezzo iva esclusa: ");
    float itemPriceNoIva = float.Parse(Console.ReadLine());

    myList.InsertLast(myList, itemName, itemDescription, itemPriceNoIva);
}

Console.WriteLine();
Console.WriteLine("Ecco a te la tua lista!");
myList.printList(myList);