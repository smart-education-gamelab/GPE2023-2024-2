# Architect of Goo: User Test Data Model

User Test Data Model Template: `v1.4`

## General

> General information on the participant (e.g. age, study level, etc.) based on the test plan

### Age

> Current age of the test subject

```text


```

### Curriculum

> Current/past study level

- [ ] VWO
- [ ] HAVO

### Math level

> Current/past math level

- [ ] D
- [ ] B
- [ ] A
- [ ] C

### Math proficiency

> Self-indication of the test subject regarding their math skills

- [ ] Very good
- [ ] Decent
- [ ] Not that good

## Environment

> Information on the test environment (e.g. location, operating system, etc.) based on the test plan

```text


```

### Location

> Current location of where the test is performed

```text


```

### Operating System

> The operating system the test is performed on

```text


```

### Game Build Version

> Current build and/or version of the prototype

```text


```

## Data

> The to be collected metric data based on the test plan, logically organized by situation/time of collection

### During the Game

#### Game Phases

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

#### Observations

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

#### Bugs

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

### Interview Afterwards

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
