# Architect of Goo: Technical Requirements

`v1.0`

## User Personas

### User: Student

#### Description

The student is the main end user of our product, they are between 12 to 16 years old, have a varying level of VWO math knowledge and will be mostly using our app through the web.

#### Goals

1. The student wants to practice his math skills in a fun & interactive manner
2. The student wants to know where his math skill is currently at & the system to respond according to their understanding

---

### User: Level Designer

#### Description

The level designer is the person who will be creating the levels for the students to play. They will be using the unity editor to create the levels and will be able to test them in the same environment.

#### Goals

1. The level designer wants to create levels that are challenging for the students based on their current understanding of math
2. The level designer wants to create levels that are fun for the students to play, by being able to test them in & outside the editor

---

### User: Game Designer

#### Description

The game designer will be using the unity editor to combine scripts and change variables to create new game features. They should be able to test these features in the same environment.

#### Goals

1. The game designer wants to be able to create new features without having to change the existing code
2. The game designer wants to be able to test these features in the editor
3. The game designer wants to be able to tweak all variables of existing features

## Features

### Feature: Calculation Zone

#### Description

The calculation zone is an area which triggers the math application UI to appear.

- The student will use the calculation zones to start solving environmental puzzles
- The level designer will be able to place these zones strategically in the levels

#### Functional Requirements

- It should be able to fire a `GameEvent` when the player enters the zone
- It should be able to fire a `GameEvent` when the player leaves the zone
- It should be able to set references for the two related connection points

#### Acceptance Criteria

- There should be a calculation zone prefab

#### Dependencies

- Player
- Connection Point

---

### Feature: Gems

#### Description

Gems are collectible items that the player can collect throughout the level to acces specific abilities.

- The student will collect the gems throughout the level
- The student will use the gems to access specific abilities
- The level designer will be able to place these gems strategically in the levels
- The game designer will be able to create new types of gems

#### Functional Requirements

- It should be able to be disappear when the player collects it
- It should be able to fire a `GemUnityEvent` when the player collects it
- It should be able to be stored in the gem inventory system

#### Acceptance Criteria

- It should use `ScriptableObject` for creating types of gems
- There should be a gem prefab
- There should be an acid gem SO
- There should be a goo gem SO
- There should be a sticky gem SO
- There should be a vlimes gem SO
- There should be a sliamond in the rough SO

#### Dependencies

- Gem Inventory System

---

### Feature: Acid Ability

#### Description

The acid ability allows the player to burn destroyable obstacles in the level.

- The student will use the acid ability to destroy obstacles by applying the slope of a linear function

#### Functional Requirements

- It should be able to accept a function slope and translate it into a rotation
- It should be able to destroy destroyable obstacles
- It should be able to be used by the player only when they have the acid gem

#### Acceptance Criteria

- It should use the existing projectile system

#### Dependencies

- Player
- Math Application UI
- Gems
- Destroyable Obstacles
- Gem Inventory System

---

### Feature: Goo Ability

#### Description

The goo ability allows the player to create bridges between two connection points.

- The student will use the goo ability to create bridges between two connection points

#### Functional Requirements

- It should be able to create a traversable bridge
- It should be able to be used by the player only when they have the goo gem

#### Acceptance Criteria

- It should use the connection points defined in the calculation zone

#### Dependencies

- Player
- Math Application UI
- Calculation Zone
- Gem Inventory System

---

### Feature: Sticky Ability

#### Description

The sticky ability allows the player two swing itself over a certain distance.

- The student will use the sticky ability to swing themselves from one point to another

#### Functional Requirements

- It should be able to swing/move the player from one point to another
- It should be able to allow for setting the distance the player can swing
- It should be able to be used by the player only when they have the sticky gem

#### Acceptance Criteria

- It should use the end connection point as the anchor point

#### Dependencies

- Player
- Math Application UI
- Calculation Zone
- Gem Inventory System

---

### Feature: Vlimes Ability

#### Description

the vlimes ability allows the player to repair broken bridges between two connection points.

#### Functional Requirements

- It should be able to create a traversable bridge

#### Acceptance Criteria

- There should be a broken bridge prefab
- It should use the connection points for the anchor points
- It should be able to be used by the player only when they have the vlimes gem

#### Dependencies

- Player
- Math Application UI
- Calculation Zone
- Gem Inventory System

---

### Feature: Gem Inventory System

#### Description

The gem inventory system will be used to keep track of the gems the player has collected.

#### Functional Requirements

- It should be able to add a gem to the inventory
- It should be able to achieve it's purpose without having to predefine the gems
- It should be able to fire a `GemAmountUnityEvent` which parses the gem and the amount

#### Acceptance Criteria

- It should use a `ScriptableObject` to store the data

#### Dependencies

- Gems

---

### Feature: Sliamond in the Rough Ability

#### Description

The sliamond in the rough ability allows the player to choose which ability they want to use regardless of the gems they have collected.

- The student will use the sliamond in the rough ability to choose which ability they want to use

#### Functional Requirements

- It should be able to show the player a choice which ability they want to use

#### Acceptance Criteria

- It should use the previously created abilities

#### Dependencies

- Acid Ability
- Goo Ability
- Sticky Ability
- Vlimes Ability

---

### Feature: Math Application UI

#### Description

The math application UI is a UI that appears when the player enters a calculation zone.

- The student will use the math application UI to solve math problems

#### Functional Requirements

- It should be able to appear when the player enters a calculation zone
- It should be able to disappear when the player leaves the calculation zone
- It should be able to show the correct assignment in relation to the calculation zone

#### Acceptance Criteria

- There should be a math application UI prefab

