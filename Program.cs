// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//! 7/31/23

//?Loop that prints all values from 1-255
// for (int i = 1; i <= 255; i++) {
//     Console.WriteLine(i);
// }


//? creating a loop that generates 5 random numbers between 10 and 20
// Random rand = new Random();
// for(int i = 1; i <= 5; i++){
//     Console.WriteLine(rand.Next(10,21));
// }


//? add the random values together and print the sum after the loop finishes
// int sum = getRandomSum();

// int getRandomSum() {
// Random rand = new Random();
// int sum = 0;
// for(int i = 1; i <= 5; i++){
//     int randomNumber = rand.Next(10,21);
//     Console.WriteLine(randomNumber);
//     sum = sum + randomNumber;
// }
// return sum;
// }
// Console.WriteLine("Sum: " + sum);

//? Create a loop that prints all the values from 1 - 100 that are divisible by 3 or 5 but not both 
// for (int i = 1; i <= 100; i++) {
//     if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 ==0)) {
//         Console.WriteLine(i);
//     } 
// }

//? Create a loop that prints all the values from 1 - 100 that are divisible by 3 or 5 but not both, then print Fizz for multiples of 3 and Buzz for multiples of 5
// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0 && i % 5 !=0) {
//         Console.WriteLine("Fizz");
//     } else if ( i % 5 == 0 && i % 3 != 0) {
//         Console.WriteLine("Buzz");
//     } else if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0)) {
//         Console.WriteLine(i);
//     }
// }


//? Adding "Fizz Buzz" to the above solutions
for (int i = 1; i <= 100; i++) {
    if (i % 3 == 0 && i % 5 ==0) {
        Console.WriteLine($"{i} - FizzBuzz");
    } else if ( i % 3 == 0) {
        Console.WriteLine($"{i} - Fizz");
    } else if (i % 5 == 0) {
        Console.WriteLine($"{i} - Buzz");
    } else {
        Console.WriteLine(i);
    }
}





