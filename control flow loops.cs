//Control Flow and Loops

{/*if statments

if (condition){
	statement;	
}
*/

//example
int x = 5;
if (x < 10){
	Console.WriteLine("Less than 10");
}
}

{/*if-else
if (condition_1){
	statement_1;
}
else{
	statement_2;
}
*/

//example
int x = 5;
if (x > 10){
	Console.WriteLine("{0} is greater than 10", x);
}
else{
	Console.WriteLine("{0} is less than or equal to 10", x);
}
}

{/*if - else if - else
if (condition_1){
	statement_1;
}
else if (condition_2){
	statement_2;
}
else{
	statement_3;
}
*/

//example
int x = 5;
if (x > 10){
	Console.WriteLine("{0} is greater than 10", x);
}
else if (x < 10){
	Console.WriteLine("{0} is less than 10", x);
}
else{
	Console.WriteLine("{0} equals 10", x);
}
}

{/*Boolean Opperators
&& is and
|| is or
! is not
*/

//example
float money = 8.56f;
string pizza = "yes";
if (money >= 6.50 && pizza == "yes") {
	Console.WriteLine ("Order pizza!");
} else if (money < 6.50 && pizza == "yes") {
	Console.WriteLine ("No pizza, I'm short ${0}.", (Math.Abs(money - 6.50f)));
} else if (pizza == "no") {
	Console.WriteLine ("When the question is pizza, the answer is never no!");
}
}

{/*for Loops
for (initializers; condition; iterators) {
	statement;
}
*/

//example
//Loops through the integers 1 to less than 6, writing each to the console.
for (int i = 1; i < 6; i++){ 
    Console.WriteLine(i); 
}
}

{/*while Loops
while (condition) {
	statement;
}
*/
//example
int n = 1;
while (n < 6){
    Console.WriteLine("Current value of n is {0}", n);
    n++;
}	
}

{/*do -while
do{
	statement;
}
while(condition);
*/
//example
int x = 0;
do 
{
    Console.WriteLine(x);
    x++;
} while (x < 5);
}


