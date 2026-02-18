<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-purple?style=for-the-badge&logo=dotnet" alt=".NET 8" />
  <img src="https://img.shields.io/badge/C%23-12-blue?style=for-the-badge&logo=csharp" alt="C# 12" />
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows" alt="Windows" />
  <img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" alt="MIT License" />
</p>

<h1 align="center">🌙 Ramadan Mubarak - Console Celebration App 🌙</h1>

<p align="center">
  <b>A full immersive Ramadan celebration experience inside your terminal!</b><br/>
  Built with ❤️ using C# and .NET 8
</p>

<p align="center">
  <i>Created by <b>Ahmed Mohamed Gaber</b></i>
</p>

---

## ✨ Overview

**Ramadan Mubarak** is a visually stunning console application that brings the spirit of Ramadan to your terminal. Featuring animated ASCII art lanterns that glow on and off, a moving crescent moon, twinkling stars, and a rich interactive menu — all crafted purely with `System.Console` APIs, no external UI libraries needed.

---

## 🎯 Features

| # | Feature | Description |
|---|---------|-------------|
| 🌙 | **Ramadan Greeting** | Beautiful random Ramadan greeting messages in Arabic with animated lantern |
| 📖 | **Islamic Motivation** | Random Quranic verses and motivational Islamic quotes |
| ⏰ | **Iftar Countdown** | Animated countdown timer with progress bar and celebration effects |
| 📿 | **Electronic Tasbeeh** | Digital tasbeeh counter with 7 dhikr options, visual progress, and round tracking |
| 🕌 | **Prayer Times** | Approximate prayer times display with mosque ASCII art and status indicators |
| 🏮 | **Big Lantern Show** | Large ASCII lantern with realistic glow-on/glow-off animation and light halos |
| 🎆 | **Full Celebration Show** | Combined animation: stars → moon → lanterns → mosque → fireworks |

---

## 🏮 Visual Highlights

- **Animated Lanterns** — Three lanterns that independently glow on and off with light halos
- **Moving Crescent Moon** — Moon traverses the sky through all phases (🌑 → 🌒 → 🌓 → 🌔 → 🌕 → 🌙)
- **Twinkling Star Field** — Random colorful stars filling the night sky
- **Mosque Silhouette** — Beautiful ASCII art mosque with minarets
- **Fireworks Display** — Colorful particle bursts for celebrations
- **Color-Coded UI** — Gold, green, cyan, magenta, and white themed interface
- **Box-Drawn Menus** — Professional aligned menus using Unicode box-drawing characters

---

## 🖥️ Screenshots

### Main Menu
```
      )                    )                    )
     ╔╩╗                  ╔╩╗                  ╔╩╗
    ╔╝ ╚╗                ╔╝ ╚╗                ╔╝ ╚╗
    ║*☪*║                ║*☪*║                ║*☪*║
    ╠═══╣                ╠═══╣                ╠═══╣
    ║███║                ║███║                ║███║
    ╚═══╝                ╚═══╝                ╚═══╝
      █                    █                    █
    ·  ·  ·             ·  ·  ·             ·  ·  ·

╔════════════════════════════════════════════════════╗
║          🌙  Ramadan Celebration Menu  🌙          ║
╠════════════════════════════════════════════════════╣
║    [1]  🌙  Ramadan Greeting                       ║
║    [2]  📖  Islamic Motivational Quote              ║
║    [3]  ⏰  Iftar Countdown Timer                   ║
║    [4]  📿  Electronic Tasbeeh                      ║
║    [5]  🕌  Prayer Times Today                      ║
║    [6]  🏮  Big Lantern Show                        ║
║    [7]  🎆  Full Celebration Show                   ║
║    [0]  🚪  Exit                                    ║
╚════════════════════════════════════════════════════╝
```

### Big Lantern (Glowing)
```
            · · ·  · · ·
                  )
                 ╔╩╗
                ╔╝ ╚╗
               ╔╝   ╚╗
              ╔╝     ╚╗
              ║ * ☪ * ║
              ║ *   * ║
              ║ *   * ║
              ╠═══════╣
              ║███████║
              ║███████║
              ║███████║
              ╚╗     ╔╝
               ╚╗   ╔╝
                ╚═══╝
                 ███
                  █
          · · · · · · · · · ·
```

### Mosque Silhouette
```
                           ☪
                          ╱ ╲
                         ╱   ╲
              ┌─┐       │     │       ┌─┐
              │☪│       │  ☪  │       │☪│
              │ │  ┌────┤     ├────┐  │ │
              │ │  │    │     │    │  │ │
              │ │  │    │ ┌─┐ │    │  │ │
              └─┘  └────┴─┤ ├─┴────┘  └─┘
             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Windows OS (optimized for Windows Terminal)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/ramadan-mubarak.git
   cd ramadan-mubarak
   ```

2. **Build the project**
   ```bash
   dotnet build
   ```

3. **Run the app**
   ```bash
   dotnet run
   ```

### 💡 Best Experience Tips

For the best visual experience:

- Use **Windows Terminal** instead of the old `cmd.exe`
- Set your font to **Cascadia Code** or **Cascadia Mono**
- Use a **dark background** theme
- Maximize the terminal window for full effect

---

## 🛠️ Tech Stack

| Technology | Purpose |
|------------|---------|
| **C# 12** | Programming language |
| **.NET 8** | Runtime framework |
| **System.Console** | Terminal rendering & colors |
| **System.Globalization** | Arabic text handling (grapheme clusters) |
| **Unicode Box Drawing** | UI borders and frames |
| **ASCII Art** | Lanterns, mosque, decorative elements |

---

## 📁 Project Structure

```
ramadan-mubarak/
├── Program.cs              # Main application (all-in-one)
├── RamadanMubarak.csproj   # .NET project file
├── README.md               # This file
├── LICENSE                 # MIT License
└── bin/                    # Build output
```

---

## 🎨 Color Scheme

| Color | Usage |
|-------|-------|
| 🟡 **Yellow/Gold** | Lanterns, banners, borders, Ramadan greetings |
| 🟢 **Green** | Islamic quotes, prayer status, success messages |
| 🔵 **Cyan** | Countdown timer, decorative stars, input prompts |
| 🟣 **Magenta** | Tasbeeh counter, special messages |
| ⚪ **White** | Menu option numbers, general text |
| 🔴 **Red** | Exit option, countdown urgency |
| ⚫ **DarkGray** | Dim lanterns, footnotes, separators |

---

## 🤝 Contributing

Contributions are welcome! Feel free to:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Ideas for Contributions

- 🕰️ Real prayer time API integration (e.g., Aladhan API)
- 🌍 Multi-language support
- 📅 Hijri calendar integration
- 🎵 Sound effects (beep patterns)
- 📱 Cross-platform support (Linux/macOS)

---

## 📜 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

<p align="center">
  <b>Ahmed Mohamed Gaber</b><br/>
  .NET Developer<br/><br/>
  <i>🌙 Ramadan Kareem — May Allah accept from us and from you 🌙</i>
</p>

---

<p align="center">
  <b>⭐ If you like this project, give it a star! ⭐</b><br/><br/>
  <img src="https://img.shields.io/badge/Ramadan-Mubarak_2026-gold?style=for-the-badge" alt="Ramadan Mubarak 2026" />
</p>
