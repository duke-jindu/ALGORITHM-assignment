// Write an algorithm to reverse a string

//START
//  Step 1. Input string .
//  Step 2. calculate the length of the string.
//  step 3. solve calculated length value(lenght).
//  Step 4. define start=0 and end=length-1;
//  Step 5. for i = 0 to length / 2.
//  step 6. replace the last char with the first char
//  step 7. cont until end > 0
//  step 5. Display String str1.
//STOP



//example

string company = "cyphercrescent";
string reverse = "";
int lenght = 0;

lenght = company.Length - 1;

while (lenght > 0)
{
    reverse = reverse + company[lenght];
    lenght--;
}

Console.WriteLine("the reversed string of {0} is {1}", company, reverse);
Console.ReadKey();