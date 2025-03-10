// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Numerics;
namespace Assignment{
    class Program
    {
        static void Main(string[] args)
        {

            //Assignment Question 1(1)

            //Console.Write("Enter a number between 1-10...");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number>= 1 && number<= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}



            //Assignment Question 1(2)

            //double num1 = 0;
            //double num2 = 0;

            //Console.Write("Enter number 1:  ");
            //num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter number 2:  ");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine("The maximum number is " + num1);
            //}
            //else if (num2 > num1)
            //{
            //    Console.WriteLine("The maximum number is " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}



            //Assignment Question 1(3)

            //Console.Write("Enter the width of the image...");
            //int width = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the height of the image...");
            //int height = Convert.ToInt32(Console.ReadLine());
            //if(width > height)
            //{
            //    Console.WriteLine("This image is in Landscape Mode");
            //}
            //else if (height > width)
            //{
            //    Console.WriteLine("The image is in portrait mode.");
            //}
            //else
            //{
            //    Console.WriteLine("This image is square");
            //}



            //Assignment Question 1(4)

            //Console.WriteLine(".........");
            //Console.WriteLine("Speed Camera");
            //Console.WriteLine(".........");

            //Console.Write("Enter the speed limit km/h...");
            //int speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the Car Speed km/h....");
            //int userLimit = Convert.ToInt32(Console.ReadLine());

            //int demeritPoint = (userLimit - speedLimit) / 5;
            //if(userLimit < speedLimit)
            //{
            //    Console.WriteLine("OK");
            //}
            //else {
            //    Console.WriteLine("Demerit points: " + demeritPoint);
            //}
            //if (demeritPoint > 12){
            //    Console.WriteLine("License Suspended");
            //}



            //Assignment Question 2(1)

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }

            //}



            //Assignment Question 2(2)

            //int sum = 0;
            //string input;

            //while (true)
            //{
            //    Console.Write("Enter a number or type 'ok' to exit: ");
            //    input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    int number = Convert.ToInt32(input);
            //    sum += number;
            //}

            //Console.WriteLine("Sum of entered numbers: " + sum);



            //Assignment Question 2(3)

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //BigInteger factorial = 1;

            //for (int i = number; i > 0; i--)
            //{
            //   factorial *= i;
            //}

            //Console.WriteLine($"{number}! = {factorial}");



            //Assignment Question 2(4)

            //Random random = new Random();
            //int secretNumber = random.Next(1, 11); // Generates a number between 1 and 10
            //int maxAttempts = 4;
            //int attempts = 0;
            //bool hasWon = false;

            //Console.WriteLine($"(Secret Number: {secretNumber})"); // Displays the secret number for testing

            //while (attempts < maxAttempts)
            //{
            //    Console.Write("Enter your guess (1-10): ");
            //    int userGuess = Convert.ToInt32(Console.ReadLine());

            //    if (userGuess == secretNumber)
            //    {
            //        Console.WriteLine("You won!");
            //        hasWon = true;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong guess. Try again.");
            //    }

            //    attempts++;
            //}

            //if (!hasWon)
            //{
            //    Console.WriteLine("You lost! The secret number was " + secretNumber);
            //}

            //Console.WriteLine("Game over. Thanks for playing!");



            //Assignment Question 2(5)

            //Console.Write("Enter numbers separated by commas: ");
            //string[] input = Console.ReadLine().Split(',');
            //int maxNumber = int.MinValue;

            //foreach (string num in input)
            //{
            //    int number = Convert.ToInt32(num);
            //    if (number > maxNumber)
            //        maxNumber = number;
            //}

            //Console.WriteLine("Maximum number: " + maxNumber);


            //Assignment Question 3(1)


            //List<string> likes = new List<string>();
            //Console.Write("Enter the names of people who liked your post (press 'Enter' to stop): ");
            //while (true)
            //{
            //    string name = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(name))
            //    {
            //        break;
            //    }
            //    likes.Add(name);
            //    int count = likes.Count;
            //    if(count == 0)
            //    {
            //        Console.WriteLine("No one liked your post");
            //    }
            //    else if (count == 1)
            //    {
            //        Console.WriteLine($"{likes[0]} liked your post");
            //    }
            //    else if (count == 2)
            //    {
            //        Console.WriteLine($"{likes[0]} and {likes[1]} liked your post");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{likes[0]},{likes[1]} and {count - 2}others liked your post");
            //    }
            //}



            //Assignment Question 3(2)

            //Console.Write("Please enter your name....");
            //string name = Console.ReadLine();

            //// Convert name to character array and reverse it
            //char[] array = name.ToCharArray();
            //Array.Reverse(array);

            //// Convert back to a string
            //string reversedName = new string(array);

            //Console.WriteLine("Reversed name: " + reversedName);



            //Assignment Question 3(3)

            //List<int> numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.Write("Enter a unique number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (numbers.Contains(number))
            //        Console.WriteLine("Error: Number already entered. Try again.");
            //    else
            //        numbers.Add(number);
            //}

            //numbers.Sort();
            //Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));



            //Assignment Question 3(4)

            //HashSet<int> uniqueNumbers = new HashSet<int>();
            //string input;

            //while (true)
            //{
            //    Console.Write("Enter a number or type 'Quit' to exit: ");
            //    input = Console.ReadLine().Trim();

