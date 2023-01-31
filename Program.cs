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


// Создание нового массива из первого по указанным условиям
//void NewArray(string[]array)
//{

  
    


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


        // for ( int j=0; j<count; j++) 
        // {
        //     newArray[j]=array[i];
        // }       
         // string array_text = Print1 (newArray);
         // Console.Write(array_text);
         // Console.Write($"[{string.Join(", ", newArray)}]");
          //Console.Write( array[i]);
          //Console.Write("   ");
         //return (newArray);
} 
        
     //string array_text = Print1 (newArray);
     //Console.Write(array_text);
    
string array_text = Print1 (newArray);
Console.WriteLine(array_text);  

