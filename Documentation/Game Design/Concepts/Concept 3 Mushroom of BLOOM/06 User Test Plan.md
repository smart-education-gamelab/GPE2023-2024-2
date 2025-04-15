# [Title]: User Test Plan

User Test Plan Template: `v1.2`

## Context

### Concept

Mushroom of BLOOM is a kind of tower defence game where the player places towers to defend their kingdom from the enemy, infected mushrooms called Bloomers. The player can place the towers alongside the enemies pathway and aim different types ammunition from towers using linear functions or coordinates. Before each wave the player has the ability to place the towers, upgrade, repair or buy new ones and aim their muzzles in his liking to defend his towers and in extension the kingdom.

Based on our design evaluation the following can be stated about Mushroom of BLOOM:

**Strengths**

- It can be easily expanded gameplay and mathematics wise.
- It has versatile ways to alter function(s).
- The player interacts in a very playful way with the mathematical aspect.
- It is relatively easy to play, and is therefore welcoming to new players.
- Once a wave starts the player doesn't need to pay full attention to the game.

**Weaknesses**

- The game has not been balanced yet, so there's a possibility that the gameplay is either too easy or too difficult.
- The game relies heavily on story and polish, these will not be implemented during the test.
- The player might get confused due to lack of guidance and/or visible progress.

### Goals

Based on our game design document and the design evaluation we want to test the following:

- **Entertainment value**: We want to test if our concept is engaging and interesting to play. Do the players understand what they need to do?
- **Instant Feedback**: Based on one of our design pillars we need to test if the feedback from the game is understandable to the player and he can change his approach if he fails the waves.
- **Challenge**: We need to find out if the game is challenging to the players. This also ties into the balancing aspect. If the game is too easy to play it is not engaging and therefore also has no entertainment value.
- **Mathematical implementation**: Do the players properly understand how the math works, and are they able to apply it properly.
  - *Pick a card*-method: Can our testers make the link between how the function looks and what the formula is.

### Hypotheses

We believe that the player will have a good experience with an engaging interaction. They will learn in a playful way how linear functions work. The player will be able to understand the link between how a function looks as a graph, how the formula for this specific function looks like, and how they interact.

## Design

### Participants

The participants for this test will be both guerilla testers and our target audience.

#### Guerilla Testers

Students from the HvA with varying ages, curriculums and level of math proficiency. This group of testers is more focused on the actual gameplay of the prototype.

#### Target Audience

The target audience for Mushroom of BLOOM are students from VWO & HAVO level currently studying mathematics. The math curriculum (A, B, C or D) they follow will be varying, as well as their level of proficiency in the subject matter and their age. On top of that due to the voluntary nature of the test some students might be more familiar with games in general.

### Methods

For this user test we have decided to use the following methods:

- Observation of the player during the game
- Interview with the player after the game

In order to achieve this we will require the following:

- Build of the game
- Laptop or desktop
- Mouse (input to play the game)
- Stopwatch
- Data collection form

### Metrics & Benchmarks

### Functionality

- Unintended Behaviour

  - **`Quantitative:`** How many bugs did the player encounter?

    ```text
    Count: 0 (ideal)
    ```
  - `Qualitative:` Give a quick description of each bug.
- Goal Hindrance

  - **`Quantitative:`** Did it hinder gameplay?

    ```text
    Boolean: No (ideal)
    ```

---

### Accessibility

- Control Clarity

  - **`Quantitative:`** How many seconds does it take the player to figure out how to place the towers?

    ```text
    Duration: 0 to 8 seconds (ideal)
    ```
- Feedback

  - **`Quantitative:`** How many times is the feedback shown / triggered?

    > I.e feedback is the grid; how many times did the player adjust the function and the grid was shown
    >

    ```text
    Count: 5 or more (ideal)
    ```
  - **`Quantitative:`** How many times does the player repeat the same mistake?

    > I.e a mistake could be placing a tower and adjusting the function so that it misses most of the enemies
    >

    ```text
    Count: 1 or less (ideal)
    ```
  - **`Quantitative:`** How many times does the player alter the trajectory of already placed towers to change / improve on his gameplay?

    > Preferably one time per tower
    >

    ```text
    Count: = 0 to 2 (ideal)
    ```

---

### User Experience

- Fun

  - **`Quantitative:`** Did the player ask to continue the game?

    ```text
    Boolean: Yes (ideal)
    ```
  - `Qualitative:` Would the player continue play if we made more content?
- Sensation

  - `Qualitative:` How well were you immersed in the game?
- Challenge

  - `Qualitative:` Do you think the gameplay is challenging?
- Error prevention and recovery

  - **`Quantitative:`** How many times did the player finish the level in one try?

    > Depends on how many levels we are going to test
    >

    ```text
    Count: 1 (ideal)
    ```

---

### Didactic Efficacy

- Learning objectives alignment

  - `Qualitative:` Does the player know which mathematical concepts were in the game?
- Assessment of knowledge acquisition:

  - **`Quantitative:`** Is the player able to finish the game / each level within a set amount of time?

    ```text
    Tutorial:

    Level 1:
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Engagement with educational content

  - `Qualitative:` Would the player continue playing the game?
- Expression

  - `Qualitative:` Would you play this game / concept to improve your math abilities?

---

### Game Flow

- Clarity of goals

  - **`Quantitative:`** How many times did the players ask what they were required to do?

    ```text
    Count: 0 (ideal)
    ```
- Effortlessness and ease

  - **`Quantitative:`** Are the players able to finish each level within a set amount of tries?

    ```text
    Tutorial: 1 try

    Level 1: 1 try
    ```
    ```text
    Boolean: Yes (ideal)
    ```
- Balance between challenge and skills

  - **`Quantitative:`** Did the player make a remark about the difficulty of the game during gameplay (i.e. too easy/difficult)?

    ```text
    Boolean: No (ideal)
    ```
  - `Qualitative:` Does the player feel like the level was too challenging or too easy and can they explain why?
