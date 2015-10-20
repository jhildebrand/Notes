//C# String Operations 

//Concatentation, +
string mm = “Hello”; 
string nx = “good buddy”; 
string c = mm + nx; 
console.writeline(c);  //prints Hellogood buddy

//Length
//Length() method finds the number of characters in a string.
int len = c.Length; //len = 15


//Substring
//.Substring(beginning index, length of string)
Console.WriteLine(c.Substring(2,6));  //prints llogoo

//Lower/Upper
string low = c.ToLower(); //changes all char in string to lower case
string up = c.ToUpper(); //changes char in string to upper case
