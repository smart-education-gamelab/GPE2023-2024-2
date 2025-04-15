# Angry Equations: Game Design Document

Using linear functions, you shoot an object forward to destroy objects and defeat the enemy (like angry birds). The function will determine at what angle the object will be shot. The velocity/speed of the object being shot is pre-defined. The shot object will have gravity applied to fall in a nice arch.

![Angry Equations Sketch](./Resources/Scetch_V0.1.png) 

## Design Pillars
<!-- Mission: What do we want to achieve? and Vision: How do we achieve this? (benchmarks) -->
<!-- More emotion: As the player I...... -->
### Aiming

1. The player will alter the linear equation to aim.
2. After this the player will launch/shoot an object.
3. The shot object will fall down after some time due to gravity.

<details>

| ![End Screen](./Resources/Angry_Trajectory.jpg) | ![Angry Equations Sketch](./Resources/Scetch_V0.1.png) |
| ----------------------------------------------- | ------------------------------------------------------ |

</details>

### Destruction

1. The shot object will hit pre-placed objects.
2. This results in damage to the objects and player.
3. The pre- placed objects will fall down. 
4. This results in damage to the objects itself and surrounding objects.

<details>

| ![End Screen](./Resources/Angry_Hit.png) | ![Angry Equations Sketch](./Resources/Angry_Domino.png) |
| ---------------------------------------- | ------------------------------------------------------- |

</details>

### Adaptive

The game should:

- Allow for easy changes to the gameplay difficulty.
- Allow for easy expansion (scalability).
- Clearly visualize mathematical changes.

### Learning goals

The client Erwin van Crasbeek provided the following learning goals for the game:

1. Playing with the fundamental characteristics of a linear function first individually and then in combination.
   
   <details>
   
   - Constant rate of change 
   
   - Y-intercept (start value)
   
   - Sign and magnitude of the slope
     
     </details>

2. Applying the fundamental characteristics to transform one representation (verbal, graph, formula, table) into another in a playful way.

3. Solving quests, tasks and problems involving multiple representations of linear function (verbal, graph, formula, table).

4. Applying properties of linear functions to solve equations in a playful way.
   
   <details>
   
   - It has one root (x-intercept, also called the “zero” of the linear function) and one y-intercept.
   
   - The y-intercept of the graph of a linear function is the value of the y-coordinate of the point where it crosses the y-axis. To find the y-intercept, compute f(0); the result is the value of b.
   
   - The x-intercept of the graph of a linear function is the value of the x-coordinate of the point where it crosses the x-axis. To find the x-intercept, set f(x) = 0, giving equation 0 = mx + band solve for x. We get x =-b/m (assuming m is not zero).
     
     </details>

5. Applying the appropriate function representation to solve a question or problem in the game.

In `Angry Equations` the most used learning goal is number five.

### Difficulty

`Easy to replay`: To ensure that this game is playable for the entire target group the game should be relatively simple to play. On top of that the game should allow the player to replay each level very easily to ensure all players can understand how the equations work and/or complete (all) levels.

`Competition`: To call upon the competitive nature of the target audience (12-16 years old) competition should be included in this game. This allows not only friendly competition, but encourages the students who understand linear equations to play the game as well.

## Game Lenses

After some research the following lenses fit the requirements and criteria the most. Each lens has been written down with their name and their number in the card deck. On top of that some question examples have been written down for each lens.

### 2: Lens of Essential Experience

- What experience should the player have?
  
  Players should experience the satisfaction of strategic problem-solving combined with the excitement of causing destruction.

- What is essential to their experience?
  
  Essential to their experience is the feeling of empowerment as they overcome challenges by carefully planning and executing their moves.

- How can the game capture this experience?
  
  The game can capture this experience by offering diverse levels with challenging obstacles that require strategic thinking and precise execution to overcome.

### 5: Lens of Fun

- What parts of the game are fun?
  
  The most enjoyable parts of the game include launching projectiles, witnessing the chaos that ensues, and discovering creative solutions to puzzles.

- What parts should bring more fun?
  
  Introducing imaginative power-ups, quirky characters, and humorous elements can enhance the fun factor and keep players engaged throughout the game.

### 21: Lens of Flow

- Does the game have clear goals?
  
  Each level should presents clear objectives, such as destroying structures or defeating enemies, guiding the player's actions.

- Does the game provide a steady stream of gradually increasing challenges?
  
  the game should offer a progression of challenges that become progressively more difficult, ensuring that players are constantly engaged and motivated.

- Are the player's skill improving as expected?
  
  By providing opportunities for skill development and mastery in each level, the game encourages players to improve their aim, timing, and problem-solving abilities.

### 34: Lens of Skill

- What skills does the game require from the player?
  
  The game requires players to master skills such as aim, timing, spatial awareness, and strategic planning.

- Are some players (much) better at these skills than others?
  
  Some players may naturally excel at these skills, while others may need more practice to improve and become proficient.

