# Kaiju Killer: Technical Requirements

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

### Feature: Kaijus

#### Description

The Kaiju are the monsters invading the earth that the player has to stop.

- The student will kill the Kaiju by solving math problems
- The game designer will customise the Kaiju's weak points

#### Functional Requirements

- It should be able to move closer to the player based on the turn system
- It should be able to set weak points that the player can hit
- It should be able to track the amount of weak points hit
- It should be able to fire a `UnityEvent` when it is killed

#### Acceptance Criteria

- There should be 3 Kaiju prefabs that can be placed in the scene with different designs/weak spots

#### Dependencies

- Turn System
- Weak Points

---

### Feature: Wave System

#### Description

The wave system will be responsible for picking a random wave for the player to play.

- The student will get a different set of Kajiu's to kill
- The game designer will be able to define which Kaiju's are available in the wave

#### Functional Requirements

- It should be able to create a random wave of Kaiju's
- It should be able to accept a list of Kaiju prefabs

#### Acceptance Criteria

- There should be a `WaveManager` script that can be placed in the scene
- It should use `ScriptableObject` to define and save the waves

#### Dependencies

- Kaijus

---

### Feature: Turn System

#### Description

The turn system will be responsible for switching between the player and the Kaiju, keeping track of the current turn and the amount of turns per wave.

- The game designer will be able to set the amount of turns per wave
- The game designer will be able to set the positions of the Kaiju per turn

#### Functional Requirements

- It should be able to switch the game state between the player and the Kaiju
- It should be able to keep track of the current turn
- It should be able to set the positions of the Kaiju per turn
- It should be able to set the amount of turns per wave
- It should be able to fire a `UnityEvent` when the turn is over/switched
- It should be able to fire a `UnityEvent` when a new turn is started

#### Acceptance Criteria

- There should be a turn system prefab that can be placed in the scene
- It should use `ScriptableObject` to define and save the turns

#### Dependencies

- Function UI
- Kaijus

---

### Feature: In-game HUD

#### Description

The HUD will be responsible for displaying the current turn, the amount of turns left, the player's health, and the wave number.

- The student will be able to see how many turns are left

#### Functional Requirements

- It should be able to show the current turn
- It should be able to show the amount of turns left

#### Acceptance Criteria

- There should be a turn system UI prefab that can be placed in the scene

#### Dependencies

- Turn System
- Wave System

---

### Feature: Weak Points

#### Description

Weak points are areas which a line can be crossed through to kill the Kaiju.

- The student will use the weak points to kill the Kaiju and see where the function should go

#### Functional Requirements

- It should be able to draw a circle around the weak point to signal the crossable area
- It should be able to fire a `UnityEvent` when the weak point is hit

#### Acceptance Criteria

- There should be a weak point prefab 

#### Dependencies

None

---

### Feature: ROBB-E

#### Description

The ROBB-E is the player's robot that will be used to kill the Kaiju.

- The student uses the ROBB-E as a personification of themselves
- The student will change the arm height using the function UI
- The game designer will be able to customise the ROBB-E's appearance

#### Functional Requirements

- It should be able to change the height of the arm while the joints correctly move along
- It should be able to fire its arms in the direction of the function

#### Acceptance Criteria

- There should be a ROBB-E prefab 

#### Dependencies

- Function UI

---

### Feature: Function UI

#### Description

The function UI will be responsible for displaying the current function that the player has to solve.

- The student will fill in the `a` and `b` component of a the linear function UI

#### Functional Requirements

- It should be able to display the current function
- It should be able to display the graph
- It should be able to confirm the input on it only being a floating point or integer number
- It should be able to switch between the two attack phases
- It should be able to disable the `b`, height, variable for the second attack phase

#### Acceptance Criteria

- There should be a Function UI prefab

#### Dependencies

None 

---

### Feature: Start Screen Scene

#### Description

The start screen will be responsible for displaying the start screen of the game.

- The student will be able to start the game
- The student will be able to quit the game

#### Functional Requirements

- It should be able to start the game
- It should be able to quit the game

#### Acceptance Criteria

- There should be a start screen scene

#### Dependencies

None

---

### Feature: Game Screen Scene

#### Description

The game scene is where the game will be played.

#### Functional Requirements

- It should be able to show all game elements and let the player interact with them

#### Acceptance Criteria

- There should be a game screen scene

#### Dependencies

- Turn System
- In-game HUD
- ROBB-E
- Wave System
- Function UI
