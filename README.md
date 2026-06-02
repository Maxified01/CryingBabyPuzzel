Crying Baby puzzle

Game Concept Summary

Crying Baby Puzzle is a third-person puzzle game where the player controls an AI Care Robot inside a baby room. The Player robot's objective is to determine why the baby is crying by investigating clues hidden within the environment.

The player must interact with four different toys and use trial-and-error to test possible solutions. Each toy reveals a clue letter when the baby rejects it. After collecting all clues, the player discovers the word FOOD, indicating that the baby might be hungry. The robot must then find a milk bottle and deliver it to the baby to solve the puzzle.

The game includes a win condition, a lose condition, puzzle progress tracking, sound effects, and interactive objects.

Puzzle Tasks
Task 1 – Investigate the First Toy
Pick up the first toy.
Give it to the baby.
Baby rejects the toy.
First clue letter appears: F.
Task 2 – Investigate the Second Toy
Pick up the second toy.
Give it to the baby.
Baby rejects the toy.
Second clue letter appears: O.
Task 3 – Investigate the Third Toy
Pick up the third toy.
Give it to the baby.
Baby rejects the toy.
Third clue letter appears: O.
Task 4 – Investigate the Fourth Toy
Pick up the fourth toy.
Give it to the baby.
Baby rejects the toy.
Fourth clue letter appears: D.
Task 5 – Feed the Baby
The completed clue forms the word FOOD.
The objective updates to indicate that the baby is hungry.
Find the milk bottle.
Deliver the milk to the baby.
Baby stops crying and starts laughing.
Win message appears.
Clue System

The game uses a non-direct clue system.

Each rejected toy reveals one letter:

Toy	Clue
Car	F
Teddy Bear	O
Train	O
Purple Bear	D

After all clues are collected:

FOOD

This helps the player deduce that the baby is hungry and needs milk.

Win Condition

The player wins when:

All clues are discovered.
The milk bottle is collected.
The milk is delivered to the baby.

Win Feedback:

Baby crying sound stops.
Baby laughing sound plays.
Win message appears on screen.
Player can leave the room.

Lose Condition

The game includes a timer-based lose condition.

The player has 5 minutes to solve the puzzle.
If the baby is not fed before the timer expires:
A "Game Over" message appears.
The player loses.
Controls
Control	Action
W	Move Forward
S	Move Backward
A	Move Left
D	Move Right
Mouse	Rotate Camera
Move Into Object	Interact / Pick Up Objects
Progress Tracking

The game tracks clue progress using the UI.

Examples:

Clues Found: 1/4
Clues Found: 2/4
Clues Found: 3/4
Clues Found: 4/4

Puzzle progress updates dynamically as clues are discovered.

Scripts Created
RobotController.cs

Controls player movement and camera rotation.

ToyClue.cs

Handles toy collection and clue discovery.

ClueManager.cs

Tracks clue progress and updates UI.

ToyInventory.cs

Stores the currently held toy.

BabyRejectToy.cs

Handles toy rejection and clue revealing.

PickupMilk.cs

Handles milk bottle collection.

FeedBaby.cs

Handles feeding the baby and triggering the win condition.

GameManager.cs

Controls win state, lose state, timer, and UI management.

AudioManager.cs

Manages crying, laughing, and pickup sound effects.

Assets Used
Unity Asset Store

https://assetstore.unity.com

Sketchfab

https://sketchfab.com

Poly Haven

https://polyhaven.com

Freesound (Audio)

https://freesound.org

Project Structure

Assets/

Scripts/
Models/
Audio/
Materials/
Prefabs/
UI/
Scenes/

This structure was used to keep the project organized and maintainable.

Educational Objectives Demonstrated

This project demonstrates:

Unity Scene Management
Third-Person Character Control
Trigger Collisions
Event-Based Gameplay
Puzzle Design
Trial-and-Error Mechanics
UI Systems
Audio Systems
C# Scripting
Game State Management
Win/Lose Conditions

Developer

Student Name: Anthony Emoh

Course: Intro to Unity

Assignment: Interactive Environment Challenge – Puzzle Room Project

Project Title: Crying Baby Puzzle