- Can players improve their skill with practice?
  
  Players should be able to improve their skills through practice and experience, the game should offer diverse challenges that test and hone their abilities.

### 38: Lens of Challenge

- What are the challenges in the game?
  
  Challenges include overcoming obstacles, solving puzzles, and defeating enemies, all of which require strategic thinking and precise execution.

- Are they too easy, too hard or just right?
  
  The challenges are finely tuned to be challenging enough to engage players and encourage strategic thinking, without becoming overly difficult and frustrating.

### 54: Lens of Accessibility

- How will players know how to solve the puzzle?
  
  Players are guided through simplistic controls, and clear visual feedback helping them understand puzzle solutions and mechanics.

- Does the puzzle or game act like something they have seen before?
  
  While drawing inspiration from familiar puzzle-solving mechanics, the game offers enough novelty and creativity to keep players intrigued and engaged.


## Main Features & Mechanics

### Core Mechanics

- **Core mechanic: Aiming**
  
  - The player aims at objects by using a function.

- **Secondary mechanic: Shooting**
  
  - An object is being shot depending on the angle the player is aiming. Gravity is applied to the shot object.

- **Third-level: Destroying objects**
  
  - The shot object will hit and destroy predefined enemies/objects.

- **Fourth-level: Completing level**
  
  - After all enemies/objects are destroyed or all ammunition has been used the level will be completed or failed.
  
  ![Angry Equations Onion](./Resources/Angry_onion.png) 

### Features

For this concept the entire team started of with brainstorming the diverse game ideas. Each idea was rated, keeping application of learning goals, entertainment and scalability in mind. Some requirements had been created upfront, which the idea should be able to include, such as:

- `Aiming`: Aiming is the central mechanic because it requires precision and skill, engaging players in the challenge of accurately targeting objects. In Angry Birds, aiming adds depth to gameplay by introducing a strategic element where players must carefully consider the trajectory of their shots.

- `Shooting`: Shooting is a fundamental aspect of the gameplay loop, as it allows players to interact with the game world and affect the outcome of their actions. By shooting objects based on the player's aiming angle, Angry Birds creates a direct connection between player input and on-screen action, enhancing player agency and immersion.

- `Destroying objects`: Destroying objects serves as both a goal and a reward for players. It provides immediate feedback and a sense of accomplishment when players successfully hit and eliminate targets. In Angry Birds, destroying objects is not only satisfying but also serves as a measure of progress within each level.

- `Completing level`: The completion condition adds structure to the gameplay experience, giving players clear objectives to strive for. By requiring players to either destroy all enemies/objects or use up all ammunition, Angry Birds establishes a sense of challenge and achievement, motivating players to strategise and persevere until they succeed.

These requirements were made after analysing and discussing the information provided by Erwin van Crasbeek.

## Target Platform & Target Audience

- Unity WebGL[^2]
  
  <details>
  
  Unity WebGL is a technology that allows Unity to publish content as JavaScript programs. These JavaScript programs utilize HTML5 technologies, WebAssembly, and the WebGL rendering API to run Unity content directly in a web browser. In other words, it enables you to create interactive 2D and 3D experiences (in Unity) that can be accessed and played within a web browser environment.
  
  </details>

- 12 – 16-year-old high school students (VWO).
  
  <details>
  
  The original game *Function Dungeon* is focused on teaching linear equations to high school kids aged 12-16 years old. As can be found in the original paper[^3]:
  
  > *"One central concept in mathematics is the concept of function (Linear functions). 
  > It enters the curriculum from the beginning of secondary school and it is needed to understand many topics (e.g. derivatives,equations, modelling).
  > It is also a complex concept for students and not easy to understand for some."*
  > 
  > **Palha S., Bouwer A., Van Smaalen d., and Hooijschuur K.**

  </details>

## Interface & Controls

Mouse only interface buttons. 

| ![Angry Equations Sketch](./Resources/Scetch_V0.1.png) | The red triangles (buttons) will increment the ‘a’ value. The red part of the canon moves as the formula changes. |
| ------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------- |

### Canon

- Player has 3 ammunition (3 attempts to shoot the cannon)
- The shot bullets explode on impact (disable/destroy the bullet), expanding outwards forces on all destructible objects surrounding the impact.
- The cannon works on a grid of 10 by 10
- The ax value cannot be more than 10 to prevent the cannon from shooting to the left
- The a value increments in steps of 0.25

### Level End Condition

- If all the enemies are taken out -> The level is cleared
- Clearing the level communicates to the player that they put in the right answer
- If the player is out of ammunition and there are still enemies remaining -> The level is failed
- Failing the level communicates to the player that they didn't put in the right answer

### Level Clear

Upon clearing the level, the camera will zoom out and a graph will fade in. This shows the function to establish the connection between the game and the math principles

![End Screen](./Resources/End_Screen.png) 

After putting in any input, the evaluation shows up and gives the player the option to return to the menu or proceed to the next level

