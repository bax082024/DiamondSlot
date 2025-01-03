# Slot Machine Game

A nice looking feature rich slot machine game, made by Bax in C# using windows forms.
This project features exciting gameplay with dynamic paylines, adjustable bets and custom symbols.

---

## Features

- 5x3 Reel Grid: The slot machine uses 15 reels arranged in a 5x3 layout.
- **Dynamic Paylines:** Up to 5 paylines can be activated, with the cost per spin adjusted accordingly.
- **Adjustable Bet:** Players can choose a bet value from 1 to a maximum of 3, allowing for strategic gameplay.
- **Weighted Symbols:** The appearance of symbols is controlled by weighted probabilities, ensuring balanced and enjoyable gameplay.
- **Special Symbol:** The 2.png (triple gems) symbol acts as a special symbol with unique payout rules.
	- Lands on Reel 1: Returns the bet.
	- Lands on Reels 1 & 2: Returns bet + 2.
	- Lands on Reels 1, 2, & 3: Additional payouts.

---

## Customizations

- Configurable Win Rates: Easily tweak the win rate by adjusting symbol weights.
- Custom **Backgrounds and Icons:** Background textures and icon images can be replaced with custom designs.

---

## Sound Effects

- Includes dynamic sound effects for spins adding to the excitement.

---

## Statistics

- Displays current credits, active paylines, bets, and last spin winnings directly in the UI.

---


## How to Play

1. **Adjust the bet:**
	-  Use the "+" and "-" buttons to set your desired bet amount (1 to 3 credits per payline).
2. **Select Active Paylines:**
	- Increase or decrease the number of active paylines (1 to 5) using the designated buttons.
3. **spin The Reels:**
	- Hit the "Spin" button to start the game. 
4. **Winnings:**
	- Are based on matching symbols across active paylines. Check the Paytable for detailed rules.
---

## ScreenShot

- ![game](/Images/thegame.png)

---

## Setup Instructions

**Prerequisites
- **Development Environment:**
	- Visual Studio or compatible C# IDE
- **Dependencies:**
	- Windows Forms Framework
	- `WMPLib` for sound effects. (right click project - Add Project Reference - Windows media player).

## Steps

1. Clone Repository : https://github.com/bax082024/DiamondSlot.git
2. **cd DiamondSlot**
3. Ensure all images for the symbols are in the same directory as the executable:
	- File format: `1.png`, `2.png`, etc
4. Run Project.

## Contact 

- For quesions or feedback please contact:
- bax082024@gmail.com


