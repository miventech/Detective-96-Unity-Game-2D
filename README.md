<div align="center">

![Detective 96](https://img.shields.io/badge/Detective_96-Game_Jam_Project-FF6B6B?style=for-the-badge)
![Unity](https://img.shields.io/badge/Unity-2D_Game-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

</div>

# 🔍 Detective 96 - Unity 2D Game
## 🏠 La Casa Glans

<div align="center">

**A 2D detective mystery game developed in 7 days for a Game Jam**

[![Play on Itch.io](https://img.shields.io/badge/🎮_PLAY_NOW-La_Casa_Glans-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white)](https://miventech.itch.io/la-casa-glans)

[📝 Report Bug](https://github.com/miventech/Detective-96-Unity-Game-2D/issues) • [✨ Request Feature](https://github.com/miventech/Detective-96-Unity-Game-2D/issues) • [🎮 More Games](https://miventech.itch.io/)

</div>

---

## 📖 About The Project

**Detective 96: La Casa Glans** is a 2D detective mystery game where players investigate crime scenes, collect evidence, interrogate suspects, and solve cases.  Developed during a **7-day Game Jam** with a focus on atmospheric storytelling and investigation mechanics.

> 🎯 **Play the full game here:** [https://miventech.itch.io/la-casa-glans](https://miventech.itch.io/la-casa-glans)

### 🎮 Gameplay Features

- 🔍 **Evidence Collection System** - Search crime scenes for clues using a detection radius
- 💬 **Interactive Dialogue System** - Question suspects and witnesses with typewriter-style text
- 📋 **Character Profile Database** - Track suspects with detailed profiles (name, age, profession, relationships)
- 🚪 **Scene Teleportation** - Move between different investigation areas
- 💡 **Dynamic 2D Lighting** - Atmospheric lighting system for immersive environments
- 🎵 **Sound Effects Manager** - Professional audio feedback for all interactions

---

## 🕹️ Controls

| Key | Action |
|-----|--------|
| **A/D** or **←/→** | Move Left/Right |
| **E** | Interact / Advance Dialogue |
| **Space** | Skip Dialogue Text |
| **Mouse Click** | Alternative Interact |

---

## 🎯 Game Jam Context

<div align="center">

| 📅 Duration | 🎨 Theme | 🎯 Focus |
|-------------|----------|----------|
| **7 Days** | Detective/Mystery Investigation | Narrative & Atmosphere |

</div>

This project was developed for a **Game Jam** with the following constraints:

- ⏱️ **Time Limit:** 7 days (168 hours)
- 🎨 **Theme:** Mystery & Investigation
- 🎯 **Goal:** Create an immersive detective experience
- 🏆 **Result:** Fully playable game with multiple systems

### 🎮 Play the Complete Game

<div align="center">

**👉 The full game "La Casa Glans" is available to play for FREE on Itch.io:**

[![Play Now Button](https://img.shields.io/badge/🎮_PLAY_LA_CASA_GLANS-Click_Here-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white&labelColor=222222)](https://miventech.itch.io/la-casa-glans)

[![Itch.io](https://img.shields.io/badge/Itch.io-FA5C5C?style=flat&logo=itch.io&logoColor=white)](https://miventech.itch.io/la-casa-glans)
[![WebGL](https://img.shields.io/badge/Platform-Browser_(WebGL)-4285F4?style=flat&logo=googlechrome&logoColor=white)](https://miventech.itch.io/la-casa-glans)
[![Free](https://img.shields.io/badge/Price-FREE-00C853?style=flat)](https://miventech.itch.io/la-casa-glans)

*No download required - Play directly in your browser! *

</div>

---

## 🛠️ Built With

### Core Technologies
- **Unity 2022+** - Game Engine
- **C#** - Programming Language
- **Smart Lighting 2D** (FunkyCode) - Lighting System
- **TextMesh Pro** - UI Text Rendering

### Custom Systems
```
📁 Assets/
├── 🎮 Detective/Scripts/          # Core gameplay scripts
│   ├── PlayerWalk.cs             # Player movement controller
│   ├── InteractionPlayer.cs      # Interaction handler
│   └── PlaySoundWalk.cs          # Footstep audio
│
├── 💬 Libs/DialogSystem/          # Dialogue management
│   ├── ManagerDialog.cs          # Dialogue controller
│   ├── Dialog.cs                 # Dialogue data structure
│   ├── InteractiveDialog.cs      # Trigger-based dialogues
│   └── TriggerDialog.cs          # Auto-play dialogues
│
├── 🔍 Libs/SistemaDeEvidencia/    # Evidence system
│   ├── Evidencia.cs              # Evidence data structure
│   ├── BuscadorEvidencia.cs      # Evidence detection
│   └── EvidenciaHidden. cs        # Hidden evidence objects
│
├── 👤 Libs/PerfilesDePersonas/    # Character profiling
│   ├── perfil.cs                 # Profile data structure
│   └── PerfilUI.cs               # Profile UI controller
│
├── 🎵 Libs/SFXManager/            # Audio management
│   └── SFXManager.cs             # Sound effects controller
│
└── 🚪 Libs/TeleportSystem/        # Scene transitions
    └── TeleportSystem.cs         # Teleportation handler
```

---

## ✨ Key Systems Breakdown

### 🔍 Evidence System
```csharp
// Players can search for hidden evidence within a detection radius
- Radius-based detection (adjustable)
- Limited usage system (5 searches by default)
- Visual feedback (lighting effect)
- Audio confirmation (success/error sounds)
```

### 💬 Dialogue System
```csharp
// Professional typewriter-style dialogue system
- Character avatars and names
- Animated text rendering
- Multiple dialogue branches
- Skip functionality
- Audio feedback per character
```

### 📋 Character Profiles
```csharp
// Detailed suspect/witness profiles
- Name, Surname, Age
- Profession & Relationship
- Physical Description
- Investigation Notes
- Profile Photo + Extras
```

---

## 🎨 Screenshots

> **Note:** Check out the game on Itch.io to see screenshots and gameplay videos!

**[View Screenshots on Itch.io →](https://miventech.itch.io/la-casa-glans)**

---

## 🚀 Getting Started

### For Players
**🎮 Just want to play? **  
👉 **[Click here to play La Casa Glans on Itch.io](https://miventech.itch.io/la-casa-glans)** - No installation needed!

### For Developers

#### Prerequisites
- Unity 2022.3 LTS or newer
- Git

#### Installation

1. Clone the repository
```bash
git clone https://github.com/miventech/Detective-96-Unity-Game-2D.git
```

2. Open the project in Unity Hub
```
Unity Hub → Add → Select the cloned folder
```

3. Open the main scene
```
Assets/Scenes/MainScene.unity
```

4. Press **Play** to start testing

---

## 🔧 Architecture Highlights

### **Modular Systems**
Each system is designed to be reusable and independent: 

- ✅ Plug-and-play dialogue system
- ✅ Configurable evidence detection
- ✅ ScriptableObject-based data structures
- ✅ Singleton managers for easy access
- ✅ Event-driven interaction system

### **Performance Optimizations**
- Object pooling for audio sources
- Efficient collision detection
- Optimized lighting passes
- Minimal garbage collection

---

## 📦 Asset Credits

- **Smart Lighting 2D** by FunkyCode
- **TextMesh Pro** by Unity Technologies
- Sound effects and music created/sourced during the jam

---

## 🤝 Contributing

Contributions are welcome! If you have suggestions or improvements:

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📜 License

Distributed under the **MIT License**. See `LICENSE` for more information.

---

## 👨‍💻 Author

**Miventech**

<div align="center">

[![GitHub](https://img.shields.io/badge/GitHub-@miventech-181717?style=for-the-badge&logo=github)](https://github.com/miventech)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Jose_Jaspe-0077B5?style=for-the-badge&logo=linkedin)](https://www.linkedin.com/in/jose-jaspe-miventech/)
[![YouTube](https://img.shields.io/badge/YouTube-@MiVenTech-FF0000?style=for-the-badge&logo=youtube)](https://www.youtube.com/@MiVenTech)
[![Itch.io](https://img.shields.io/badge/Itch. io-miventech-FA5C5C?style=for-the-badge&logo=itch.io)](https://miventech.itch.io/)
[![TikTok](https://img.shields.io/badge/TikTok-@miventech-000000?style=for-the-badge&logo=tiktok)](https://www.tiktok.com/@miventech)

</div>

---

## 🙏 Acknowledgments

- Game Jam organizers and participants
- FunkyCode for Smart Lighting 2D
- Unity community for tutorials and support
- All playtesters and feedback providers
- Coffee ☕ for keeping me awake during the 7-day sprint

---

<div align="center">

**⭐ If you liked this project, please give it a star! **

[![GitHub Stars](https://img.shields.io/github/stars/miventech/Detective-96-Unity-Game-2D? style=social)](https://github.com/miventech/Detective-96-Unity-Game-2D/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/miventech/Detective-96-Unity-Game-2D?style=social)](https://github.com/miventech/Detective-96-Unity-Game-2D/network/members)

**🎮 Don't forget to try the game!**

[![Play Now](https://img.shields.io/badge/🎮_PLAY_NOW-La_Casa_Glans-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white)](https://miventech.itch.io/la-casa-glans)

</div>

---

## 🗺️ Roadmap

- [x] Core detective mechanics (Completed in 7 days!)
- [x] Dialogue system
- [x] Evidence collection
- [x] Character profiles
- [ ] Add more investigation scenes
- [ ] Implement inventory system
- [ ] Add multiple cases/levels
- [ ] Create evidence combination mechanics
- [ ] Add ending variations based on player choices
- [ ] Mobile port

---

## 📸 Development Timeline (7 Days)

<details>
<summary>Click to see the development breakdown</summary>

### 📅 Day 1-2: Foundation
- ✅ Player movement and controls
- ✅ Basic interaction system
- ✅ Scene structure

### 📅 Day 3-4: Core Systems
- ✅ Dialogue system implementation
- ✅ Evidence detection mechanics
- ✅ Character profile system
- ✅ Teleportation system

### 📅 Day 5-6: Content & Polish
- ✅ 2D lighting integration
- ✅ Sound effects implementation
- ✅ Scene transitions
- ✅ UI polish

### 📅 Day 7: Final Push
- ✅ Bug fixes
- ✅ Playtesting
- ✅ Build and upload to Itch.io
- ✅ Documentation

</details>

---

## 🎬 Videos & Media

<div align="center">

### 📺 Watch Gameplay & Development

[![YouTube](https://img.shields.io/badge/Watch_on-YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/@MiVenTech)
[![TikTok](https://img.shields.io/badge/Short_Clips-TikTok-000000?style=for-the-badge&logo=tiktok&logoColor=white)](https://www.tiktok.com/@miventech)

*Follow for devlogs, tutorials, and behind-the-scenes content!*

</div>

---

## 💬 Community & Support

Have questions or want to discuss the game? 

- 🐛 **Found a bug?** [Open an issue](https://github.com/miventech/Detective-96-Unity-Game-2D/issues)
- 💡 **Have a suggestion?** [Start a discussion](https://github.com/miventech/Detective-96-Unity-Game-2D/discussions)
- 🎮 **Leave feedback on the game:** [Itch.io comments](https://miventech.itch.io/la-casa-glans)

---

<div align="center">

Made with ❤️ and ☕ in **7 days** by **Miventech**

![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-000000? style=flat&logo=unity&logoColor=white)
![Made with C#](https://img.shields.io/badge/Made%20with-C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![Game Jam](https://img.shields.io/badge/Game%20Jam-7%20Days-FF6B6B?style=flat)

### 🎮 Play La Casa Glans Now!

[![Play Button](https://img.shields.io/badge/▶️_CLICK_TO_PLAY-miventech. itch.io/la--casa--glans-FA5C5C?style=for-the-badge&logo=itch.io&logoColor=white)](https://miventech.itch.io/la-casa-glans)

</div>
