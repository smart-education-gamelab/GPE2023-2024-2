# Mushroom of Bloom: Technical Requirements

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

### Feature: Shooting Tower

#### Description

The shooting tower is a tower that can shoot bullets at enemies.

- The student will use the shooting tower to defeat the enemies
- The game designer will customize the tower to have different shooting speed, range and bullets

#### Functional Requirements

- It should be able to shoot bullets in a direction specified by a linear function

#### Acceptance Criteria

- It should cost 50 flowers to place the tower
- It should have a shooting speed of 0.5 seconds per bullet
- It should have a health of 360
- It should have a range of 8 tiles
- It should fire a `UnityEvent` when it shoots a bullet
- There should be a shooting tower prefab

#### Dependencies

- Bullet
- Health system

---

### Feature: Bombing Tower

#### Description

The bombing tower can drop bombs on the specified coordinate to defeat enemies.

- The student will use the bombing tower to defeat the enemies
- The game designer will customize the tower to have different shooting speed, range and bullets

#### Functional Requirements

- It should be able to adjust the `x`- and `y`-coordinate of the bomb location to indicate where it should drop bombs

#### Acceptance Criteria

- It should cost 75 flowers to place the tower
- It should have a shooting speed of 4 seconds per bomb
- It should have a health of 420
- It should have a range of 10 tiles
- It should fire a `UnityEvent` when it drops a bomb
- There should be a bombing tower prefab

#### Dependencies

- Bomb
- Health system

---

### Feature: Final castle

#### Description

The final castle is the last 'tower' that sits at the end of the track.

#### Functional Requirements

- It should be able to take damage

#### Acceptance Criteria

- It should be placed at the end of each level from the start of the level
- It should have 100 health
- There should be a final castle prefab

#### Dependencies

- Health system

---

### Feature: Grid-based World System

#### Description

The grid-based World system is used to create a path for the enemies to follow and to place towers on.

- The level designer will create a path for the enemies to follow

#### Functional Requirements

- It should be able to create path pieces in a grid layout
- It should be able to place towers on open grid spaces directly surrounding the path pieces

#### Acceptance Criteria

- There should be a grid-based path system prefab

#### Dependencies

None

---

### Feature: Main Menu

#### Description

The main menu screen shows how to start the game, acces the settings screen and quit the game.

- The student will start the game
- The student will access the settings screen
- The student will quit the game

#### Functional Requirements

- It should be able to start the game
- It should be able to access the settings screen
- It should be able to quit the game

#### Acceptance Criteria

- There should be a main menu scene

#### Dependencies

None

---

### Feature: Level Selection Menu

#### Description

The level selection screen shows the user all levels they can play.

- The student will select a level
- The student will go back to the main menu

#### Functional Requirements

- It should be able to show the levels the student can play
- It should be able to select a level
- It should be able to link a scene to a level

#### Acceptance Criteria

- There should be a level selection scene

#### Dependencies

None

---

### Feature: Pause In-game UI

#### Description

The pause menu is used to pause & resume the game, open the settings menu and go back to the main menu.

- The student will open the pause menu using a button
- The student will go back to the start screen
- The student will resume the level
- The student will restart the level

#### Functional Requirements

- It should be able to open the pause menu
- It should be able to pause all game objects in the level
- It should be able to acces the start screen
- It should be able to resume the level
- It should be able to restart the level

#### Acceptance Criteria

- There should be an in-game UI prefab

#### Dependencies

None

---

### Feature: In-game Heads-up Display

#### Description

The level HUD UI shows the progress of the level in a visual manner.

- The student will see the health
- The student will see the amount of flowers collected

#### Functional Requirements

- It should be able to show the current overall health
- It should be able to show the amount of flowers collected

#### Acceptance Criteria

- There should be a HUD prefab

#### Dependencies

- Flower System
- Health System

---

### Feature: Flower System

#### Description

The flower system is a system is used to keep track of the amount of flowers that have been collected.

#### Functional Requirements

- It should be able to increase the amount of flowers
- It should be able to decrease the amount of flowers

#### Acceptance Criteria

