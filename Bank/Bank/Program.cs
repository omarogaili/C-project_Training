using Bank;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> mylist = new List<Person>();
        Console.WriteLine("O.I.E.N BANK ");
        Console.WriteLine(" Välkommen");
        // första listan där man ska välja mellan lagga in eller skapa en ny konto eller avsluta
        while (true)
        {
            Console.WriteLine("[L]ogga in");
            Console.WriteLine("[S]kapa konto");
            Console.WriteLine("[A]vsluta");
            string chosseOne= Console.ReadLine();
            //här ska vi lägga allt man kan göra efter att man har skapat ett konto
            if (chosseOne == "L"|| chosseOne=="l")
            {
                Console.Write("Använd namn");
                string userName= Console.ReadLine();
                Console.Write("Din personnummer:");
                string password= Console.ReadLine();
                // här så har vi gjort en sökning på
                for(int i = 0; i < mylist.Count; i++)
                {
                    if (userName == mylist[i].UserName && password == mylist[i].PassWord)
                    {
                        Console.WriteLine($"Välkommen {mylist[i].UserName}");

                        //meny Två
                        int inMony;
                        while (true)
                        {
                            Console.WriteLine("[S]ätta in pengar");
                            Console.WriteLine("S[p]ara hos oss");
                            Console.WriteLine("[A]vdrag");
                            string chosseTwo= Console.ReadLine();
                            if (chosseTwo == "S" || chosseTwo == "s")
                            {
                                Console.Write("hur mycket vill du sätta in");
                                 inMony= Convert.ToInt32(Console.ReadLine());

                            }
                            else if (chosseTwo == "P" || chosseTwo == "p")
                            {
                                int kapitaltEttÅr = inMony * (int)0.2;
                            }
                        }

                    }
                    Console.WriteLine("Du behöver skapa ett konto först");


                    //else if (userName !=mylist[i].UserName && password!= mylist[i].PassWord)
                    // {
                    // Console.WriteLine("Du behöver skapa ett konto först");
                    // }

                }


            }
            if (chosseOne == "S"|| chosseOne== "s")
            {
                // här säger till användaren att mata in sitt namn och sedan sin personnummer 
                // vi använder oss av metoden string.isnullorEmpty för att kontorella om det skriven något där
                //annars säger vi fel.
                Console.Write("Ange ditt namn:");
                string namne= Console.ReadLine();
                if (string.IsNullOrEmpty(namne))
                {
                    Console.WriteLine("Ogiligt skriv ditt namn");
                }

                Console.WriteLine("Ange din Personnummer");
                string personNummer=Console.ReadLine();

                //här skapar vi en objekt som heter person för att anropa klassen Person. den objekten ska ha de 
                //två info saker som vi behöver namn och personnummer och sedan säger vi att den person (objektet)
                //lagrar vi i listan genom att skriva mylist och add person. 
                Person person= new Person { UserName=  namne, PassWord= personNummer};
                mylist.Add(person);

            }
        }
    }
}