
# 🕊️ Flippy Bird

**Flippy Bird** is a simple 2D desktop game inspired by the classic *Flappy Bird*, built using **C# and Windows Forms**.
Your goal is to guide the bird through gaps between pipes without hitting them or the ground.
Each pipe you pass increases your score — and the game speed too!

---

## 🎮 Gameplay Overview

- Press **Spacebar** to make the bird jump.
- Avoid colliding with pipes or the ground.
- The game speed increases as your score grows.
- When you crash, the **Game Over** screen appears with options to restart or exit.

---

## ⚙️ Features

✅ Smooth gravity and jump mechanics  
✅ Increasing difficulty as score rises  
✅ Real-time score tracking  
✅ Restart and Exit buttons  
✅ Simple, clean, and beginner-friendly code  

---

## 🧠 How It Works

- **Gravity** constantly pulls the bird down.
- Pressing **Spacebar** applies an upward force (negative gravity).
- **Pipes** move continuously from right to left.
- When a pipe goes off-screen, it repositions to the right and increases your score.
- **Collision detection** ends the game if the bird hits an obstacle or ground.

---

## 🚀 Getting Started

### 🧩 Prerequisites
- Windows OS
- Visual Studio (any version that supports WinForms)
- .NET Framework 4.7.2 or higher


## 🖼️ Screenshots

> Place your screenshots inside a `screenshots/` folder.

 Gameplay | Game Over |
-----------|------------|
|![Game Over]() | ![Game Over]() |

---

## 🧩 Code Highlights

- `gameTimerEvent()` → handles movement, gravity, scoring, and collisions
- `gameKeysDown()` / `gameKeyUp()` → control the bird’s flight
- `endGame()` → stops the game and shows restart/exit options
- `RestartButton_Click()` → resets the game state and restarts gameplay

---

## 🏁 Future Improvements

- 🎵 Add background music and sound effects
- 🏆 Add a high-score system
---

## 👨‍💻 Author

**Marouan El Yassini**  
Made with ❤️ in C# and WinForms

