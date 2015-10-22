//Additional Notes for Control Flow/Loops

{/*Convert string to int

For user input you will need to convert the string created by the .ReadLine() method into an integer.
Use the code below.
*/
int num = Convert.ToInt32(Console.ReadLine()); //num is the name of integer
}

{/*Random Integer Generator

For Task 3 you will need to generate a random number between 1 and 99 inclusive
Use the code below
*/
Random rand = new Random(); //rand is the name of the random integer
int random = rand.Next(1,100);
	
}

