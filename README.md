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

