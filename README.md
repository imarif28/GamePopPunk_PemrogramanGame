# Indonesia's Pop Punk Bands
## Project Description
This project presents an interactive Unity-based game showcasing Indonesian pop punk bands. The application was developed as part of the Game Programming course, featuring five Indonesian bands displayed sequentially with their logos, descriptions, and music tracks. Players can explore band information and listen to their songs through an intuitive interface.

## Features
- Interactive band showcase with navigation controls
- Audio playback system for band music tracks
- Multi-scene architecture (Home, Play, Member, Exit)
- Keyboard navigation using arrow keys
- Band information display with custom graphics
- Member credits section
- Clean UI design with custom assets

## Technologies Used
- **Game Engine:** Unity
- **Programming Language:** C#
- **Audio Management:** Unity Audio Source
- **UI Framework:** Unity Canvas System
- **Asset Creation:** Canva, CorelDRAW
- **Audio Editing:** Audio editing software for track preparation

## How the Program Works
### Scene Management
1. **Home Scene:**
   - Main menu with navigation buttons
   - Background and UI elements setup
   - Button interactions for scene transitions

2. **Play Scene:**
   - Primary gameplay area featuring band showcase
   - Parent-child hierarchy for band assets
   - Audio system integration for music playback
   - Arrow key navigation between bands

3. **Member Scene:**
   - Credits display for development team
   - Similar navigation system without audio
   - Team member information presentation

4. **Exit Scene:**
   - Application termination interface
   - Keyboard input handling for exit confirmation

### Core Scripts
1. **Move Script (`move.cs`):**
   - Handles scene transitions
   - Button click events management
   - Scene loading functionality

2. **Image Move Script (`image_move.cs`):**
   - Controls band navigation logic
   - Audio playback management
   - Position interpolation for smooth transitions
   - Keyboard input processing

3. **Move Member Script (`move_member.cs`):**
   - Member section navigation
   - Position-based movement system
   - Simplified navigation without audio

4. **Screen Management Script (`Screen_Management.cs`):**
   - Global input handling
   - Scene transition controls
   - Application quit functionality

## Program Flow
1. **Asset Integration:**
   - Band logos with transparent backgrounds
   - Audio tracks edited to showcase highlights
   - Custom UI elements and backgrounds
   - Team member graphics

2. **Navigation System:**
   - Right arrow: Move to next band/member
   - Left arrow: Move to previous band/member
   - Enter key: Confirm selection
   - Escape key: Return to previous scene or quit

3. **Audio Management:**
   - Automatic music playback on band selection
   - Audio source control for seamless transitions
   - Track stopping and starting based on navigation

## Installation and Usage
1. **Setup:**
   - Open the project in Unity Editor
   - Ensure all assets are properly imported
   - Configure build settings with correct scene order

2. **Build Configuration:**
   - Scene 0: Home
   - Scene 1: Member
   - Scene 2: Play
   - Scene 3: Exit

3. **Usage Instructions:**
   - Launch the application from Home scene
   - Use navigation buttons or keyboard controls
   - Explore band information and listen to music tracks
   - Access team credits through Member section

## Asset Requirements
- Band logos (PNG format with transparency)
- Audio tracks (edited to appropriate length)
- Background images
- UI button graphics
- Team member information graphics

## Development Team
- **Akasha Bin Ali** - 4.33.22.0.01
- **Aufa Bima Ngahada** - 4.33.22.0.03
- **Bayu Tri Prayitno** - 4.33.22.0.04
- **Ilham Muhammad Arif** - 4.33.22.0.10
- **Maulana Bintang C.M** - 4.33.22.0.15

**Course:** Game Programming  
**Department:** Electrical Engineering  
**Institution:** Politeknik Negeri Semarang  
**Year:** 2024