#### Dependencies

- Calculation Zone

---

### Feature: In-game UI

#### Description

The in-game menu screen shows how to return to the main menu, access the settings screen, and continue the game.

- The student will continue the game
- The student will access the settings screen
- The student will go back to the main menu

#### Functional Requirements

- It should be able to access the settings menu
- It should be able to continue the game
- It should be able to go back to the main menu

#### Acceptance Criteria

- There should be an in-game menu screen prefab

#### Dependencies

None

---

### Feature: Gem Inventory UI

#### Description

The gem inventory UI displays the amount of gems the player

- The student will be able to see what kinds of gems they have

#### Functional Requirements

- It should be able to display the gems the player has

#### Acceptance Criteria

- There should be a Gem inventory UI prefab

#### Dependencies

- Gem-inventory system
- Gems
- Player

---

### Feature: Solid Obstacle

#### Description

Solid obstacles are game objects that the player can't pass through or destroy.

- The studente will have to circumvent the solid obstacles
- The level designer will be able to place obstacles throughout the level to create a challenge for the student

#### Functional Requirements

None

#### Acceptance Criteria

- There should be a solid obstacle prefab

#### Dependencies

None

---

### Feature: Destroyable Obstacles

#### Description

Destroyable obstacles are game objects that the player can destroy using the acid ability.

- The student will use the acid ability to destroy the destroyable obstacles
- The level designer will be able to place destroyable obstacles throughout the level to create a challenge for the student

#### Functional Requirements

- It should be able to be destroyed

#### Acceptance Criteria

- It should use the `Damageable` script to take damage
- There should be a destroyable obstacle prefab

#### Dependencies

None

---

### Feature: Level Selection Screen

#### Description

The level selection screen shows the user all the levels they can play.

- The student will be able to select a level
- The student will be able to go back to the main menu screen

#### Functional Requirements

- It should be able to show the levels the student can play
- It should be able to select a level
- It should be able to link a scene to a level

#### Acceptance Criteria

- There should be scene for the level selection screen

#### Dependencies

None

---

### Feature: Title Screen

#### Description

The title screen is the first thing the student sees when they open the game.

- The student will press the play button to go to the level selection screen
- The student can press the quit button to close the game
- The student can see a greyed-out settings button

#### Functional Requirements

- It should be able to go to the level selection screen
- It should close the game

#### Acceptance Criteria

- This should be a separate scene

#### Dependencies

- Level Selection

---

### Feature: Pause UI

#### Description

The student can open the pause screen when they use the pause button in the game.

- The student will open the pause menu during the game
- The student will go back to the level screen
- The student will resume the level
- The student will restart the level
- The student will return to the checkpoint

#### Functional Requirements

- It should be able to open the pause menu
- It should be able to pause all game objects in the level
- It should be able to access the main menu screen
- It should be able to resume the level
- It should be able to restart the level
- It should be able to return to the last checkpoint

#### Acceptance Criteria

- There should be an in-game pause UI prefab

#### Dependencies

None

---

### Feature: Checkpoint System

#### Description

The checkpoint system is used to save the progress of the player by saving the position of the last reached checkpoint.

- The students will use checkpoints to go back to the last checkpoint when they die/restart/choose to return to the last checkpoint
- The level designer will be able to place checkpoints strategically throughout the level

#### Functional Requirements

- It should be able to save the last checkpoint position the player reached
- It should only change the last checkpoint position once, after which it is not functional any more

#### Acceptance Criteria

- There should be a checkpoint prefab

#### Dependencies

- Player

---

### Feature: Platform

#### Description

The platform is an object within the game that the student stands on to traverse the level.

- The student will use the platform to traverse the level
- The level designer will be able to place platforms strategically throughout the level to create a traversal path

#### Functional Requirements

- It should be able to be walked on by the player

#### Acceptance Criteria

- It should have a connection at the beginning and end of the platform
- There should be a platform prefab

#### Dependencies

- Connection point

---

### Feature: Wall Pillar

#### Description

The wall pillar is an object within the game that is a visual connection point.

- The student will use the wall pillar to connect two connection points
- The level designer will be able to place wall pillars strategically throughout the level to create a traversal path

#### Functional Requirements

None

#### Acceptance Criteria

- It should use the connection point for the anchor point

#### Dependencies

- Connection Point

---

### Feature: Camera Behaviour

#### Description

The camera behaviour is modelled after Mario games, where the camera keeps the player in the middle of the screen.

#### Functional Requirements

- It should be able to keep within the bounds of the level, this is the only moment the player can be off-center
- It should be able to follow the student after they reach the middle of the screen

#### Acceptance Criteria

- It should use the cinemachine package

#### Dependencies

- Player

---

### Feature: Player

#### Description

The player is the main character of the game, they will be able to move around the world and progress through the level.

- The student will use the player to move around the world
- The game designer will customize how fast the player can move
- The game designer will customize how high the player can jump

#### Functional Requirements

- It should be able to jump
- It should be able to move 

#### Acceptance Criteria

- It should use the 'A' & 'Left-arrow' key to move left
- It should use the 'D' & 'Right-arrow' key to move right
- It should use the 'W' & 'Up-arrow' key to climb up
- It should use the 'S' & 'Down-arrow' key to climb down
- It should use the new Unity input system

#### Dependencies

None

---

#### Description

### Feature: Connection Point

The connection point is a reference point that is used to connect two points in space together.

- The game designer will be able to use the connection points to create behaviour
interact with the abilities

#### Functional Requirements

None

#### Acceptance Criteria

- There should be a connection point prefab

#### Dependencies

None

---
