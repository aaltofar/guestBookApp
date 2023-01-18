using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestBook;

public class Party
{
    static List<string> partyNames = new();
    static List<int> partyNumber = new();
    public static int partyTotal = 0;
    public static void WelcomeMsg()
    {
        Console.WriteLine(@"
                                                       ,----,                                                  
                                                     ,/   .`|              ,----..       ,----..          ,--. 
   ,----..                    ,---,.  .--.--.      ,`   .'  :   ,---,.    /   /   \     /   /   \     ,--/  /| 
  /   /   \           ,--,  ,'  .' | /  /    '.  ;    ;     / ,'  .'  \  /   .     :   /   .     : ,---,': / ' 
 |   :     :        ,'_ /|,---.'   ||  :  /`. /.'___,/    ,',---.' .' | .   /   ;.  \ .   /   ;.  \:   : '/ /  
 .   |  ;. /   .--. |  | :|   |   .';  |  |--` |    :     | |   |  |: |.   ;   /  ` ;.   ;   /  ` ;|   '   ,   
 .   ; /--`  ,'_ /| :  . |:   :  |-,|  :  ;_   ;    |.';  ; :   :  :  /;   |  ; \ ; |;   |  ; \ ; |'   |  /    
 ;   | ;  __ |  ' | |  . .:   |  ;/| \  \    `.`----'  |  | :   |    ; |   :  | ; | '|   :  | ; | '|   ;  ;    
 |   : |.' .'|  | ' |  | ||   :   .'  `----.   \   '   :  ; |   :     \.   |  ' ' ' :.   |  ' ' ' ::   '   \   
 .   | '_.' ::  | | :  ' ;|   |  |-,  __ \  \  |   |   |  ' |   |   . |'   ;  \; /  |'   ;  \; /  ||   |    '  
 '   ; : \  ||  ; ' |  | ''   :  ;/| /  /`--'  /   '   :  | '   :  '; | \   \  ',  /  \   \  ',  / '   : |.  \ 
 '   | '/  .':  | : ;  ; ||   |    \'--'.     /    ;   |.'  |   |  | ;   ;   :    /    ;   :    /  |   | '_\.' 
 |   :    /  '  :  `--'   \   :   .'  `--'---'     '---'    |   :   /     \   \ .'      \   \ .'   '   : |     
  \   \ .'   :  ,      .-./   | ,'                          |   | ,'       `---`         `---`     ;   |,'     
   `---`      `--`----'   `----'                            `----'                                 '---'       
                                                                                                         
_______________________________________________________________________________________________________________
***************************************************************************************************************

Welcome to GuestBook v1.0!
");
    }

    public static void AskName()
    {
        Console.WriteLine("May I have the name of your reservation?");
        Console.Write("Name: ");
        var name = Console.ReadLine();
        partyNames.Add(name);
    }

    public static void AskSize()
    {
        Console.WriteLine("And the size of your party please?");
        Console.Write("Size: ");
        var sizeTxt = Console.ReadLine();
        bool isNum = int.TryParse(sizeTxt, out int sizeNum);
        partyNumber.Add(sizeNum);
        partyTotal++;
        while (!isNum)
        {
            Console.WriteLine("Not a number, please input a number.");
            Console.Write("Size: ");
            sizeTxt = Console.ReadLine();
            isNum = int.TryParse(sizeTxt, out sizeNum);
        }

    }

    public static string AskMore()
    {
        Console.WriteLine($"You entered {partyNames[partyTotal - 1]} with a party of {partyNumber[partyTotal - 1]}");
        Console.WriteLine("Was that the last party or are there more coming?");
        Console.WriteLine("[Y] to add another party");
        Console.WriteLine("[N] to end");
        var cmd = Console.ReadLine().ToLower();
        if (cmd == "n")
        {
            return cmd;
        }
        else if (cmd == "y")
        {
            return cmd;
        }
        return string.Empty;
    }

    public static void PartyOver()
    {
        Console.WriteLine("********************************************************");
        Console.WriteLine("Party is now over, thank you for a lovely evening.");
        Console.WriteLine("Tonights attendees were: ");
        for (int i = 0; i < partyNames.Count; i++)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{partyNames[i]} with a party of {partyNumber[i]}");
            Console.WriteLine("----------------------------------------------------");
        }
        Console.WriteLine($"The total number of guests tonight was {partyNumber.Sum()}");
        Console.WriteLine("Thank you for using GuestBook!");
    }
}

