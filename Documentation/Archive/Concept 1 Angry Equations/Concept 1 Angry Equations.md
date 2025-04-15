# Angry Equations

## Personas

Student:

- Age 12 - 16
- Grade level: High School VWO
- With varying knowledge of math

## Functional Requirements

### Epic

1. As a student I want to practice my math skills in a fun way so that I can improve them.

#### User Stories

As a student I want to change the variables of the equation, so that I can solve them by finding the correct slope to hit the target.

As a student I want to change the variables of the equation, so that I can solve them by finding the correct height to hit the target.

As a student I want to be challenged based on my current understanding of math, so I do not get bored.

As a student I want to have a horizontal slider to change the slope of the projectile, so that I can see the effect of the slope on it's trajectory.

As a student I want to have button on the top and bottom to change the slope of the projectile, so that I can can see the effect of the slope on it's trajectory.

As a student I want to input using the numpad and keyboard to change the slope of the projectile, so that I can can see the effect of the slope on it's trajectory. 

As a student I want the projectile to stay active till it stops rolling so that I understand when the projectile stops moving and the shooting phase is over.

---

### Epic

2. As a student I want to get instant visual feedback on my answers so that I can learn from my mistakes.

#### User Stories

As a student I want the equation to be displayed on the screen so that I can see which variables I can change.

As a student I want a line to show the path of the graph (the start of the trajectory), so that I can see from which point gravity will influence the projectile.

As a student I want a dotted line to show how gravity has impacted the trajectory, so that I can see the effect of gravity on the projectile after the initial graph line.

As a student I want the slope variable to have the same colour as a rotation indicator of the cannon, so that I can see the relation between the slope and the rotation of the cannon.

As a student I want the height variable to have the same colour as a height indicator of the cannon, so that I can see the relation between the height/b value of the equation and the height of the cannon.

As a student I want to see the target on screen being hit by the projectile, so that I can see if I have hit the target.

As a student I want to feel like immersed by having the screen shake when I hit a lot targets at once.

As a student I want to see the cannon shake for 0.1 seconds or less when I select the slope variable.

As a student I want to see the platform shake up and down for 0.1 seconds or less when I select the height variable.

---

### Epic

3. As a student I want to be able to play the game without knowing what my current understanding of math is so that I can start playing the game right away.

#### User Stories

As a student I want to start the game without being to change the height of the function, while I need to figure out how to shoot over wall.

As a student I want to be forced to learn how I can shoot over the wall by changing the height of the function, by not being able to change the slope of the function.

---

### Epic

4. As a student I want to be able to see my game progress so that I can see where I am currently at.

#### User Stories

As a student I want to be able to see in which level I am currently at, so that I can see how far I am in the game.

As a student I want to be able to see how many targets I have hit, so that I can see how well I am doing.

---

### Epic

5. As a student I want to be able to see my math understanding progress so that I can see where I am currently at.

#### User Stories

## System Requirements

The system should be able to shake the screen based on a UnityVector2Event or a UnityFloatEvent.

The system should be able to move the camera by tracking a specific object.

The system should be able to handle multiple types of function declarations, using an extensible system.

The system should be able to track whether the damage threshold has been reached of breakable targets.

The designer tools should include drag and drop Targets, Structure Blocks, and functionality to create new levels.

The system should allow projectiles to slow down when they hit an object, before they disappear/are destroyed.

The system should allow for the trajectory line to be customizable (colour, thickness, dotted or not, space between, etc.) in the editor.

The system should allow for customizing the projectile physics (gravity, speed, etc.) in the editor.

The system should allow for customizing the breakable blocks & targets physics (gravity, movement sensitivity, bounciness, friction, etc.) in the editor.

The system should allow to show the trajectory in edit mode to configure the starting position and testing of levels.

The system should allow for interactable game objects to have configurable tweened animations.
