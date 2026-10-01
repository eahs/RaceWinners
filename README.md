# RaceWinners

Several classes ran in the same race. For each class we know the overall finishing
place of every runner in that class. Your job is to decide which class did the best.

## The assignment

Write a program to rank each of the classes from first to last place. When you have
finished, be prepared to present your algorithm to the class and describe why you
think your approach is fair.

## How the project is organized

| File | What it is | What it does |
| --- | --- | --- |
| `Models/Group.cs` | A **model** | Holds the data for one class: its name and its runners' places. |
| `DataService.cs` | A **service** | Supplies the race data. `Program` depends on it. |
| `Program.cs` | The **entry point** | Gets the data from the service and prints it. Your ranking code starts here. |

## Running it

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet run --project RaceWinners/RaceWinners
```
