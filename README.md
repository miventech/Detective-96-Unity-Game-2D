<div align="center">

![Detective 96](https://img.shields.io/badge/Detective_96-Game_Jam_Project-FF6B6B?style=for-the-badge)
![Unity](https://img.shields.io/badge/Unity-2D_Game-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

</div>

# 🔍 Detective 96 - Unity 2D Game

<div align="center">

**A 2D detective mystery game developed for a Game Jam**

[Play Demo](#) • [Report Bug](https://github.com/miventech/Detective-96-Unity-Game-2D/issues) • [Request Feature](https://github.com/miventech/Detective-96-Unity-Game-2D/issues)

</div>

---

## 📖 About The Project

**Detective 96** is a 2D detective mystery game where players investigate crime scenes, collect evidence, interrogate suspects, and solve cases.  Developed during a Game Jam with a focus on atmospheric storytelling and investigation mechanics.

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
│   ├── InteractionPlayer.cs     # Interaction handler
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
│   └── EvidenciaHidden.cs        # Hidden evidence objects
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

> **Note:** Add screenshots of your game here when available

```
[Gameplay Screenshot 1]
[Evidence Collection Screenshot]
[Dialogue System Screenshot]
[Character Profile Screenshot]
```

---

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or newer
- Git

### Installation

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

## 🎯 Game Jam Context

This project was developed for a **Game Jam** with specific constraints: 

- ⏱️ **Time Limit:** [Add time limit]
- 🎨 **Theme:** Detective/Mystery Investigation
- 🎵 **Focus:** Narrative and Atmosphere

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
- **[Add other assets/fonts/sounds if applicable]**

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

- GitHub: [@miventech](https://github.com/miventech)
- LinkedIn: [Jose Jaspe](https://www.linkedin.com/in/jose-jaspe-miventech/)
- YouTube: [@MiVenTech](https://www.youtube.com/@MiVenTech)
- Itch.io: [miventech](https://miventech.itch.io/)
- TikTok: [@miventech](https://www.tiktok.com/@miventech)

---

## 🙏 Acknowledgments

- Game Jam organizers and participants
- FunkyCode for Smart Lighting 2D
- Unity community for tutorials and support
- Coffee ☕ for keeping me awake during the jam

---

<div align="center">

**⭐ If you liked this project, please give it a star! **

[![GitHub Stars](https://img.shields.io/github/stars/miventech/Detective-96-Unity-Game-2D?style=social)](https://github.com/miventech/Detective-96-Unity-Game-2D/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/miventech/Detective-96-Unity-Game-2D?style=social)](https://github.com/miventech/Detective-96-Unity-Game-2D/network/members)

</div>

---

## 🗺️ Roadmap

- [ ] Add more investigation scenes
- [ ] Implement inventory system
- [ ] Add multiple cases/levels
- [ ] Create evidence combination mechanics
- [ ] Add ending variations based on player choices
- [ ] Mobile port

---

## 📸 Development Process

<details>
<summary>Click to see behind-the-scenes content</summary>

### Day 1: Concept & Core Mechanics
- ✅ Player movement
- ✅ Basic interaction system

### Day 2: Systems Implementation
- ✅ Dialogue system
- ✅ Evidence detection
- ✅ Character profiles

### Day 3: Polish & Integration
- ✅ Lighting system
- ✅ Sound effects
- ✅ Scene transitions

</details>

---

<div align="center">

Made with ❤️ and ☕ by **Miventech**

![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-000000?style=flat&logo=unity&logoColor=white)
![Made with C#](https://img.shields.io/badge/Made%20with-C%23-239120?style=flat&logo=c-sharp&logoColor=white)

</div>
