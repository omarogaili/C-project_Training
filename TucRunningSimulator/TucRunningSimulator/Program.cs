using System.ComponentModel;

internal class Program
{
    // ==============================  NY kom.. ========================================== //
    private static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Long Distance Runner-Spelet");
        Console.WriteLine("**********************************************************");
        int distence = 10;
        
        while(true)
        {
            Console.WriteLine("Välj:");
            Console.WriteLine("Börja löpningen");
            Console.WriteLine("Avsluta löpningen");
            string chosseMenu= Console.ReadLine();
            Console.WriteLine("===========================================================");
            if (chosseMenu == "B" || chosseMenu == "b")
            {
                
                Console.WriteLine("Du har initial energi enheter:");
                Console.Write("Ange din energinivå:");           
                int engery= Convert.ToInt32(Console.ReadLine());

            
        
        while (distence >= 0)
        {
            
            Console.WriteLine("välj din hastighet för nästa 1 km  ([1]snabbast, [2]snabb, [3]måttlig, [4]långsam, [5]promenad");
            int val=int.Parse(Console.ReadLine());
           

            switch (val)
            {
                case 1:
                    
                    int running = 2;// hur mycket har man springet 2 km
                    distence = distence - running;// tar vi bort 2km av den totalla 10km
                    int minskningAvEnergi = 15; /// vad det kostar spelaren att springa jättesnabbt
                    engery = engery - minskningAvEnergi;// minska´kosnaden från det total
                    
                    Console.WriteLine($" kvar på din energi: {engery}. avståndet i dem loopen är : {running} km {distence}");
                            Console.WriteLine("*************************************************************************");
                    break;
                    
                case 2:
                    int afterOne = distence;
                    int runningOne = 1;
                    distence = afterOne - runningOne ;// lägg till 1 sedan för att förhinnda minskningen i case 2.
                    //annars så kommer den och minska 2 för varje gång i loopen. 
                    int energiNivåOne = 10;
                    engery = engery - energiNivåOne ;
                    
                    Console.WriteLine($"kvar på din energi: {engery}. avståndet i dem loopen är : {runningOne} km {distence}");
                            Console.WriteLine("*************************************************************************");

                            break;

                case 3:
                    int forbrukEnThree= engery;
                    int afterTwo= distence;
                    int energiNivåTwo = 8;
                    engery = forbrukEnThree - energiNivåTwo;
                    int runningTwo= 1;
                            distence = afterTwo - runningTwo;
                    Console.WriteLine($"kvar på din energi: {engery}. avståndet i dem loopen är : {runningTwo} km {distence}");
                            Console.WriteLine("*************************************************************************");


                            break;
                    case 4:
                    int forbrukEnFour= engery;
                    int afterThree= distence;
                    int runningThree= 1;
                    int energiNivåThree = 5;
                    engery = forbrukEnFour - energiNivåThree;
                            distence = afterThree - runningThree;
                    Console.WriteLine($"kvar på din energi: {engery}. avståndet i dem loopen är : {runningThree} km {distence}");
                            Console.WriteLine("*************************************************************************");


                            break;

                case 5:      
                     int afterFour= distence;
                     int runningFour= 1;
                            distence = afterFour - runningFour;
                     int energiNivåFour = 2;
                     engery = engery - energiNivåFour;
                    Console.WriteLine($"kvar på din energi: {engery}. avståndet i dem loopen är : {runningFour} km {distence}");
                            Console.WriteLine("*************************************************************************");

                            break;



                    default: 
                    Console.WriteLine("Ogiltigt val");
                    break;
                    
                  
            }

            if (engery <= 0 || distence==0)//avsluta om energin är 0 
            {
                Console.WriteLine("Du klarade inte det Tyvärr! försök igen");
                break;
            }
            else if( engery <=1  || distence <=0) 
            {
                Console.WriteLine($"DU ÄR GRYM !!! Bra jobbat du har klarat hela 10km och du har klvar {engery} kvar");
            }

               
            }
        }
            else if (chosseMenu == "A" || chosseMenu == "a")
            {
                Console.WriteLine("Hejdå!");
                break;
            }
    }

    }
}