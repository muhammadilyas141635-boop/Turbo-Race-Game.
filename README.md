# Turbo-Race-Game.
A C# Windows Forms Turbo Race Game featuring four different vehicles, speed controls, special powers, braking, and a 100 km racing challenge. Developed using Object-Oriented Programming concepts.
# 🏎️ Turbo Race Game

## 📌 Project Overview

Turbo Race Game is a desktop-based racing game developed using C# and Windows Forms in Visual Studio 2022.

The game allows players to select different types of vehicles, control their speed, activate special powers, apply brakes, and complete a racing challenge of 100 kilometers.

Each vehicle has its own characteristics, acceleration speed, maximum speed, and special power, making the racing experience different for every vehicle.

This project demonstrates the practical implementation of Object-Oriented Programming (OOP) concepts in C#.

## 🎮 Game Features

- **Player Name:** Enter your name before starting the race.
- **Vehicle Selection:** Choose from four different vehicles.
- **Start Race:** Start the racing challenge with your selected vehicle.
- **Acceleration:** Increase the vehicle's speed.
- **Special Power:** Activate a unique power for each vehicle.
- **Braking System:** Reduce the current vehicle speed.
- **Speed Monitoring:** Display initial, current, and maximum speed.
- **Distance Tracking:** Monitor racing progress up to 100 km.
- **Progress Bar:** Visually display the distance covered.
- **Racing Track:** Show the vehicle moving along the racing track.
- **Activity Log:** Display racing activities and player actions.
- **Reset Option:** Reset the game and start a new race.
- **Winning Message:** Display a congratulatory message when the player completes the race.

## 🚗 Available Vehicles

The game provides four different vehicle options:

### 1. Sports Car
- Initial Speed: 40 km/h
- Maximum Speed: 180 km/h
- Acceleration: 10 km/h
- Special Power: Nitro Boost (+30 km/h)

### 2. Motorbike
- Initial Speed: 35 km/h
- Maximum Speed: 140 km/h
- Acceleration: 8 km/h
- Special Power: Wheelie Boost (+20 km/h)

### 3. Monster Truck
- Initial Speed: 25 km/h
- Maximum Speed: 100 km/h
- Acceleration: 5 km/h
- Special Power: Crush Power (+15 km/h)

### 4. Electric Car
- Initial Speed: 30 km/h
- Maximum Speed: 160 km/h
- Acceleration: 7 km/h
- Special Power: Battery Boost (+25 km/h)

## 🛠️ Technologies Used

- **Programming Language:** C#
- **Framework:** Windows Forms (.NET Framework)
- **IDE:** Microsoft Visual Studio 2022
- **Application Type:** Desktop Application

## 🧠 Object-Oriented Programming Concepts

This project demonstrates several important OOP concepts:

### 1. Abstraction
An abstract Vehicle class defines common properties and methods for all vehicles while leaving specific driving and power behavior to derived classes.

### 2. Inheritance
SportsCar, Motorbike, MonsterTruck, and ElectricCar inherit common properties and methods from the Vehicle class.

### 3. Runtime Polymorphism
A common Vehicle reference is used to store different vehicle objects. The appropriate overridden methods are executed at runtime.

### 4. Method Overriding
Each vehicle provides its own implementation of the Drive() and UsePower() methods.

### 5. Encapsulation
Properties use protected setters to control how vehicle information is modified within the class hierarchy.

## 📂 Project Structure

```text
Turbo-Race-Game/
│
├── Form1.cs
│
├── Vehicles.cs
│
├── Vehicle.cs
│
├── Form1.Designer.cs
│
├── Program.cs
│
└── README.md
```

*Note: Additional files and folders may be generated automatically by Visual Studio.*

## ▶️ How to Run the Project

1. Download or clone this repository.
2. Open the project folder in Visual Studio 2022.
3. Open the solution file (.sln).
4. Build the project.
5. Run the application by pressing the Start button.
6. Enter your player name.
7. Select your desired vehicle.
8. Click Start Race.
9. Use Accelerate, Special Power, and Brake buttons to control your vehicle.
10. Complete the 100 km racing challenge.

## 🎯 Project Objective

The main objective of this project is to develop an interactive racing game while gaining practical experience with C# programming, Windows Forms, event handling, inheritance, abstraction, and runtime polymorphism.

## 👨‍💻 Developer

**Developed by: Muhammad Ilyas**

Software Engineering Student

This project was developed as part of my programming and Object-Oriented Programming learning journey.

## ⭐ Acknowledgement

This project helped me strengthen my understanding of C# programming and practical OOP implementation through a simple and interactive racing game.