            //    if (input.ToLower() == "quit")
            //    {
            //        break;
            //    }

            //    if (int.TryParse(input, out int number))
            //    {
            //        uniqueNumbers.Add(number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid number.");
            //    }
            //}

            //Console.WriteLine("Unique numbers entered:");
            //foreach (int number in uniqueNumbers)
            //{
            //    Console.WriteLine(number);
            //}


            //Assignment Question 3(5)

            //while (true)
            //{

            //    Console.Write("Enter a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");
            //    string input = Console.ReadLine();

            //    string[] inputArray = input.Split(',');

            //    inputArray = inputArray.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            //    if (inputArray.Length < 5)
            //    {
            //        Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
            //        continue;
            //    }

            //    int[] numbers = new int[inputArray.Length];
            //    bool validInput = true;

            //    for (int i = 0; i < inputArray.Length; i++)
            //    {
            //        if (!int.TryParse(inputArray[i].Trim(), out numbers[i]))
            //        {
            //            Console.WriteLine("Invalid List. Please make sure all entries are valid numbers.");
            //            validInput = false;
            //            break;
            //        }
            //    }

            //    if (!validInput)
            //    {
            //        continue;
            //    }

            //    Array.Sort(numbers);

            //    Console.WriteLine("The 3 smallest numbers are: ");
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //    break;
            //}



            //Assignment Question 4(1)

            //Console.Write("Enter a series of numbers separated by hyphens (e.g., 5-6-7-8-9): ");
            //string input = Console.ReadLine();

            //string[] inputArray = input.Split('-');

            //int[] numbers = inputArray.Select(x => int.Parse(x.Trim())).ToArray();

            //Array.Sort(numbers);

            //bool isConsecutive = true;
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}

            //if (isConsecutive)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Not Consecutive");
            //}



            //Assignment Question 4(2)


            //while (true)
            //{
            //    Console.Write("Enter a few numbers separated by hyphens (or press Enter to exit): ");
            //    string input = Console.ReadLine();

            //    // If the user presses Enter without input, exit the program
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("Exiting...");
            //        return;
            //    }

            //    string[] inputArray = input.Split('-');
            //    int[] numbers = new int[inputArray.Length];
            //    bool isValid = true;

            //    for (int i = 0; i < inputArray.Length; i++)
            //    {
            //        if (!int.TryParse(inputArray[i].Trim(), out numbers[i]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter only numbers separated by hyphens.");
            //            isValid = false;
            //            break;
            //        }
            //    }

            //    if (!isValid) continue; // Restart the loop if input is invalid

            //    // Checking for duplicates 
            //    if (numbers.GroupBy(n => n).Any(g => g.Count() > 1))
            //    {
            //        Console.WriteLine("Duplicate");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Duplicates");
            //    }
            //}



            //Assignment Question 4(3)


            //Console.Write("Enter a time value (HH:mm): ");

            //string input = Console.ReadLine();
            //TimeSpan timeValue = new TimeSpan(23, 59, 59); // Latest valid time before midnight

            //if (TimeSpan.TryParse(input, out TimeSpan userValue))
            //{
            //    if (userValue <= timeValue)
            //    {
            //        Console.WriteLine("OK");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Time");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Time Format");
            //}


            //Assignment Question 4(4)


            //Console.Write("Enter a few words separated by spaces: ");
            //string input = Console.ReadLine();

            //if (string.IsNullOrEmpty(input))
            //{
            //    Console.WriteLine("Invalid input");
            //    return;
            //}

            //string[] words = input.Split(' ');

            //string pascalCaseResult = string.Join("", words
            //    .Where(word => !string.IsNullOrWhiteSpace(word))
            //    .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));

            //Console.WriteLine(pascalCaseResult);



            //Assignment Question 4(5)

            //Console.Write("Enter an English word: ");
            //string word = Console.ReadLine().ToLower();

            //int vowelCount = 0;
            //foreach (char c in word)
            //{
            //    if ("aeiou".Contains(c))
            //    {
            //        vowelCount++;
            //    }
            //}

            //Console.WriteLine($"Number of vowels: {vowelCount}");


            //Assignment Question 5(1)

            //Console.Write("Enter the path of the text file: ");
            //string filePath = Console.ReadLine();

            //if (!File.Exists(filePath))
            //{
            //    Console.WriteLine("The file does not exist.");
            //    return;
            //}

            //try
            //{
            //    string fileContent = File.ReadAllText(filePath);

            //    string[] words = fileContent.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //    Console.WriteLine("Number of words: " + words.Length);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}



            //Assignment Question 5(2)


            Console.Write("Enter the path of the text file: ");
            string filePath = Console.ReadLine();

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file does not exist.");
                return;
            }

            try
            {
                // Read the content of the file
                string fileContent = File.ReadAllText(filePath);

                // Split the content into words based on spaces and punctuation
                string[] words = fileContent.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?', '-', '_', '(', ')', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                // Initialize a variable to track the longest word
                string longestWord = string.Empty;

                // Iterate over each word
                foreach (string word in words)
                {
                    // Check if the current word is longer than the longest word found so far
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                // Display the longest word found
                if (string.IsNullOrEmpty(longestWord))
                {
                    Console.WriteLine("No words found in the file.");
                }
                else
                {
                    Console.WriteLine("The longest word is: " + longestWord);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that may occur during file reading
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }
    }

}