# Lab 2: Bicycle Renting and Mushroom (Desktop Application)

A C# (.NET) Windows Forms application. It converts the Lab 1 console programs (Bicycle Renting and Mushroom identification) into a desktop application with several forms.

**Author:** Norbert NDIKUMANA (26668)

## Flow of the application

```
Login --> Choose --> Bicycle  --> Back to Choose / Logout to Login
                 --> Mushroom --> Back to Choose / Logout to Login
```

## Forms

| Form | Description |
|---|---|
| **Login** | The user enters a username and a password. Neither can be empty (this is the only validation). After a successful login the Choose form opens. |
| **Choose** | Two buttons: **Bicycle** and **Mushroom**, plus **Logout**. |
| **Bicycle** | Bicycle rental calculator with a **Total** textbox, a **Back** button and a **Logout** button. |
| **Mushroom** | Asks yes/no questions (at most three) and shows which mushroom it is. Has **Restart**, **Back** and **Logout** buttons. |

Messages (login success or failure, input errors, results) are shown with `MessageBox`.

## Problem 1: Bicycle Renting

The user enters a start hour and an end hour (whole numbers only).

**Input rules**
- Start time is between 0 and 23.
- End time is between 1 and 24.
- Start time must be less than end time.
- Decimal numbers are not accepted.

**Rate per hour**

| Hours | Rate |
|---|---|
| 0 - 7 and 21 - 24 | 500 RWF per hour |
| 7 - 14 and 19 - 21 | 1000 RWF per hour |
| 14 - 19 | 1500 RWF per hour |

The program loops over each rented hour, adds that hour's rate, and shows the total.

Examples: 8 to 10 gives 2000 RWF. 6 to 9 gives 2500 RWF.

## Problem 2: Mushroom

The user thinks of one of six mushrooms and answers yes/no questions. The program finds the mushroom in at most three questions.

Mushrooms: Agaric Jaunissant, Amanite tue-mouche, Cepe de Bordeaux, Coprin chevelu, Girolle, Pied bleu.

**Question order**
1. Does your mushroom have a ring?
   - **Yes:** Does it grow in a forest?
     - Yes: **Amanite tue-mouche**
     - No: Does it have a convex cup? Yes: **Agaric Jaunissant**, No: **Coprin chevelu**
   - **No:** Does it have gills?
     - No: **Cepe de Bordeaux**
     - Yes: Does it have a convex cup? Yes: **Pied bleu**, No: **Girolle**

## Concepts used

- Windows Forms (desktop application)
- Moving between forms (interface changing) with `Show()`, `Hide()` and `Close()`
- Decision control statements (`if`, `switch`)
- Repetition statements (`for` loop)
- Input validation with `int.TryParse`
- `MessageBox`, `TextBox`, `Label` and `Button` controls

## Project structure

```
LoginForm.cs      Login screen
ChooseForm.cs     Choose screen (Bicycle or Mushroom)
BicycleForm.cs    Bicycle renting
Mushroom.cs       Mushroom identification
Program.cs        Application entry point
```

Each form also has a `.Designer.cs` file that holds the controls added by drag and drop.

## How to run

1. Install [Visual Studio](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload.
2. Clone the repository:
   ```
   git clone https://github.com/Norbertndikumanana/Lab2_26668-.git
   ```
3. Open the `.sln` file in Visual Studio.
4. Press **F5** to build and run.
