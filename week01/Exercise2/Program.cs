using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade persentage? ");
        string grade_percentage_string = Console.ReadLine();
        int grade_percentage = int.Parse(grade_percentage_string);

        string letter = "";
        string passed = "";

        if(grade_percentage >= 90){
            letter = "A";
        }
        else if(grade_percentage >= 80 && grade_percentage < 90){
            letter = "B";
        }
        else if(grade_percentage >= 70 && grade_percentage < 80){
            letter = "C";
        }
        else if(grade_percentage >= 60 && grade_percentage < 70){
            letter = "D";
        }
        else{
            letter = "F";
        }

        if(grade_percentage >= 70){
            passed = "Yuuuup! congratuations! You passed!";
        }
        else{
            passed = "Oh, no! you need to study more. Your percentage is not enough... Try again!";
        }
        Console.WriteLine($"{passed} your letter grade is: {letter}");
    }
}