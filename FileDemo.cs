using System;
using System.IO;

public class FileDemo
{
    public FileDemo()
    {

    }

 
    public void ReadFromFile(int[] numbers)
    {
        string path = "C:\\Users\\40659\\source\\repos\\FileSortingDemo\\FileSortingDemo\\numbers.txt";
        StreamReader sr = new StreamReader(path);
        for (int index = 0; index < numbers.Length;index++)
        {
            numbers[index] = Convert.ToInt32(sr.ReadLine());

        }
        //close file when done.
        sr.Close();
    }

    public void WriteToFile(int[] numbers)
    {
        string path = "C:\\Users\\40659\\source\\repos\\FileSortingDemo\\FileSortingDemo\\sortednumbers.txt";
        StreamWriter sw = new StreamWriter(path);
        for(int counter = 0; counter < numbers.Length; counter++)
        {
            sw.WriteLine( numbers[counter] );
        }
        sw.Close();
    }
    public void BubbleSortArray(int[] numbers)
    {
        bool swap;
        int temp;
        do
        {
            swap = false;
            for(int index=0;index < (numbers.Length - 1);index++)
            {
                if(numbers[index] > numbers[index+1])
                {
                    //swap
                    temp = numbers[index];
                    numbers[index] = numbers[index + 1];
                    numbers[index + 1] = temp;
                    swap = true;
                };
            }
        } while (swap == true);
    }
    public void DisplayArray(int[] numbers)
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write("{0} ", numbers[index]);
        }

        Console.WriteLine();
    }

}