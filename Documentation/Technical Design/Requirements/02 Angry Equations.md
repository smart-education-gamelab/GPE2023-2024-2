# Angry Equations: Technical Requirements

`v1.0`

This document will outline the technical requirements for the first concept of `Angry Equations`. Firstly we will go into the current user personas as defined for the software, after which we will outline which features need to be developed.

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

### Feature: Cannon

#### Description

A cannon is a game object which shoots projectiles in a specific direction.

- The student will use the cannon to aim & shoot projectiles at objects
- The student will not be able to shoot for a certain amount of time after shooting
- The level designer will be able to set the number of projectiles the cannon can shoot
- The game designer will be able to set the amount of time the cannon can't shoot after shooting
- The game designer will be able to create new cannons by reusing scripts on new game objects

#### Functional Requirements

- It should be able to translate a `float` variable into a rotation around it's origin
- It should be able to shoot a projectile
- It should be able to fire an `GameObjectEvent` when it shoots a projectile
- It should be able to set the number of projectiles the cannon can shoot
- It should be able to set the amount of time the cannon can't shoot after shooting

#### Acceptance Criteria

- It should use multiple scripts for its functional behaviour to allow for reusability
- It should use object pooling for managing it's projectiles

#### Dependencies

- Projectile
- Equation UI

---

### Feature: Cannon Platform

#### Description

The cannon platform is a game object which can move up and down, taking their child objects with them.

- The student will use the platform to move the cannon up and down to aim at objects
- The level designer will strategically place the cannon platform in the level

#### Functional Requirements

- It should be able to translate a `float` variable into a vertical translation

#### Acceptance Criteria

- There should be a cannon platform prefab with a cannon attached to it

#### Dependencies

- Cannon
- Equation UI

---

### Feature: Trajectory Line

#### Description

The trajectory line is a guide of which the first part will draw the line the equation will produce, and the second part will show the effect of gravity on the projectile.

- The student will see the line the equation will produce
- The student will see a rough estimate of where the projectile will go
- The level designer will customize the style of the two separate parts of the line
- The level designer will see the effects of the cannon placement on the projectile trajectory

#### Functional Requirements

- It should be able to turn off the gravity trajectory part of the line
- It should be able to disappear the gravity trajectory part of the line after shooting

#### Acceptance Criteria

- It should be drawn during edit mode as well as play mode

#### Dependencies

- Cannon
- Projectile

---

### Feature: Destructible Objects

#### Description

Destructible objects are objects that can be destroyed by projectiles.

- The student will be able to destroy objects by hitting them with projectiles
- The level designer will be able to set a threshold for when the object is destroyed
- The level designer will be able to set the number of points the object is worth
- The level designer will be able to define behaviour for when the object is destroyed
- The level designer will be able to place the destructible objects in the scene
- The game designer is able to set the correct points manager
- The game designer will be able to create new destructible objects by reusing scripts on new game objects

#### Functional Requirements

- It should be able to use a damage (health points) threshold to decide if the object should be destroyed
- It should be able to fire a `UnityEvent` for when the object is destroyed
- It should be able to fire a `UnityEvent` for when the object takes damage
- It should be able to take damage from other destructible objects when it falls based on `SharedVelocity`
- It should be able to set the number of points the object is worth

#### Acceptance Criteria

- There should be a destructible object prefab

#### Dependencies

- Points System

---

### Feature: Projectile

#### Description

Projectiles are game objects that are shot from the cannon.

- The level designer will be able to set the damage the projectile does
- The level designer will be able to set the number of points the object is worth
- The game designer is able to set the correct points manager

#### Functional Requirements

- It should exude a circular force onto the objects that surround the point of impact
- It should be able to apply damage to objects it hits
- It should follow a straight line for a configurable distance
- It should be able to apply gravity to the projectile after a configurable distance
- It should be able to set the number of points the object is worth

#### Acceptance Criteria

- It should have customised physics behaviour
- There should be a projectile prefab

#### Dependencies

- Points Manager

---

### Feature: Linear Equation UI

#### Description

The linear equation UI shows the linear equation of the projectile in the form of `y = ax + b`.

- The student will see the equation of the projectile
- The student will manipulate the `a` and `b` values of the equation
- The level designer will couple the output of the UI to the game objects in the scene
- The level designer will test different values for `a` and `b` in the editor during edit mode

#### Functional Requirements

- It should be able to use buttons to increase and decrease the `a` and `b` values
- It should be able to display the equation in the form of `y = ax + b`

#### Acceptance Criteria

- It should be colour coded to show the `a` and `b` values in relation to the game objects it interact with
- There should be a linear equation UI prefab

#### Dependencies

None

---

### Feature: 1st Tutorial Level

#### Description

The first level should focus on how to interact with the `a`, slope, variable of a function.

- The student will use this to understand the mechanics and concept of `a`

#### Functional Requirements

- The cannon should only allow for the `a` to be manipulated

#### Acceptance Criteria

- The level must be designed to focus on using the slope variable

#### Dependencies

- Cannon
- Linear Equation UI
- Level Progress UI
- Destructible Objects

---

