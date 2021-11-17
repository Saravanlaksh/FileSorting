using System;

public class FileDemoCheck
{

    public static void Main(string[] args)
    {
        int[] numbers = new int[10];
        FileDemo obj = new FileDemo();

        //Call the read from file method
        obj.ReadFromFile( numbers );
        //Display the unsorted values
        Console.Write("unsorted: ");
        obj.DisplayArray( numbers );

        //sort the numbers and display them again
        obj.BubbleSortArray( numbers );
        Console.Write("sorted: ");
        obj.DisplayArray( numbers );

        //save your data
        obj.WriteToFile( numbers);
    }
}