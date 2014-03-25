using System;

class BankAccountData 
{
    static void Main()
    {
        string firstname = "Tsvetan";
        string middlename = "Iuliev";
        string lastname = "Topalov";
        decimal cash = 39450.57m;
        string bank = "FIBank";
        string iban = "BG11 U42U 8249 2134 6752 11";
        long card1 = 645454511515321;
        long card2 = 541927514764534;
        long card3 = 604562517514643;
        Console.WriteLine("{0} {1} {2}\nCash: {3}\nBank: {4} \nIBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstname, middlename, lastname, cash, bank, iban, card1, card2, card3);
    }
}