### Feature: 2nd Tutorial Level

#### Description

The first level should focus on how to interact with the `b`, height, variable of a function.

- The student will use this to understand the mechanics and concept of `b`

#### Functional Requirements

- The cannon should only allow for the `b` to be manipulated

#### Acceptance Criteria

- The level must be designed to focus on using the height variable

#### Dependencies

- Cannon Platform
- Linear Equation UI
- Level Progress UI
- Destructible Objects

---

### Feature: Object Shake

#### Description

Game objects should be able to shake when being invoked to do so.

- The student will experience screen shake when hitting objects
- The level designer will set the shake duration and intensity
- The level designer will couple the shake behaviour to game objects in the scene

#### Functional Requirements

- It should be able to turn a `float` value into a shake duration
- It should be able to turn a `Vector2` value into a shake intensity

#### Acceptance Criteria

- It should have a `Shake()` method that can be called to shake the object

#### Dependencies

None

---

### Feature: Heads Up Display UI

#### Description

The level HUD UI shows the progress of the level in a visual manner.

- The student will see the current score
- The student will see the number of bullets left
- The student will see the number of targets left
- The level designer will set which objects are targets
- The game designer will be able to set the correct points manager

#### Functional Requirements

- It should be able to keep track of the amount of targets left
- It should be able to accept the amount of bullets left
- It should be able to fire a `UnityEvent` when all targets are destroyed
- It should be able to fire a `UnityEvent` when a target is destroyed

#### Acceptance Criteria

- It should allow for targets to not know they are targets
- It should use the points manager to get the current score

#### Dependencies

- Destructible Objects
- Point System

---

### Feature: Point System

#### Description

The point system keeps track of the level progression and saves the scores.

- The game designer will create the point manager & assign it to the correct prefabs

#### Functional Requirements

- It should be able to track the current level
- It should be able to keep track of the current score
- It should be able to set the threshold per score grade
- It should be able to translate the eventual score into a grade

#### Acceptance Criteria

- It should use a `ScriptableObject`
- It should use a serialised `struct`s for saving the data per level

#### Dependencies

None

---

### Feature: In-game UI

#### Description

The game UI is for input related to basic game functions.

- The student will be able to quit the game
- The student will be able to acces the level selection screen
- The student will be able to acces the settings screen
- The student will be able to fire the cannon

#### Functional Requirements

- It should be able to quit the game
- It should be able to acces the level selection screen
- It should be able to acces the settings screen
- It should be able to fire the cannon

#### Acceptance Criteria

- There should be an in-game UI prefab which also contains the linear equation UI

#### Dependencies

- Linear Equation UI

---

### Feature: Level Failed UI

#### Description

The level failed UI shows the user that they have failed the level.

- The student will be able to retry the level
- The student will be able to go back to the level selection screen
- The student will be able to see their failing grade

#### Functional Requirements

- It should be able to show the failing grade from the point system
- It should be able to retry the level
- It should be able to go back to the level selection screen

#### Acceptance Criteria

- There should be a level failed UI prefab

#### Dependencies

- Point System

---

### Feature: Level Selection Screen

#### Description

The level selection screen shows the user all the levels they can play.

- The student will be able to select a level
- The student will be able to see the grade they got on the level
- The student will be able to go back to the main menu screen

#### Functional Requirements

- It should be able to show the grade the student got on the selected level
- It should be able to show the levels the student can play
- It should be able to select a level
- It should be able to link a scene to a level

#### Acceptance Criteria

- It should use a separate scene

#### Dependencies

- Point System

---

### Feature: Main Menu Screen

#### Description

The main menu screen shows the user the options they have.

- The student will be able to acces the level selection screen
- The student will be able to acces the settings screen
- The student will be able to quit the game

#### Functional Requirements

- It should be able to acces the level selection screen
- It should be able to acces the settings screen
- It should be able to quit the game

#### Acceptance Criteria

- There should be a main menu screen scene

#### Dependencies

None

---

### Feature: Level Cleared UI

#### Description

The level cleared UI shows the user that they have cleared the level.

- The student will be able to retry the level
- The student will be able to go back to the level selection screen
- The student will be able to see their grade
- The student will be able to go to the next level

#### Functional Requirements

- It should be able to show the grade from the point system
- It should be able to retry the level
- It should be able to go back to the level selection screen
- It should be able to go to the next level

#### Acceptance Criteria

- There should be a level cleared UI prefab

#### Dependencies

- Point System

---

### Feature: Camera Behaviour

#### Description

The camera should be dynamic by following the projectile when shooting, and static when shooting or when the projectile is gone.

- The student will have a zoomed out overview of the level when aiming
- The student will have a zoomed in view of the projectile when shooting
- The student will have a zoomed out view of the level when the projectile is gone

#### Functional Requirements

- It should be able to follow the projectile when shooting
- It should be able to zoom in on the projectile when shooting
- It should be able to zoom out when the projectile is gone
- It should be able to zoom out when aiming
- It should be able to return to the original position when the projectile is gone

#### Acceptance Criteria

- It should use the cinemachine package

#### Dependencies

- Projectile
