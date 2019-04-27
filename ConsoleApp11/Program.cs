using System;
using System.Collections.Generic;

class Learn
{
    public static int Main()
    {
        var com = new List<char>();
        com.Add('c');
        com.Add('o');
        com.Add('m');
        com.Add('p');
        com.Add('u');
        com.Add('t');
        com.Add('e');
        com.Add('r');

        for (int i = 0; i < com.Count; i++)
            Console.Write("{0}", com[i]);
        Console.WriteLine();

        com.Remove('r');


        for (int i = 0; i < com.Count; i++)
            Console.Write("{0}", com[i]);
        Console.WriteLine();

        return 0;
    }
}