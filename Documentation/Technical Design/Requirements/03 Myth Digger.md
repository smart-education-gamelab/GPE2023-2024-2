# Myth Digger: Technical Requirements

`v1.0`

## User Personas

### User: Student

#### Description

The student is the main end user of our product, they are between 14 to 18 years old, have a varying level of VWO math knowledge and will be mostly using our app through the web.

#### Goals

1. The student wants to practice his math skills in a fun & interactive manner
2. The student wants to know where his math skill is currently at & the system to respond according to their understanding

---

### User: Game Designer

#### Description

The game designer will be using the unity editor to combine scripts, change variables for balancing, and create new features.

#### Goals

1. The game designer wants to be able to create new features without having to change the existing code
2. The game designer wants to be able to test these features in the editor
3. The game designer wants to be able to tweak all variables of existing features

## Features

### Feature: Player

#### Description

The player is the main character of the game, they will be able to move around the map and interact with the environment.

- The student will use the player to move around the game world
- The student will use the player to interact with the environment
- The game designer will customise how fast the player can move
- The game designer will customise how high the player can jump

#### Functional Requirements

- It should be able to able to jump
- It should be able to move left and right
- It should be able to interact with the environment
- It should be able to place track

#### Acceptance Criteria

- It should use the `W` key to jump
- It should use the `A` key to move left
- It should use the `D` key to move right
- It should use the `E` key to interact with the environment
- It should use the `R` key to place tracks
- It should use the new Unity input system
- There should be an `Interactable` script which can be placed on other objects that the player can interact with which uses a `UnityEvent` to trigger the interaction

#### Dependencies

None

---

### Feature: Ore Processor

#### Description

The ore processor is a machine that processes ores into materials that can be used to craft items.

- The student will use the ore processor to process ores into materials
- The student will use the ore processor to train the application of transforming a graph of a linear function into a table
- The game designer will be able to set the linear function that the student has to solve

#### Functional Requirements

- It should be able to show an image representing the solution as a function line on a graph
- It should be able to present a table with `x`-values and `y`-values
- It should be able to display a grid of possible `y`-value options
- It should be able to input the predetermined `y`-values into the table
- It should be able to compare the inputs to a stored linear function

#### Acceptance Criteria

- It should use the material system to keep track of ores and materials
- It should use buttons to input the `y`-value options into the table
- It should include a button to confirm the inputs
- It should populate the table with all `x`-values and at least 2 `y`-values using the linear function
- It should fire an `UnityEvent` when the table is correctly filled in
- It should fire an `UnityEvent` when one correct input is chosen
- It should use the `Interactable` script to trigger the ore processor minigame
- There should be an ore processor prefab
- There should be an ore processor scene

#### Dependencies

- Material System

---

### Feature: Material System

#### Description

The material system keeps track of the materials and ores collected and used.

- The game designer will customise the materials
- The game designer will customise the ores
- The game designer will create new ores
- The game designer will create new materials

#### Functional Requirements

- It should be able to keep track of the ores collected
- It should be able to keep track of the ores used
- It should be able to keep track of the materials collected
- It should be able to keep track of the materials used
- It should be able to create new material types
- It should be able to create new ore types

#### Acceptance Criteria

- It should use `ScriptableObject`'s for a modular and editor-extendable system
- It should use `GameEvents` for notifying the game of changes in the material system during gameplay

#### Dependencies

None

---

### Feature: Crafter

#### Description

The player can interact with the crafter to create new items.

- The student will use the crafter to create new items
- The student will use the crafter to train their understanding of `x`- and `y`-intercepts
- The game designer will customise which recipes are available

#### Functional Requirements

- It should be able to create new items
- It should be able to upgrade existing items

#### Acceptance Criteria

- It should fire an `UnityEvent` when the item is crafted
- It should use the `Interactable` script to trigger the crafting minigame
- There should be a crafter scene
- There should be a crafter object prefab

#### Dependencies

- Crafting Manual
- Crafting Intercept Grid

---

### Feature: Item System

#### Description

The item system keeps track of the craft-able items and the materials needed to craft them.

- The game designer will customise the craft-able items
- The game designer will customise the materials needed to craft the items
- The game designer will create new items

#### Functional Requirements

- It should be able to keep track of the craft-able items
- It should be able to create new recipes for items
- It should be able to create new item types

#### Acceptance Criteria

- It should use `ScriptableObject`'s for a modular and editor-extendable system

#### Dependencies

- Material System

---

### Feature: Ore Tunnel

#### Description

Ore tunnels are used to collect and transport ores from the vein to the elevator shaft.

- The student will use the ore tunnel to collect ores
- The student will use the ore tunnel to learn the connection of the steepness of a linear function to the slope of a line
- The student will use the ore tunnel to learn the connection of the height of a linear function to the `y`-intercept of a line
- The game designer will create new ore tunnels

