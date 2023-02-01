void Fill(string[]array)
{

for(int i = 0; i < array.Length; i++)
{
   array[i] = Console.ReadLine();
}
}

// печать 1мерного массива
string Print1(string[]array)
{
    return String.Join(' ', array);
}



string[]array = new string[3];
Fill(array);
Print1(array);

int count = 0;

for ( int i = 0; i < array.Length; i++)
{
    if ( array[i].Length <=3) count=count+1;
    
        count=count+1;

}


string[]newArray = new string[count];
for ( int i = 0; i < array.Length; i++)
{
    if ( array[i].Length <=3)
        newArray[i]=array[i];


       
} 
        
     
    
string array_text = Print1 (newArray);
Console.WriteLine(array_text);  

