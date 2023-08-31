# Minesweeper Game Unit Testing

This repository contains unit tests for the Minesweeper game located at [GitHub - Minesweeper](https://github.com/TiAutoBootcamp/Minesweeper). The tests focus on verifying the functionality of the `Open()` and `GetCurrentField()` methods of the `GameProcessor` class.

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Unit Testing](#unit-testing)
- [How to Run Tests](#how-to-run-tests)

## Introduction

The Minesweeper game is a console-based implementation that follows the rules of the classic Windows Minesweeper video game. The main class for this game is `GameProcessor` located in the `Core` project. This class provides methods for opening cells and retrieving the current game field.

## Prerequisites

To run the unit tests, you will need the following:

- Visual Studio or an IDE of your choice that supports NUnit testing.
- The Minesweeper game solution. You can find it at [GitHub - Minesweeper](https://github.com/TiAutoBootcamp/Minesweeper).

## Unit Testing

We will be writing positive unit tests using NUnit for the following methods of the `GameProcessor` class:

1. `Open()`: This method allows opening a new cell on the game field and returns the updated game state. It should be tested for different scenarios, including valid cell openings and handling attempts to open cells that are already open.

2. `GetCurrentField()`: This method retrieves the current game field with the current state for every cell. The test should ensure that the field is correctly returned and reflects the actual state of the game.

## How to Run Tests

1. Clone this repository to your local machine.

2. Open the solution in your preferred IDE (e.g., Visual Studio).

3. Build the solution.

4. Run the NUnit tests for the `GameProcessor` class, focusing on the `Open()` and `GetCurrentField()` methods.

5. Analyze the test results to ensure that all positive scenarios are covered and that the methods behave as expected.