![Evaluation](./Resources/Level_Cleared.png) 

How well you completed a level will be depicted in the amount of bananas. With either 1, 2 or 3. 

- Each block that you destroy in the level will give 100 points. - Each defeated enemy gives 500 points
- Each ammunition that hasn’t been used gives you another 500 points

The amount of bananas (think of it as a star system) rewarded will be based on the points the player got. 

<details>

For example: 2000p or more is 3 bananas, between 1500p and 2000p is 2 bananas and less than 1500p is 1 banana. The actual thresholds would have to be tested for.*

</details>

### Progression System

- The player gathers bananas rewarded from the levels. Once a banana has been earned, that level can no longer reward it to the player's total.

- Every 10 bananas, the player can advance the skill tree.

- Ideas for the power-ups: 
  
  - Increase in ammunition (making it possible to get higher scores because the player can keep more at the end of a level)
  - Increase in explosion radius/power Upon impact, ammunition splits up into 2 more that cause smaller explosions left and right.

## Measuring Player Skill

- We are not going to assume anything and just have every player start at level 1 and move from there.

- This is because there are many different levels of skill the player could have and it would be out of scope for us to properly scale.

- If a player is very good at math, they will quickly progress and eventually arrive at their skill level.

## Basic Story

- you are a pirate on a ship, and you destroy other ships (makes use of the cannon), story: they stole your treasure 

- you are a pirate on an island with a treasure, trying to sink incoming ships 

- you are a wizard who is trying to defeat the scumbags who stole his recipes for potions 

- you are a cool lama who spits on other lame lamas who are trying to kill your vibe 

- you are a monkey whom got their bananas stolen by raccoons and you're on a quest to get them back

## Similar Games & Genres

### GamePlay

`Angry Birds` 

<details>

| ![End Screen](./Resources/Angry_Bird.png) | ![Evaluation](./Resources/Angry_Domino.png) | ![End Screen](./Resources/Angry_Hit.png) | ![Evaluation](./Resources/Angry_Trajectory.jpg) |
| ----------------------------------------- | ------------------------------------------- | ---------------------------------------- | ----------------------------------------------- |

</details>

`Gold Miner` 

<details>

| ![End Screen](./Resources/GoldMiner_Title.png) | ![Evaluation](./Resources/GoldMiner_Simple.jpg) | ![End Screen](./Resources/GoldMiner_Grab.jpg) |
| ---------------------------------------------- | ----------------------------------------------- | --------------------------------------------- |

</details>

`Fleabag vs. Mutt`

<details>

| ![End Screen](./Resources/CatVSDog_Title.png) | ![Evaluation](./Resources/CatVSDog_Start.jpg) | ![End Screen](./Resources/CatVSDog_Throw.png) |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |

</details>

## Camera

The camera is stationary, focussed on both the cannon and the enemy structure, until the level is cleared at which point is zoomed out to fit the entire 10 by 10 grid in the camera.

## Types of blocks

- Destructible blocks

- Non-destructible blocks (Kinematic)

- Planks 
  
  <details>
  
  Help hold other blocks up (Destroyed when the block they're attached to are destroyed, makes it so the building collapses when destroyed)
  
  </details>

For now the blocks don't have a material so don't worry about grass/stone and different integrity

## Details

To help understand how these different blocks should work, look at the example level design:*

![Example](./Resources/Level_Design_Idea.png)

The dark grey block is scalable and kinematic, non-destructible.
The white blocks are destructible and abide by the rules of gravity.
The white blocks that form the roof are held up by the smaller planks.
If the block marked by a star is destroyed, the smaller plank will also be destroyed, resulting in the roof block falling down rotating to the left because the right plank is still attached.

## Development Timeline & Major Milestones

- 1-2 weeks, deadline *first iteration*: `May 8th` at `23:59`, `2024`

- Level design 
  
  - First level, change the ‘a’ value of the formula, changing the direction of the (canon) muzzle.
  - Second level, change the ‘b’ value of the formula, changing the height of the platform on which the canon is standing.

[^1]: K. Stuart, “How We Made Angry Birds,” the Guardian, Feb. 23, 2016. https://www.theguardian.com/artanddesign/2016/feb/23/how-we-made-angry-birds

<!-- <a name="note2">[2]</a> “Game Design Document angry bird,” studylib.net. https://studylib.net/doc/26975978/game-design-document-angry-bird (accessed Apr. 25, 2024). -->

[^2]: U. Technologies, “Unity - Manual: WebGL introduction,” docs.unity3d.com. https://docs.unity3d.com/Manual/webgl-intro.html#:~:text=The%20WebGL%20A%20JavaScript%20API%20that%20renders%202D (accessed Apr. 25, 2024).

[^3]: S. Palha, A. Bouwer, D. van Smaalen, and K. Hooijschuur, “FOSTERING JOYFUL PRACTICE WITH DIGITAL EDUCATIONAL GAMES: THE FUNCTION DUNGEON GAME .”
‌