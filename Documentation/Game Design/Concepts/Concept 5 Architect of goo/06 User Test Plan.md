# Architect of Goo: User Test Plan

User Test Plan Template: `v1.2`

## Context

### Concept

In Architect of Goo the player is presented with the challenge of solving puzzles to reach their way out. These puzzles have to be solved by creating bridges using diverse representations of mathematical problems, which use lineair equations. The game has been inspired by many games including titles such as: *Super Mario Bros.*, *Slime rancher* and *Bridge builder*. It aims to teach the player about linear equations in a fun and engaging way.

The design of the games has been evaluated based on our evaluation process. This has presented us with the following strengths and weaknesses.

#### Strengths

- The game concept is easy to scale, it allows for future expansion in both game content and mathematical content.
- It is very flexible, enabling teachers to create custom levels to align with their curriculum.
- The game is designed to be fun first, and effectively introduces/incorporates educational content and making learning more enjoyable.
- The game is easy to replay and allows for a lot of trial and error, making it a good fit for learning mathematics.

#### Weaknesses

- The game could be challenging for students who are not familiar with the mathematical concepts it incorporates.
- Students who do not enjoy games or are not experienced gamers might find the game less engaging, reducing its effectiveness as a learning tool outside the classroom.
- The current and future progression of the game lacks a bit of clarity on the gradual introduction of new skills, levels, and worlds.
- Some players might find it difficult to grasp the complex mechanics required to solve the puzzles, especially if they are trying to understand the underlying math concepts at the same time.
- The heavy focus on math skills might overshadow other aspects of the game, such as platforming skills, which could enhance the overall gaming experience.
- The interaction between the mathematical mechanics and the gameplay mechanics do not mesh that well as off now (, i.e. why can the slime walk/jump if that is not used whilst progressing in the game). This can potentially make the game feel like a test environment.

### Goals

Based on the game design pillars mentioned in the Game Design Document (GDD), the core values of our client and the identified weaknesses we want to test the following:

- `Creativity`: Does the player feel challenged to think of a new solution / course of action?
- `Variety`: Is the player satisfied with the diversity of options this game offers?
- `Discovery`: Can the player satiate their curiosity to discover new possibilities (by trial and error)?
- `Challenge`: Is the challenge presented by the game within the means of the player, i.e. is it doable and not too easy or difficult?
- `Player experience/Fun`: is the player experience satisfactory enough that they would like to continue this experience?

### Hypotheses

As a team we believe that the game will bring forth a positive experience for the player. The player will enjoy the game play, and deepen their understanding about lineair equations. On top of that the player will be able to understand the link between the solution they enter and the output in the game. They will be able to finish each stage, and level within a set amount of tries (deaths).

## Design

### Participants

Both guerilla testers and our target audience will be the participants for this test.

#### Guerilla Testers

This group of testers is more focused on the actual gameplay of the prototype. Guerilla testers are students from the HvA with varying ages, curriculums and level of math proficiency.

#### Target Audience

The target audience for *Architect of Goo* are students from VWO & HAVO level currently studying mathematics. The math curriculum (A, B, C or D) they follow will be varying, as well as their level of proficiency in the subject matter and their age. On top of that due to the voluntary nature of the test some students might be more familiar with games in general.

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

From our `02 Benchmarks & Metrics` document we have selected and placed the following metrics & benchmarks in context of this concept:

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

  - **`Quantitative:`** How many seconds does it take the player to figure out the control scheme?

    ```text
    Duration: 0 to 10 seconds (ideal)

    ```
- UI clarity and simplicity

  - **`Quantitative:`** How many times does the player ask the test supervisor how the UI works?

    ```text
    Count: 0 (ideal)
    ```

---

### User Experience

- Fun

  - **`Quantitative:`** Did the player ask to continue the game?

    ```text
    Boolean: Yes (ideal)
    ```
  - `Qualitative:` Would the player continue play if we made more content?

    ```text
    Boolean: Yes (ideal)
    ```
- Satisfaction

  - `Qualitative:` How do you feel after completing the prototype / level / game?

    ```text
    Boolean: Yes (ideal)
    ```
  - `Qualitative:` Do you feel satisfied?

    ```text
    Boolean: Yes (ideal)
    ```
- Challenge

  - `Qualitative:` Do you think the gameplay is challenging?
- Sense of agency (influence)

  - `Qualitative:` Did you feel like you were doing math or playing a game?

    ```text
    Boolean: Playing a game (ideal)
    ```
  - `Qualitative:` How/What made you think you were (not) doing math?

- Error prevention and recovery

  - **`Quantitative:`** How many tries did it take the player to finish the stage to 100%?

    ```text
    Stage 1: 1 Try

    Stage 2: 1 Try

    Stage 3: 1 Try
    ```

    ```text
    Count: 1 (ideal)
    ```
  - **`Quantitative:`** How many times did the player finish the stage in one try?

    ```text
    Count: 3 (ideal)
    ```

---

### Didactic Efficacy

- Learning objectives alignment

  - `Qualitative:` Does the player know which mathematical concepts were in the game?
- Assessment of knowledge acquisition:

  - **`Quantitative:`** Is the player able to finish the the level within a set amount of deaths per stage?

    ```text
    Stage 1: 0 Deaths

    Stage 2: 0 Deaths

    Stage 3: 0 Deaths
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Engagement with educational content

  - `Qualitative:` Would the player continue playing the game?
- Expression
- - `Qualitative:` Would you play this game / concept to improve your math abilities?

---

### Game Flow

- Clarity of goals

  - **`Quantitative:`** How many times did the players ask questions?

    ```text
    Count: 0 (ideal)
    ```
- Effortlessness and ease

  - **`Quantitative:`** Are the players able to finish the level within a set amount of tries?

    ```text
    Prototype level: 1 try
    ```
    ```text
    Boolean: Yes (ideal)
    ```
- Balance between challenge and skills

  - **`Quantitative:`** Did the player make a remark about the difficulty of the game during gameplay (i.e. too easy/difficult)?

    ```text
    Boolean: No (ideal)
    ```
  - `Qualitative:` Does the player feel like the level / concept / game was too challenging or too easy and can they explain why?
