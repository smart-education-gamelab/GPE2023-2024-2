# Appendix D: User Test Plan & Data Model

This document holds all the user test plans and data models for each concept.

<!-- TOC -->

- [Concept 1: Angry Equations](#concept-1-angry-equations)
    - [User Test Plan](#user-test-plan)
        - [Context](#context)
        - [Design](#design)
    - [User Test Data Model](#user-test-data-model)
        - [General](#general)
        - [Environment](#environment)
        - [Data](#data)
- [Concept 2: Myth Digger](#concept-2-myth-digger)
    - [User Test Plan](#user-test-plan)
        - [Context](#context)
        - [Design](#design)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [User Test Data Model](#user-test-data-model)
        - [General](#general)
        - [Environment](#environment)
        - [Data](#data)
- [Concept 3: Mushroom of Bloom](#concept-3-mushroom-of-bloom)
    - [User Test Plan](#user-test-plan)
        - [Context](#context)
        - [Design](#design)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [User Test Data Model](#user-test-data-model)
        - [General](#general)
        - [Environment](#environment)
        - [Data](#data)
- [Concept 4: Kaiju Killer](#concept-4-kaiju-killer)
    - [User Test Plan](#user-test-plan)
        - [Context](#context)
        - [Design](#design)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [User Test Data Model](#user-test-data-model)
        - [General](#general)
        - [Environment](#environment)
        - [Data](#data)
- [Concept 5: Architect of Goo](#concept-5-architect-of-goo)
    - [User Test Plan](#user-test-plan)
        - [Context](#context)
        - [Design](#design)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [User Test Data Model](#user-test-data-model)
        - [General](#general)
        - [Environment](#environment)
        - [Data](#data)

<!-- /TOC -->

## Concept 1: Angry Equations

### User Test Plan

User Test Plan Template: `v1.2`

#### Context

##### Concept

Angry equations presents the player with the challenge of solving levels by shooting projectiles using linear equations. The game is inspired by the popular game Angry Birds and aims to teach the player about linear equations in a fun and engaging way.

The design itself has not been evaluated per our evaluation process. A quick guerilla/open user test has presented us with the following:

- They didn't feel a connection between the function input and the output on the screen.
- The B (y-manipulation) button is currently useless in the level where you don't influence only B (tutorial level 2).
- Having to press the B (y-manipulation) button repeatedly is not desired for the gameplay.

##### Goals

Based on the feedback from the guerilla test & our design values, we want to test the following:

- The connection between user input and the output on-screen
- The intuitiveness of the control scheme
- The general gameplay experience of the player
- The didactic value of the game

##### Hypotheses

We believe that the player will have a positive experience with the game and will be able to learn about linear equations in a fun and engaging way. The player will be able to connect the input they provide to the output on the screen and will be able to finish the levels within a set amount of time.

#### Design

##### Participants

The participants for this test will only be our target audience of students from the VWO & HAVO level currently studying mathematics. The math curriculum (A, B, C or D) they follow will be varying, as well as their level of proficiency in the subject matter and their age.

##### Methods

For this user test we have decided to use the following methods:

- Observation of the player during the game
- Interview with the player after the game

To achieve this we will need the following:

- Build of the game
- Laptop or desktop with mouse input to play the game
- Stopwatch
- Data collection form

##### Metrics & Benchmarks

###### Functionality

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

###### Accessibility

- Control Clarity:

  - **`Quantitative:`** How many seconds does it take the player to figure out the control scheme?

    ```text
    Duration: 0 to 10 seconds (ideal)
    ```
- UI clarity and simplicity:

  - **`Quantitative:`** How many clicks does the player require to open/start the first level?

    ```text
    Clicks: 3 or less (ideal)
    ```
  - **`Quantitative:`** How many times does the player ask the test supervisor how the UI works?

    ```text
    Times: 0 times (ideal)
    ```

###### User Experience

- Fun:

  - **`Quantitative:`** Did the player ask to continue the game?

    ```text
    Yes (ideal)
    ```
  - `Qualitative:` Would you continue play if we made more content?
- Sense of urgency:

  - `Qualitative:` Did the player feel time pressure to finish the game?
- Satisfaction:

  - `Qualitative:` How do you feel after completing the game?
  - `Qualitative:` Do you feel satisfied?
- Challenge:

  - `Qualitative:` Do you think the gameplay is challenging?

###### Didactic Efficacy

- Learning objectives alignment:

  - `Qualitative:` Does the player know which mathematical concepts were in the game?
- Assessment of knowledge acquisition:

  - **`Quantitative:`** Are the players able to finish levels within a set amount of time?

    ```text
    Tutorial A:

    Tutorial B:

    Demo 1:

    Demo 2:
    ```
- Engagement with educational content:

  - `Qualitative:` Would the player continue playing the game?
- Tutorial and guidance options:

  - **`Quantitative:`** Is the player making use of the tutorials offered by the game?

    ```text
    Yes (ideal)
    ```
- Expression:

  - `Qualitative:` Would you play this game to improve your math abilities?

###### Game Flow

- Complete concentration on the task:

  - **`Quantitative:`** How many times would the players let themselves be interrupted / distracted?

    ```text
    Times: 0 times (ideal)
    ```
- Clarity of goals:

  - **`Quantitative:`** How many times did the players aks questions?

    ```text
    Times: 0 times (ideal)
    ```
- Effortlessness and ease:

  - **`Quantitative:`** Are the players able to finish each level within a set amount of time?

    ```text
    Tutorial A:

    Tutorial B:

    Demo 1:

    Demo 2:
    ```
- Balance between challenge and skills:

  - **`Quantitative:`** Did the player make a remark about the difficulty of the game during gameplay (i.e. too easy/difficult)?

    ```text
    No (ideal)
    ```
  - `Qualitative:` Does the player feel like the game was too challenging or too easy and can they explain why?

### User Test Data Model

User Test Data Model Template: `v1.2`

#### General

##### Age

> Current age of the test subject

##### Curriculum

> Current/past study level

- [ ] VWO
- [ ] HAVO

##### Math level

> Current/past math level

- [ ] D
- [ ] B
- [ ] A
- [ ] C

##### Math proficiency

> Self-indication of the test subject regarding their math skills

- [ ] Very good
- [ ] Decent
- [ ] Not that good

#### Environment

##### Location

> Current location of where the test is performed

##### Operating System

> The operating system the test is performed on

##### Game Build Version

> Current build and/or version of the prototype

#### Data

##### During the Game

###### Game Phases

1. Start off the game

   - How many clicks does the player require to open/start the level?

     - [ ] 0 times
     - [ ] 1 to 5 times
     - [ ] 5 or more
2. Start of the level

   - How many seconds does it take the player to figure out the control scheme?

     - [ ] 10 seconds or less
     - [ ] 10 to 20 seconds
     - [ ] 20 seconds or more
3. End the level

   - Is the players able to finish each level within a set amount of time?

     - [ ] Yes
     - [ ] No

   ```text
   Tutorial A:

   Tutorial B:

   Demo 1:

   Demo 2:
   ```
4. End of game

   - Did the player ask to continue the game?

     - [ ] Yes
     - [ ] No

###### Observations

- How many times does the player ask the test supervisor how the UI works?

  - [ ] 0 times
  - [ ] 1 to 3 times
  - [ ] 3 or more
- Did the player make a remark about the difficulty of the game (i.e. too easy/difficult)?

  - [ ] Yes
  - [ ] No
- Can the player hit an enemy within their first 2 tries?

  - [ ] Yes
  - [ ] No
- How many times would the players let themselves be interrupted / distracted?

     - [ ] 0 times
     - [ ] 1 to 3 times
     - [ ] 3 or more
- How many times did the players ask questions?

  - [ ] 0 times
  - [ ] 1 to 3 times
  - [ ] 3 or more
- Is the player making use of the tutorials explanations offered by the game?

  - [ ] Yes
  - [ ] No

###### Bugs

- How many bugs did the player run into?

  - [ ] 0
  - [ ] 1 to 3
  - [ ] 3 or more
- Did it hinder gameplay?

  - [ ] Yes
  - [ ] No
- Give a quick description of the bug(s) encountered

  ```text



  ```

##### Interview Afterwards

- Would you continue to play if you could?

  - [ ] Yes
  - [ ] No
- _If no: Do you think you would continue playing if we made more content?_

```text



```

- How do you feel after completing the game?

> Make sure to ask why

```text



```

- Do you feel satisfied?

> Make sure to ask why

```text



```

- Did you feel time pressure to finish the game?

> Make sure to ask why

```text



```

- Do you think the gameplay is challenging?

> Make sure to ask why

```text



```

- Do you know which mathematical concepts were in the game?

> Make sure to ask why

```text



```

- Would you play this game to improve your math abilities?

> Make sure to ask why

```text



```

## Concept 2: Myth Digger

### User Test Plan

`v1.2`

#### Context

##### Concept

The player is someone who intends to find the supposed answer to the dying planet under the crust. Doing so will require the gathering of materials so they can craft tools necessary to dig further and be able to find the answers you're looking for. Building rails, processing ores, and using them in crafting allows you to progress through the game by digging deeper each time.
The game has a side view and the depths are dark. The light source is glowing gems that you can mine and use motes of to light up the path you're mining.

###### Strengths

- Strong emphasis on entertainment and weaving the mathematics into the core of the gameplay allowing for an experience focused on fun.
- Scalability and authorability considered in the original concept.
- The feel of a game, rather than a 'math game'.

###### Weaknesses

- Possibility of disconnect between mathematics and the narrative, feeling more like a test environment than a teaching game.
- The player might be confused as to what to do due to lack of guidance or visible progress.
- Scope and size make the game less suitable for in-class use and more as an extracurricular activity.

##### Goals

Entertainment first was a large client value, and this concept was made with that specifically in mind. Although the mathematics are intertwined with the gameplay loop, the initial core of the mechanics was considered separately. The risk this has led to is a potential disconnect between the idea of a learning game and a game as a challenge, causing the game to feel more like a test environment rather than a game that teaches these skills on their own. This test is to determine whether this is the case with this concept and if an approach to concepts in this fashion would be feasible for future iterations of this particular concept, or new concepts made for the client.

Additionally, this test serves as a general point to find out whether the core of the game is enjoyable to play. A game intended to entertain first and foremost that is not entertaining fails to reach its own goals. This test will help identify key issues that can be resolved in later iterations. 

As a final point, this test will also show the accessibility of its current design in both UI and general game progression. Bottlenecks can be spotted and adjusted based on the feedback from the participants.

##### Hypotheses

Because the game has been designed with fun in mind, we expect that the player finds the mechanics enjoyable to interact with, pulling them in for further exploration. Unfortunately, as it is only a prototype to a proof of concept, aspects of the final gameplay are lacking, which makes this compared to its entire design not a fully reliable test as a vertical slice would. It does, however, provide insight to the core mechanics and the core loop.

We believe that with how the game pacing is laid out, the game is accessible and understandable for the player to step into and grasp both the mechanics, but also the mathematics within those. 

Expected feedback is that laying down the tracks is tedious and takes too much time. This is based on previous tests with other concepts, revealing actions to be repetitive without that being a consideration by the designer originally. Additionally, the fact this game is only a prototype so far can be another issue with pacing; we do expect the player to wander around rather aimlessly in the beginning due to lack of initial guidance.

#### Design

##### Participants

###### Guerilla testers

Basically anyone we can find that are willing to test the game. The intent of this type of test is to find out if the game works on a general level, but also to measure the immediate experience of fun. This group will have a wide variety of ages, even outside of the original target group, as well as highly variant mathematic skills.

###### Ideal Test Environment

The ideal location for testing is somewhere void of outside influences. Try to sit down with the tester in a place where there isn't much noise and as little other people as possible. We want test results to be as clean as can be, for that to happen we provide the tester with an environment that allows them to focus on the game.

The operating system the game is running on should remain consistent in order to reduce the potential for bugs caused by variants in OS use (eg. MacOS and Windows). We aim to use machines that run Windows 10 and 11 for this reason.

###### Target Users

Target users are the group the game was designed for; students of VWO level education aged 12-16 with any level of mathematic skills, but also a wide range of experience in games. The general expectation is that all are familiar with linear equations to some degree. However, this group's participation is based largely on voluntary basis, which does mean we might see students with more experience and affinity for games in general.

###### Ideal Test Environment

The target demographic is 12 - 16 year olds. It's hard to get a hold of them for us as we would have to rely on sibblings, nephews nieces. This is why we are looking to approach high schools to test our game. Therefor the test environment will be located within the school. The conditions will be similar to the guerilla testers; location with as little outside influences as possible. Try to secure a separate classroom for testing and ideally don't have multiple testers in the room. We want to avoid the testers communicating with each other because it might influence their mood and view of the game. 

The operating system the game is running on should remain consistent in order to reduce the potential for bugs caused by variants in OS use (eg. MacOS and Windows). We aim to use machines that run Windows 10 and 11 for this reason.

##### Methods

###### Observation

The foremost concern is observing for actions of interest by the tester. As the observer, we need to cover the qualitative metrics. We also need to take note of aspects that aren't in the form like body language and the spoken words by the tester.

###### Interview

After the tester has played the prototype, they will be interviewed on a few key points that are outlined under the section Metrics and Benchmarks. Their opinions are distilled to some primary words that will be placed in a wordcloud to give us a fast indication of the overal feeling and opinion, and allows us to identify the general consensus.

###### Required Tools

- Laptop + charger
- Prototype build on test machine
- Stopwatch
- Separate laptop with a text editing program for notetaking, OR
- Pen and paper for notetaking

Latter depends on overal setup and available machines.

##### Metrics & Benchmarks

###### Functionality

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

###### Accessibility

- Control Clarity

  - **`Quantitative:`** How many seconds does it take the player to figure out the control scheme?

    ```text
    Duration: 0 to 10 seconds (ideal)
    ```
- Text readability

  - **`Quantitative:`** How many times did the player ask what was written?

    ```text
    Count: 0 (ideal)
    ```
  - `Qualitative:` Does the player have any trouble reading the text and can they explain why?
- UI clarity and simplicity

  - **`Quantitative:`** How many clicks does the player require to open/start the level?

    ```text
    Count: 3 or less (ideal)
    ```
  - **`Quantitative:`** How many times does the player ask the test supervisor how the UI works?

    ```text
    Count: 0 (ideal)
    ```
- Feedback

  - **`Quantitative:`** How many times is the feedback shown / triggered?

    ```text
    Count: 1 or more (ideal)
    ```
  - **`Quantitative:`** How many times does the player repeat the same mistake?

    ```text
    Count: 3 or less (ideal)
    ```
  - **`Quantitative:`** How many times does the player rely on the feedback to improve his gameplay?

    ```text
    Count: 0 (ideal)
    ```

###### User Experience

- Fun
  - **`Quantitative:`** Did the player ask to continue the game?

    ```text
    Boolean: Yes (ideal)
    ```
  - `Qualitative:` Would the player continue play if we made more content?
- Sense of urgency

  - `Qualitative:` Did the player feel time pressure to finish the prototype?
- Satisfaction

  - `Qualitative:` How do you feel after completing the prototype?
  - `Qualitative:` Do you feel satisfied?
- Sensation

  - `Qualitative:` How well were you immersed in the game?
- Challenge

  - `Qualitative:` Do you think the gameplay is challenging?
- Expression

  - `Qualitative:` Do you feel like you needed to think about your choices?
- Sense of agency (influence)

  - `Qualitative:` Did you feel like you were doing math or playing a game?
  - `Qualitative:` How/What made you think you were (not) doing math?

###### Didactic Efficacy

- Learning objectives alignment

  - `Qualitative:` Does the player know which mathematical concepts were in the game?
- Assessment of knowledge acquisition:

  - **`Quantitative:`** Is the player able to finish each segment within a set amount of time?

    ```text
    Rail Building: time

    Processing: time

    Crafting: time
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Engagement with educational content

  - `Qualitative:` Would the player continue playing the game?

- Expression

  - `Qualitative:` Would you play this game to improve your math abilities?

###### Game Flow

- Complete concentration on the task

  - **`Quantitative:`** How many times would the players let themselves be interrupted / distracted?

    ```text
    Count: 0 (ideal)
    ```
- Clarity of goals

  - **`Quantitative:`** How many times did the players ask questions?

    ```text
    Count: 0 (ideal)
    ```
- Effortlessness and ease

  - **`Quantitative:`** Are the players able to finish each segment within a set amount of tries?

    ```text
    Rail Building: number

    Processing: number

    Crafting: number
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Balance between challenge and skills

  - **`Quantitative:`** Did the player make a remark about the difficulty of the game during gameplay (i.e. too easy/difficult)?

    ```text
    Boolean: No (ideal)
    ```
  - `Qualitative:` Does the player feel like the game was too challenging or too easy and can they explain why?

### User Test Data Model

#### General

##### Age

> Current age of the test subject

##### Curriculum

> Current/past study level

- [ ] VWO
- [ ] HAVO

##### Math level

> Current/past math level

- [ ] D
- [ ] B
- [ ] A
- [ ] C

##### Math proficiency

> Self-indication of the test subject regarding their math skills

- [ ] Very good
- [ ] Decent
- [ ] Not that good

#### Environment

##### Location

> Current location of where the test is performed

##### Operating System

> The operating system the test is performed on

##### Game Build Version

> Current build and/or version of the prototype

#### Data

##### During the Game

###### Game Phases 

1. Start off the game

    - How many clicks does the player require to get into the game?

        - [ ] 0 times
        - [ ] 1 to 5 times
        - [ ] 5 or more

2. Start of the game

   - How many seconds does it take the player to figure out the control scheme?

        - [ ] 10 seconds or less
        - [ ] 10 to 20 seconds
        - [ ] 20 seconds or more

3. End the game

   - Is the players able to finish each part of the game loop within a set amount of time?

        - [ ] Yes
        - [ ] No

    ```text
    Tunnel:

    Surface:

    Processing:

    Crafting:
    ```

   - Did the player ask to play again?

        - [ ] Yes
        - [ ] No

###### Observations

- How many times does the player ask the test supervisor how the UI works?

    - [ ] 0 times
    - [ ] 1 to 3 times
    - [ ] 3 or more
- Did the player make a remark about the difficulty of the game (i.e. too easy/difficult)?

    - [ ] Yes
    - [ ] No
- Can the player properly place down the first track within their first 2 tries?

    - [ ] Yes
    - [ ] No
- How many times would the players let themselves be interrupted / distracted?

    - [ ] 0 times
    - [ ] 1 to 3 times
    - [ ] 3 or more
- How many times did the players ask questions?

    - [ ] 0 times
    - [ ] 1 to 3 times
    - [ ] 3 or more
- Is the player making use of the tutorials explanations offered by the game?

    - [ ] Yes
    - [ ] No

###### Bugs

- How many bugs did the player run into?

    - [ ] 0 
    - [ ] 1 to 3 
    - [ ] 3 or more
- Did it hinder gameplay?

    - [ ] Yes
    - [ ] No
- Give a quick description of the bug(s) encountered

    ```text



    ```

##### Interview Afterwards

- Would you continue to play if you could?

    - [ ] Yes
    - [ ] No

- _If no: Do you think you would continue playing if we made more content?_

```text



```

- How do you feel after completing the game?

> Make sure to ask why

```text



```

- Do you feel satisfied?

> Make sure to ask why

```text



```

- Did you feel time pressure to finish the game?

> Make sure to ask why

```text



```

- Do you think the gameplay is challenging?

> Make sure to ask why

```text



```

- Do you know which mathematical concepts were in the game?

> Make sure to ask why

```text



```

- Would you play this game to improve your math abilities?

> Make sure to ask why

```text



```

## Concept 3: Mushroom of Bloom

### User Test Plan

User Test Plan Template: `v1.2`

#### Context

##### Concept

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

##### Goals

Based on our game design document and the design evaluation we want to test the following:

- **Entertainment value**: We want to test if our concept is engaging and interesting to play. Do the players understand what they need to do?
- **Instant Feedback**: Based on one of our design pillars we need to test if the feedback from the game is understandable to the player and he can change his approach if he fails the waves.
- **Challenge**: We need to find out if the game is challenging to the players. This also ties into the balancing aspect. If the game is too easy to play it is not engaging and therefore also has no entertainment value.
- **Mathematical implementation**: Do the players properly understand how the math works, and are they able to apply it properly.
  - *Pick a card*-method: Can our testers make the link between how the function looks and what the formula is.

##### Hypotheses

We believe that the player will have a good experience with an engaging interaction. They will learn in a playful way how linear functions work. The player will be able to understand the link between how a function looks as a graph, how the formula for this specific function looks like, and how they interact.

#### Design

##### Participants

The participants for this test will be both guerilla testers and our target audience.

###### Guerilla Testers

Students from the HvA with varying ages, curriculums and level of math proficiency. This group of testers is more focused on the actual gameplay of the prototype.

###### Target Audience

The target audience for Mushroom of BLOOM are students from VWO & HAVO level currently studying mathematics. The math curriculum (A, B, C or D) they follow will be varying, as well as their level of proficiency in the subject matter and their age. On top of that due to the voluntary nature of the test some students might be more familiar with games in general.

##### Methods

For this user test we have decided to use the following methods:

- Observation of the player during the game
- Interview with the player after the game

In order to achieve this we will require the following:

- Build of the game
- Laptop or desktop
- Mouse (input to play the game)
- Stopwatch
- Data collection form

##### Metrics & Benchmarks

###### Functionality

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

###### Accessibility

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

###### User Experience

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

###### Didactic Efficacy

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

###### Game Flow

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

### User Test Data Model

User Test Data Model Template: `v1.2`

#### General

##### Age

> Current age of the test subject

##### Curriculum

> Current/past study level

- [ ] VWO
- [ ] HAVO

##### Math level

> Current/past math level

- [ ] D
- [ ] B
- [ ] A
- [ ] C

##### Math proficiency

> Self-indication of the test subject regarding their math skills

- [ ] Very good
- [ ] Decent
- [ ] Not that good

#### Environment

##### Location

> Current location of where the test is performed

##### Operating System

> The operating system the test is performed on

##### Game Build Version

> Current build and/or version of the prototype

#### Data

##### During the Game

###### Game Phases

1. Start off the game

   - How many clicks does the player require to open/start the level?

     - [ ] 0 times
     - [ ] 1 to 5 times
     - [ ] 5 or more
2. Start of the level

   - How many seconds does it take the player to figure out how to place the towers??

     - [ ] 8 seconds or less
     - [ ] 8 to 18 seconds
     - [ ] 18 seconds or more
3. End the level

   - Is the players able to finish each level within a set amount of time?

     - [ ] Yes
     - [ ] No

   ```text
   Tutorial:

   Level 1:
   ```

   - **`Quantitative:`** Are the players able to finish each level within a set amount of tries?

     - [ ] Yes
     - [ ] No

   ```text
   Tutorial:

   Level 1:
   ```
4. End of game

   - Did the player ask to continue the game?

     - [ ] Yes
     - [ ] No

###### Observations

- Did the player make a remark about the difficulty of the game (i.e. too easy/difficult)?

  - [ ] Yes
  - [ ] No
- _if yes what did they say?_

  ```text



  ```
- How many times would the players let themselves be interrupted / distracted?

  - [ ] Yes
  - [ ] No
- How many times did the players ask what they were supposed to do?

  - [ ] 0 times
  - [ ] 1 to 3 times
  - [ ] 3 or more
- How many times is the feedback shown/triggered?

  - [ ] 5 times or less
  - [ ] 5 to 8 times
  - [ ] 8 or more
- How many times does the player repeat the same mistake?

  - [ ] 1 time or less
  - [ ] 2 or 3 times
  - [ ] 3 or more
- How many times does the player alter the trajectory of already placed towers to change / improve on his gameplay?

  - [ ] 0 to 2 times
  - [ ] 2 to 5 times
  - [ ] 5 or more

###### Bugs

- How many bugs did the player run into?

  - [ ] 0
  - [ ] 1 to 3
  - [ ] 3 or more
- Did it hinder gameplay?

  - [ ] Yes
  - [ ] No
- Give a quick description of the bug(s) encountered

  ```text



  ```

##### Interview Afterwards

- Would you continue to play if you could?

  - [ ] Yes
  - [ ] No
- _If no: Do you think you would continue playing if we made more content?_

```text



```

- Would you play this game to improve your math abilities?

> Make sure to ask why

```text



```

- How do you feel after completing the game (sensation)?

> Make sure to ask why

```text



```

- Do you feel satisfied?

> Make sure to ask why

```text



```

- Do you think the gameplay is challenging?

> Make sure to ask why

```text



```

- Do you know which mathematical concepts were in the game?

> Make sure to ask why

```text



```

## Concept 4: Kaiju Killer

### User Test Plan

`v1.2`

#### Context

##### Concept

The player is piloting a mech in order to save the world from the kaiju's terror. Their way of beating kaiju is to hit their weakspots. The mech has detachable rocket powered fists that the player has to dictate the trajectory of. Both the initial launch as well as the second arc are decided upon by the linear equation the player provides. Missing the weakspots will results in the threat of the kaiju becoming bigger as they draw closer to the player. Avoid getting hit by the kaiju and defeat all the kaiju untill you've neutralized the final world shattering kaiju.

###### Strengths

- Turn based, roguelike elements invite the player to keep experimenting without the anxiety time limit brings.
- Scalability and authorability considered in the original concept.

###### Weaknesses

- Possibility of disconnect between mathematics and the narrative, feeling more like a test environment than a teaching game.
- Scope and size make the game less suitable for in-class use and more as an extracurricular activity.

##### Goals

Entertainment first was a large client value, and this concept was made with that specifically in mind. Although the mathematics are intertwined with the gameplay loop, the initial core of the mechanics was considered separately. The risk this has led to is a potential disconnect between the idea of a learning game and a game as a challenge, causing the game to feel more like a test environment rather than a game that teaches these skills on their own. This test is to determine whether this is the case with this concept and if an approach to concepts in this fashion would be feasible for future iterations of this particular concept, or new concepts made for the client.

Additionally, this test serves as a general point to find out whether the core of the game is enjoyable to play. A game intended to entertain first and foremost that is not entertaining fails to reach its own goals. This test will help identify key issues that can be resolved in later iterations. 

As a final point, this test will also show the accessibility of its current design in both UI and general game progression. Bottlenecks can be spotted and adjusted based on the feedback from the participants.

##### Hypotheses

Because the game has been designed with fun in mind, we expect that the player finds the mechanics enjoyable to interact with, pulling them in for further exploration. Unfortunately, as it is only a prototype to a proof of concept, aspects of the final gameplay are lacking, which makes this compared to its entire design not a fully reliable test as a vertical slice would. It does, however, provide insight to the core mechanics and the core loop.

We believe that with how the game pacing is laid out, the game is accessible and understandable for the player to step into and grasp both the mechanics, but also the mathematics within those. 

Expected feedback is that the challenge is too low. This is because the prototype will not be reflective of the whole experience and only encapsulates the ease of the start.

#### Design

##### Participants

###### Guerilla testers

Basically anyone we can find that are willing to test the game. The intent of this type of test is to find out if the game works on a general level, but also to measure the immediate experience of fun. This group will have a wide variety of ages, even outside of the original target group, as well as highly variant mathematic skills.

###### Ideal Test Environment

The ideal location for testing is somewhere void of outside influences. Try to sit down with the tester in a place where there isn't much noise and as little other people as possible. We want test results to be as clean as can be, for that to happen we provide the tester with an environment that allows them to focus on the game.

The operating system the game is running on should remain consistent in order to reduce the potential for bugs caused by variants in OS use (eg. MacOS and Windows). We aim to use machines that run Windows 10 and 11 for this reason.

###### Target Users
Target users are the group the game was designed for; students of VWO level education aged 12-16 with any level of mathematic skills, but also a wide range of experience in games. The general expectation is that all are familiar with linear equations to some degree. However, this group's participation is based largely on voluntary basis, which does mean we might see students with more experience and affinity for games in general.

###### Ideal Test Environment

The target demographic is 12 - 16 year olds. It's hard to get a hold of them for us as we would have to rely on sibblings, nephews nieces. This is why we are looking to approach high schools to test our game. Therefor the test environment will be located within the school. The conditions will be similar to the guerilla testers; location with as little outside influences as possible. Try to secure a separate classroom for testing and ideally don't have multiple testers in the room. We want to avoid the testers communicating with each other because it might influence their mood and view of the game. 

The operating system the game is running on should remain consistent in order to reduce the potential for bugs caused by variants in OS use (eg. MacOS and Windows). We aim to use machines that run Windows 10 and 11 for this reason.

##### Methods

###### Observation
The foremost concern is observing for actions of interest by the tester. As the observer, we need to cover the qualitative metrics. We also need to take note of aspects that aren't in the form like body language and the spoken words by the tester.

###### Interview
After the tester has played the prototype, they will be interviewed on a few key points that are outlined under the section Metrics and Benchmarks. Their opinions are distilled to some primary words that will be placed in a wordcloud to give us a fast indication of the overal feeling and opinion, and allows us to identify the general consensus.

###### Required Tools
- Laptop + charger
- Prototype build on test machine
- Stopwatch
- Separate laptop with a text editing program for notetaking, OR
- Pen and paper for notetaking

Latter depends on overal setup and available machines.

##### Metrics & Benchmarks

###### Functionality

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

###### Accessibility

- Control Clarity

  - **`Quantitative:`** How many seconds does it take the player to figure out the control scheme?

    ```text
    Duration: 0 to 5 seconds (ideal)
    ```
- Text readability

  - **`Quantitative:`** How many times did the player ask what was written?

    ```text
    Count: 0 (ideal)
    ```
  - `Qualitative:` Does the player have any trouble reading the text and can they explain why?
- UI clarity and simplicity

  - **`Quantitative:`** How many clicks does the player require to open/start the game?

    ```text
    Count: 3 or less (ideal)
    ```
  - **`Quantitative:`** How many times does the player ask the test supervisor how the UI works?

    ```text
    Count: 0 (ideal)
    ```

###### User Experience

- Fun
  - **`Quantitative:`** Did the player ask to continue the game?

    ```text
    Boolean: Yes (ideal)
    ```
  - `Qualitative:` Would the player continue play if we made more content?
- Sense of urgency

  - `Qualitative:` Did the player feel time pressure to finish the prototype?
- Satisfaction

  - `Qualitative:` How do you feel after completing the prototype?
  - `Qualitative:` Do you feel satisfied?
- Sensation

  - `Qualitative:` How well were you immersed in the game?
- Challenge

  - `Qualitative:` Do you think the gameplay is challenging?
- Expression

  <!-- todo: revisit this question and maybe rephrase? -->

  - `Qualitative:` Do you feel like you needed to think about your choices?
- Sense of agency (influence)

  - `Qualitative:` Did you feel like you were doing math or playing a game?
  - `Qualitative:` How/What made you think you were (not) doing math?

###### Didactic Efficacy

- Learning objectives alignment

  - `Qualitative:` Does the player know which mathematical concepts were in the game?
- Assessment of knowledge acquisition:

  - **`Quantitative:`** Is the player able to finish each segment within a set amount of time?

    ```text
    Initial punch: time

    Second arc: time

    Full punch: time
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Engagement with educational content

  - `Qualitative:` Would the player continue playing the game?

- Expression

  - `Qualitative:` Would you play this game to improve your math abilities?

###### Game Flow

- Complete concentration on the task

  - **`Quantitative:`** How many times would the players let themselves be interrupted / distracted?

    ```text
    Count: 0 (ideal)
    ```
- Clarity of goals

  - **`Quantitative:`** How many times did the players ask questions?

    ```text
    Count: 0 (ideal)
    ```
- Effortlessness and ease

  - **`Quantitative:`** Are the players able to finish each segment within a set amount of tries?

    ```text
    Hitting a weakspot: 1

    Defeating a kaiju: 3
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Balance between challenge and skills

  - **`Quantitative:`** Did the player make a remark about the difficulty of the game during gameplay (i.e. too easy/difficult)?

    ```text
    Boolean: No (ideal)
    ```
  - `Qualitative:` Does the player feel like the game was too challenging or too easy and can they explain why?

### User Test Data Model

#### General

##### Age

> Current age of the test subject

##### Curriculum

> Current/past study level

- [ ] VWO
- [ ] HAVO

##### Math level

> Current/past math level

- [ ] D
- [ ] B
- [ ] A
- [ ] C

##### Math proficiency

> Self-indication of the test subject regarding their math skills

- [ ] Very good
- [ ] Decent
- [ ] Not that good

#### Environment

##### Location

> Current location of where the test is performed

##### Operating System

> The operating system the test is performed on

##### Game Build Version

> Current build and/or version of the prototype

#### Data

##### During the Game

###### Game Phases 

1. Start off the game

    - How many clicks does the player require to get into the game?

        - [ ] 0 times
        - [ ] 1 to 3 times
        - [ ] 3 or more

2. Start of the game

   - How many seconds does it take the player to figure out the control scheme?

        - [ ] 5 seconds or less
        - [ ] 5 to 10 seconds
        - [ ] 10 seconds or more

3. End the game

   - Is the players able to finish each part of the game loop within a set amount of time?

        - [ ] Yes
        - [ ] No

    ```text
    Initial punch:

    Second arc:

    Full punch:

    Hitting a weakpoint:

    Hitting all weakpoints:
    ```

   - Did the player ask to play again?

        - [ ] Yes
        - [ ] No

###### Observations

- How many times does the player ask the test supervisor how the UI works?

    - [ ] 0 times
    - [ ] 1 to 3 times
    - [ ] 3 or more
- Did the player make a remark about the difficulty of the game (i.e. too easy/difficult)?

    - [ ] Yes
    - [ ] No
- Can the player properly place down the first track within their first 2 tries?

    - [ ] Yes
    - [ ] No
- How many times would the players let themselves be interrupted / distracted?

    - [ ] 0 times
    - [ ] 1 to 3 times
    - [ ] 3 or more
- How many times did the players ask questions?

    - [ ] 0 times
    - [ ] 1 to 3 times
    - [ ] 3 or more

###### Bugs

- How many bugs did the player run into?

    - [ ] 0 
    - [ ] 1 to 3 
    - [ ] 3 or more
- Did it hinder gameplay?

    - [ ] Yes
    - [ ] No
- Give a quick description of the bug(s) encountered

    ```text



    ```

##### Interview Afterwards

- Would you continue to play if you could?

    - [ ] Yes
    - [ ] No

- _If no: Do you think you would continue playing if we made more content?_

```text



```

- How do you feel after completing the game?

> Make sure to ask why

```text



```

- Do you feel satisfied?

> Make sure to ask why

```text



```

- Did you feel time pressure to finish the game?

> Make sure to ask why

```text



```

- Do you think the gameplay is challenging?

> Make sure to ask why

```text



```

- Do you know which mathematical concepts were in the game?

> Make sure to ask why

```text



```

- Would you play this game to improve your math abilities?

> Make sure to ask why

```text



```

## Concept 5: Architect of Goo

### User Test Plan

User Test Plan Template: `v1.2`

#### Context

##### Concept

In Architect of Goo the player is presented with the challenge of solving puzzles to reach their way out. These puzzles have to be solved by creating bridges using diverse representations of mathematical problems, which use lineair equations. The game has been inspired by many games including titles such as: *Super Mario Bros.*, *Slime rancher* and *Bridge builder*. It aims to teach the player about linear equations in a fun and engaging way.

The design of the games has been evaluated based on our evaluation process. This has presented us with the following strengths and weaknesses.

###### Strengths

- The game concept is easy to scale, it allows for future expansion in both game content and mathematical content.
- It is very flexible, enabling teachers to create custom levels to align with their curriculum.
- The game is designed to be fun first, and effectively introduces/incorporates educational content and making learning more enjoyable.
- The game is easy to replay and allows for a lot of trial and error, making it a good fit for learning mathematics.

###### Weaknesses

- The game could be challenging for students who are not familiar with the mathematical concepts it incorporates.
- Students who do not enjoy games or are not experienced gamers might find the game less engaging, reducing its effectiveness as a learning tool outside the classroom.
- The current and future progression of the game lacks a bit of clarity on the gradual introduction of new skills, levels, and worlds.
- Some players might find it difficult to grasp the complex mechanics required to solve the puzzles, especially if they are trying to understand the underlying math concepts at the same time.
- The heavy focus on math skills might overshadow other aspects of the game, such as platforming skills, which could enhance the overall gaming experience.
- The interaction between the mathematical mechanics and the gameplay mechanics do not mesh that well as off now (, i.e. why can the slime walk/jump if that is not used whilst progressing in the game). This can potentially make the game feel like a test environment.

##### Goals

Based on the game design pillars mentioned in the Game Design Document (GDD), the core values of our client and the identified weaknesses we want to test the following:

- `Creativity`: Does the player feel challenged to think of a new solution / course of action?
- `Variety`: Is the player satisfied with the diversity of options this game offers?
- `Discovery`: Can the player satiate their curiosity to discover new possibilities (by trial and error)?
- `Challenge`: Is the challenge presented by the game within the means of the player, i.e. is it doable and not too easy or difficult?
- `Player experience/Fun`: is the player experience satisfactory enough that they would like to continue this experience?

##### Hypotheses

As a team we believe that the game will bring forth a positive experience for the player. The player will enjoy the game play, and deepen their understanding about lineair equations. On top of that the player will be able to understand the link between the solution they enter and the output in the game. They will be able to finish each stage, and level within a set amount of tries (deaths).

#### Design

##### Participants

Both guerilla testers and our target audience will be the participants for this test.

###### Guerilla Testers

This group of testers is more focused on the actual gameplay of the prototype. Guerilla testers are students from the HvA with varying ages, curriculums and level of math proficiency.

###### Target Audience

The target audience for *Architect of Goo* are students from VWO & HAVO level currently studying mathematics. The math curriculum (A, B, C or D) they follow will be varying, as well as their level of proficiency in the subject matter and their age. On top of that due to the voluntary nature of the test some students might be more familiar with games in general.

##### Methods

For this user test we have decided to use the following methods:

- Observation of the player during the game
- Interview with the player after the game

In order to achieve this we will require the following:

- Build of the game
- Laptop or desktop
- Mouse (input to play the game)
- Stopwatch
- Data collection form

##### Metrics & Benchmarks

###### Functionality

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

###### Accessibility

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

###### User Experience

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

###### Didactic Efficacy

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

    - `Qualitative:` Would you play this game / concept to improve your math abilities?

###### Game Flow

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

### User Test Data Model

User Test Data Model Template: `v1.4`

#### General

> General information on the participant (e.g. age, study level, etc.) based on the test plan

##### Age

> Current age of the test subject

```text


```

##### Curriculum

> Current/past study level

- [ ] VWO
- [ ] HAVO

##### Math level

> Current/past math level

- [ ] D
- [ ] B
- [ ] A
- [ ] C

##### Math proficiency

> Self-indication of the test subject regarding their math skills

- [ ] Very good
- [ ] Decent
- [ ] Not that good

#### Environment

> Information on the test environment (e.g. location, operating system, etc.) based on the test plan

```text


```

##### Location

> Current location of where the test is performed

```text


```

##### Operating System

> The operating system the test is performed on

```text


```

##### Game Build Version

> Current build and/or version of the prototype

```text


```

#### Data

> The to be collected metric data based on the test plan, logically organized by situation/time of collection

##### During the Game

###### Game Phases

> Describe for each stage what metrics the testers should keep in mind.

1. Start off the game
2. Start of the level

- How many seconds does it take the player to figure out the control scheme?

  - [ ] 0 to 5
  - [ ] 5 to 15
  - [ ] 15 or more

  1. End of the stage

  - How many tries did it take the player to finish the stage to 100%?

    - 1
    - 1 to 2
    - 2 or more

    ```text

    Stage 1: 


    Stage 2: 


    Stage 3: 

    ```

3. End of the level

- Is the players able to finish the level within a set amount of deaths per stage?

  - [ ] Yes
  - [ ] No

  ```text

  Stage 1: 


  Stage 2: 


  Stage 3: 

  ```

  - Are the players able to finish the level within a set amount of tries?

    - [ ] Yes
    - [ ] No

  ```text

  Prototype level: 

  ```
- How many times did the player finish the stage in one try?

  - [ ] 1
  - [ ] 2
  - [ ] 3

4. End of game

- Did the player ask to continue the game?

  - [ ] Yes
  - [ ] No

###### Observations

- How many times did the players ask questions?

  - [ ] 0
  - [ ] 1
  - [ ] 1 or more
- How many times does the player ask the test supervisor how the UI works?

  - [ ] 0
  - [ ] 1
  - [ ] 1 or more

  - Did the player make a remark about the difficulty of the game (i.e. too easy/difficult)?

  - [ ] Yes
  - [ ] No

-_If yes what did they say?_

```text




```

###### Bugs

- How many bugs did the player run into?

  - [ ] 0
  - [ ] 1 to 3
  - [ ] 3 or more
- Did it hinder gameplay?

  - [ ] Yes
  - [ ] No
- Give a quick description of the bug(s) encountered.

  ```text




  ```

##### Interview Afterwards

- Would you continue to play if you could?

  - [ ] Yes
  - [ ] No

-_If no: Do you think you would continue playing if we made more content?_

```text




```

- How do you feel after completing the game (sensation)?

  > Make sure to ask why
  >

  ```text




  ```
- Do you feel satisfied?

  > Make sure to ask why
  >

  ```text




  ```
- Do you think the gameplay is challenging?

  > Make sure to ask why
  >

  ```text




  ```
- Did you feel like you were doing math or playing a game?

  - [ ] Doing math
  - [ ] Playing a game

  > Make sure to ask why/what made them think they were (not) doing math?
  >

  ```text




  ```
- Would you play this game to improve your math abilities?

  > Make sure to ask why
  >

  ```text




  ```