- It should use a `ScriptableObject` to keep track of the amount of flowers
- It should fire an `int`-typed `GameEvent` when the amount of flowers changes

#### Dependencies

None

---

### Feature: Bullet

#### Description

The bullet is a projectile that is shot by the shooting tower.

- The game designer will customize the amount of damage the bullet does and how fast it moves

#### Functional Requirements

- It should follow a straight line based on the linear function of the tower
- It should damage the enemy on impact

#### Acceptance Criteria

- It should fire an `UnityEvent` when it hits an enemy
- There should be a bullet prefab

#### Dependencies

None

---

### Feature: Bomb

#### Description

The bomb is a projectile that is dropped by the bombing tower.

- The game designer will customize the amount of damage the bomb does and how fast it is dropped

#### Functional Requirements

- It should be dropped on a specified coordinate by the bombing tower
- It should damage enemies in a certain radius

#### Acceptance Criteria

- It should have an AOE of 2x2 tiles
- It should fire an `UnityEvent` when it explodes
- There should be a bomb prefab

#### Dependencies

None

---

### Feature: In-game Tower Placement UI

#### Description

The tower selection UI is used to select the type of tower the student can place within a level.

- The student can select which tower they want to place down

#### Functional Requirements

- It should be able to display which towers are available
- It should be able to display the amount of flowers it costs to place the tower

#### Acceptance Criteria

- It should fire an `UnityEvent` when a tower is selected
- There should be a tower placement UI prefab

#### Dependencies

- Grid-based World System

---

### Feature: Enemy 1

#### Description

The first enemy type is a small bullet sponge that moves along the path.

- The game designer will customize the amount of health, the movement speed and the amount of damage

#### Functional Requirements

- It should be able to take damage
- It should be able to move along the path
- It should be able to damage the towers
- It should be able to stop moving when it arrives on a path with a tower next to it

#### Acceptance Criteria

- It should have 50 points of health
- It should do 20 points of damage
- It should have an attack speed of 1 second per attack
- It should drop 10 flowers when it dies
- It should fire an `UnityEvent` when it dies
- It should fire an `UnityEvent` when it gets hit
- There should be an enemy type 1 prefab

#### Dependencies

- Flower System
- Grid-based World System

---

### Feature: Enemy 2

#### Description

The second enemy type is a slow shooting heavy hitting enemy with lower health

- The game designer will customize the amount of health, the movement speed and the amount of damage

#### Functional Requirements

- It should be able to take damage
- It should be able to move along the path
- It should be able to damage the towers

#### Acceptance Criteria

- It should have 30 points of health
- It should do 60 damage of damage
- It should have an attack speed of 3 seconds per attack
- It should drop 30 flowers when it dies
- It should fire an `UnityEvent` when it dies
- It should fire an `UnityEvent` when it gets hit
- There should be an enemy type 2 prefab

#### Dependencies

- Flower System
- Grid-based World System

---

### Feature: Waves System

#### Description

The wave system is used to manage the enemies that spawn in a level.

- The level designer will create waves of enemies that spawn at certain intervals

#### Functional Requirements

- It should be able to spawn enemies at a certain interval
- It should be able to spawn different types of enemies
- It should be able to spawn a certain amount of enemies
- It should be able to spawn enemies at a certain location
- It should be able to track how many enemies are left in the wave
- It should be able to track how many waves are left

#### Acceptance Criteria

- It should use a `ScriptableObject`-based for drag-and-drop wave creation
- It should fire an `UnityEvent` when a wave is completed
- There should be a wave system prefab

#### Dependencies

None

---

### Feature: Health System

#### Description

The health system is used to track the overall combined health.

#### Functional Requirements

- It should track the current overall health

#### Acceptance Criteria

- It should use a `ScriptableObject` to keep track of the overall health
- It should fire an `int`-typed `GameEvent` when the overall health changes
- It should fire an `GameEvent` when the overall health is 0 or below

#### Dependencies

None

---

### Feature: Demo Level

#### Description

The demo showcases the full implementation of the concept.

#### Functional Requirements

None

#### Acceptance Criteria

- It should implement all features created for Mushrooms of Bloom

#### Dependencies

All

---
