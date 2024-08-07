# Number to Words Converter

This C# project converts numbers to their English word representations. The program can handle both short and long scale number systems.

> [!IMPORTANT]
> This mini-project is my solution to LeetCode 273. Integer to English Words


## Features

- Converts any given long number to its English words equivalent.
- Supports both short scale and long scale naming conventions.
- Handles numbers up to the sextillion/sextilliard range.

## Complexity Analysis
# Time Complexity

The time complexity of the NumberToWords method is ***O(n)***, where n is the number of digits in the input number. This is because the method processes each digit exactly once.
# Memory Complexity

The memory complexity is ***O(n)***, where n is the number of digits in the input number. This is primarily due to the use of the Stack to store the words corresponding to each group of digits.

## Usage

### Running the Program

1. **Clone the repository:**
```sh
git clone https://github.com/yourusername/number-to-words.git
```
2. **Navigate to the project directory:**
```sh
cd number-to-words
```
3. **Compile and run the program:**
```sh
dotnet run
```