#### Functional requirements

None

#### Acceptance Criteria

- There should be a first track piece placed at the end of the tunnel
- There should be three ore tunnel prefabs with different configurations
- There should be a spike prefab

#### Dependencies

- Mine Cart Tracks

---

### Feature: Elevator

#### Description

The elevator is used to descend into the elevator mine and ascend to the surface world.

- The student will use the elevator to switch between the elevator mine and the surface world
- The game designer will populate the elevator mine scene with ore tunnels

#### Functional Requirements

- It should be able to switch to the elevator mine scene
- It should be able to switch to the surface world scene

#### Acceptance Criteria

- It should use the `Interactable` script to trigger scene changes
- There should be an elevator mine scene
- There should be an elevator mine entrance prefab

#### Dependencies

- Player

---

### Feature: Surface World

#### Description

The surface world contains the workshop and elevator mine entrance.

- The student will use the surface world to access the workshop
- The student will use the surface world to access the elevator mine
- The game designer will be able to customise the surface world with new features

#### Functional Requirements

None

#### Acceptance Criteria

- It must have a workshop
- It must have an elevator
- There should be a surface world scene

#### Dependencies

- Elevator
- Workshop

---

### Feature: Workshop

#### Description

The workshop contains the crafter and ore processor.

- The student will use the workshop to access the crafter
- The student will use the workshop to access the ore processor
- The game designer will be able to customise the workshop with new features

#### Functional Requirements

None

#### Acceptance Criteria

- It must have a crafter
- It must have an ore processor
- It should use the `Interactable` script to switch to the workshop scene
- There should be a workshop prefab
- There should be a workshop scene

#### Dependencies

- Crafter
- Ore Processor

---

### Feature: Mine Cart Tracks

#### Description

Mine cart tracks are used to transport materials out of the ore tunnels.

- The student will place mine cart tracks using linear functions
- The student will place mine cart tracks from the end of an ore tunnel to the elevator shaft
- The game designer will customise the appearance of the mine cart tracks

#### Functional Requirements

- It should be able to move up and down using the `b` value of the linear function
- It should be able to rotate using the `a` value of the linear function
- It should be able to connect to other track pieces

#### Acceptance Criteria

- It should use the linear equation UI for changing the position and rotation of the track
- It should fire an `UnityEvent` when the track is placed
- There should be a mine cart track prefab

#### Dependencies

- Player

---

### Feature: Crafting Manual

#### Description

The crafting manual is a book that displays the different recipes for crafting.

- The student will use the crafting manual to select which item to craft

#### Functional Requirements

- It should be able to display the materials needed to craft an item
- It should be able to allow the student to proceed to the minigame when they have the required amount of materials

#### Acceptance Criteria

- It should use recipes from the crafting system
- It should use the material system to track materials
- It should use a button to confirm the choice

#### Dependencies

- Item System

---

### Feature: Crafting Intercept Grid

#### Description

The crafting intercept grid is a minigame in which a `x`- and `y`-intercept puzzle is solved to craft items.

- The student will use the crafting intercept grid to train their understanding of `x`- and `y`-intercepts
- The game designer will be able to customise the intercept grid with new puzzles

#### Functional Requirements

- It should be able to accept a `x` value
- It should be able to accept a `y` value
- It should be able to accept an `a` and `b` value for linear function one
- It should be able to accept an `a` and `b` value for linear function two

#### Acceptance Criteria

- It should show an accurate function grid
- It should fire an `UnityEvent` when the point is correctly figured out
- It should use a button to confirm the solution input
- There should be a crafting intercept grid prefab

#### Dependencies

None

---

### Feature: Main Menu

#### Description

The main menu screen shows how to start the game, access the settings screen, and quit the game.

- The student will start the game
- The student will access the settings screen
- The student will quit the game

#### Functional Requirements

- It should be able to start the game
- It should be able to access the settings screen
- It should be able to quit the game

#### Acceptance Criteria

- There should be a main menu screen

#### Dependencies

None

---

### Feature: In-game Menu

#### Description

The in-game menu screen shows how to return to the main menu, access the settings screen, and continue the game.

- The student will be able to continue the game
- The student will be able to access the settings screen
- The student will be able to go back to the main menu

#### Functional Requirements

- It should be able to acces the settings menu
- It should be able to continue the game
- It should be able to go back to the main menu

#### Acceptance Criteria

- There should be an in-game menu screen prefab

#### Dependencies

None

---

### Feature: Camera Behaviour

#### Description

The camera will follow the player. If the player enters a cave, the camera will zoom in to fit the bounds of the cave in view.

#### Functional Requirements

- It should be able to follow the player
- It should be able to show the whole cave

#### Acceptance Criteria

- It should use the `Cinemachine` package
- It should use virtual cameras
- It should use `GameEvents`'s for switching between cameras

#### Dependencies

- Player
- Ore Tunnel

---
