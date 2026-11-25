# Random Card Generator

A small C# console program that randomly selects one suit and one rank, then prints the card.

## Requirements

- .NET 10 SDK

Check that the SDK is installed by running:

```powershell
dotnet --version
```

## Project files

- `CardGenerator/Card.cs` defines a card and the `Card.RandomCard()` factory method.
- `CardGenerator/Program.cs` generates a card and prints it to the console.
- `CardGenerator/CardGenerator.csproj` contains the console app project settings.

## Build and run

Open a terminal in the folder containing `RandomCardGenerator.slnx`, then run:

```powershell
dotnet build .\RandomCardGenerator.slnx
dotnet run --project .\CardGenerator\CardGenerator.csproj
```

The program prints a result similar to:

```text
Random Card: 13 of Spades
```

The rank is currently displayed as a number from 1 to 13, and the suit is Hearts, Diamonds, Clubs, or Spades.

The program also prints a direct link to the generated card's PNG image. Open that link in a browser to view the card. An internet connection is required to load the image from the [Deck of Cards API](https://deckofcardsapi.com/).
