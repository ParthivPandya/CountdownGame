# Countdown Game Console Application

## Overview

This project is a C# console application that simulates a one-player version of the Countdown letters game. It allows users to choose consonants and vowels to form words and score points based on the longest valid word found. The game is played over four rounds, and the total score is accumulated across all rounds.

## Project Structure

- `CountdownGamePlay.cs`: Contains the main game logic for playing rounds and the overall game.
- `Dictionary.cs`: Handles word lookup to find the longest valid word from the given letters.
- `LetterBag.cs`: Provides methods to get random consonants and vowels.
- `Program.cs`: Entry point of the application to start the game.
- `tests/CountdownGamePlayTests.cs`: Contains unit tests for the game logic using xUnit.

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (recommended) or another IDE that supports C# development

## Setup

1. **Clone the Repository:**

    ```sh
    git clone https://github.com/your-username/countdown-game.git
    cd countdown-game
    ```

2. **Install Dependencies:**

    Ensure you have the .NET SDK installed. You do not need additional dependencies for the core project.

3. **Build the Project:**

    ```sh
    dotnet build
    ```

4. **Run the Console Application:**

    Navigate to the root directory of the project and execute:

    ```sh
    dotnet run --project CountdownGame
    ```

    Follow the on-screen prompts to play the game.

## Running Tests

1. **Navigate to the Test Project Directory:**

    ```sh
    cd tests
    ```

2. **Run the Tests:**

    ```sh
    dotnet test
    ```

    This will execute all unit tests in the `CountdownGameTests` project and display the results in the terminal.

## Usage

1. **Playing the Game:**

    - Start the console application using `dotnet run`.
    - For each round, choose 'C' for Consonant or 'V' for Vowel as prompted.
    - After 9 letters are chosen, the game will attempt to find the longest valid word from the letters.
    - The score for each round will be displayed, and the total score will be updated.

2. **Tests:**

    - The test project contains unit tests to verify the functionality of the `CountdownGamePlay` class.
    - The tests simulate user input and verify the correctness of the output.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes. Ensure that your code follows the existing style and includes appropriate tests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

