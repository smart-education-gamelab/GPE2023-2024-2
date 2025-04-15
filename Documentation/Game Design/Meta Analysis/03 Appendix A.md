# Appendix A: Design Process Overview

This document provides an overview of the design process used in the project, including the phases, products, and templates used.

<!-- TOC -->

- [I. Phases & Products](#i-phases--products)
    - [A. Concept](#a-concept)
    - [B. Design](#b-design)
    - [C. Implementation](#c-implementation)
    - [D. Test](#d-test)
- [II. Templates](#ii-templates)
    - [A. [Title]: Game Design Document GDD](#a-title-game-design-document-gdd)
        - [Concept](#concept)
        - [Design](#design)
        - [Implementation](#implementation)
    - [B. [Title]: Design Evaluation Document DED](#b-title-design-evaluation-document-ded)
        - [Core Ideas and Values](#core-ideas-and-values)
        - [Game Lenses](#game-lenses)
        - [Dynamics & Aesthetics](#dynamics--aesthetics)
    - [C. [Title]: User Test Plan UTP](#c-title-user-test-plan-utp)
        - [Context](#context)
        - [Design](#design)
    - [D. [Title]: User Test Data Model UTDM](#d-title-user-test-data-model-utdm)
        - [General](#general)
        - [Environment](#environment)
        - [Data](#data)
    - [E. [Title]: User Test Report UTR](#e-title-user-test-report-utr)
        - [Context](#context)
        - [Analysis](#analysis)
        - [Conclusion](#conclusion)
        - [Recommendations](#recommendations)

<!-- /TOC -->

## I. Phases & Products

### A. Concept

The concept phase focuses on defining the game's goal and emotional core with a player-centric mindset. It provides clarity on the game's purpose and how it will engage the target audience. The products of this phase are:

- `Visual Board of the Design Goal & Pillars Workshop`: A timestamped visual workspace from the workshop.
- `Concept Chapter of GDD`:  A written outline of the design goal and pillars, see the GDD template for more information.

### B. Design

The design phase details how the game will achieve its goal and pillars, approached with a game-centric mindset. The products are:

- `Visual Board of the Design Workshop`: A timestamped visual workspace with mind-maps, game loop flow charts, onion diagrams, storyboards, etc.
- `Design Chapter of GDD`: A finalised written version of the visual board's ideas, see the GDD template for more information.

### C. Implementation

This phase focuses on the explicit functional and audio-visual requirements for the game's implementation. During this phase the game's development is started. The products are:

- `Visual Board of the Implementation Plan Workshop`: A visual workspace from the workshop.
- `Implementation Chapter of GDD`: A written version of the visual board's finalised ideas, see the GDD template for more information.
- `Game Prototype`: A playable version of the core gameplay.

### D. Test

The test phase evaluates the game design against predefined criteria through heuristic evaluation and user testing. The heuristic evaluation assesses the game's design quality, while user testing provides feedback on the game's usability and effectiveness. Between the heuristic evaluation and user testing, the game is still in development and can be iterated upon.

The products are:

- `Design Evaluation Document (DED)`: A report evaluating the game design, see the DED template for more information.
- `User Test Plan (UTP)`: A plan for testing the game prototype, see the UTP template for more information.
- `User Test Data Model (UTDM)`: A model for collecting the user test data, see the UTDM template for more information.
- `User Test Report (UTR)`: A report evaluating the user test results, see the UTR template for more information.

## II. Templates

### A. [Title]: Game Design Document (GDD)

`v2.3`

#### Concept

##### Mission

> Within one or two sentences describe in abstract terms what (action, feeling, gameplay) the game should achieve, the core of the game.

##### Design Pillars

> Choose words that fit the emotional core of the game and describe them as if you are currently experiencing them during gameplay.

##### Aesthetics

> The types of fun we want to achieve with our design.

#### Design

##### Mechanics

###### Core Mechanics

> Most used mechanics in the game, are always performed by the player.

###### Secondary Mechanics

> Supporting mechanics that are used less frequently.

##### Dynamics

> *What are the game dynamics?*

> Place the mechanics into the game's conceptual context and argue if they evoke the correct aesthetics

##### Math Didactics

###### Learning Goals

> *Which goals are approached with the (current) design?*

###### Implementation

> *How is it combined/achieved with the mechanics?*

##### Economy

> Describe what the player can collect and use in the game.

###### Resources

> Resources are things the player can produce or has in the game with a specific purpose. E.g. wood, tools, food, health, etc.

> *What are the resources in the game?*

> What are the resources that the player can collect and use?

###### Currencies

> Currencies are things the player can generate and use in the game to buy or sell things (it has a self influencing feedback loop). E.g. gold, money, skill points, etc.

> *Which currencies are in the game?*

> What are the currencies that the player can collect and use?

###### Consumables

> Consumables are things the player can collect and use once. E.g. potions, scrolls, etc.

> *What are the consumables in the game?*

> What are the consumables that the player can collect and use?

##### Progression

> *How does the game progress?*

> How does the game start? How does the game evolve over time? What is the player's journey?

##### Loops

> *What are the loops of the game?*

###### Game Loop

> What are the short-term, medium-term, and long-term loops? What are the effects of the actions of the player

###### Feedback Loops

> What are the positive and negative influences of the mechanics upon each other?

#### Implementation

##### Target Platform

> Describe the target platform of the game, e.g. mobile, desktop, mobile-web, desktop-web etc.

##### Camera

> Describe the camera view and how it should behave.

##### Controls

> Describe the controls of the game, e.g. keyboard, mouse, touch, etc.

##### User Interface

> Describe the different interfaces like the main menu, settings, HUD, etc.

##### Game Objects

> Describe the different game objects in the game, their purpose and how they interact with the player.

##### Polish

> Describe the different polish elements in the game, e.g. particles, animations, etc.

##### Story

> Describe the concept of the story of the game.

##### Sound

> Describe the sound design of the game, what feelings should the player have when hearing the sounds?

##### Art

> Describe the art style of the game, what feelings should the player have when seeing the art?

---

### B. [Title]: Design Evaluation Document (DED)

`v3.0`

#### Core Ideas and Values

##### Serious Games

> *Does it align with what the team defined as a serious game? Why? How?*

##### Content

###### Learning Content

> *Does the game incorporate learning content properly? Why? How?*

###### Game Content

> *How does the game include narrative, art, sound and further game and or level design?*

##### Scalability

> *How does the scalability show in this game? Can the concept be applied to multiple Learning Goals? Does the content and duration of the game allow to be expand upon in the future?*

##### Adaptability

> *Does it align with how the team defined adaptability? Is it an adaptable game? How? Why?*

##### Difficulty

###### Game Difficulty

> *Does the game difficulty align with what the team defined? How? Why?*

###### Mathematics Difficulty

> *Does the mathematics difficulty align with what the team defined? How? Why?*

##### Accessibility

> *Is the game accessible as defined by the team? Why? How?*

##### Core Values

###### Client Design Values

> *Does the game align with the client design values? How? Why?*

###### Team Design Values

> *Does the game align with the team design values? How? Why?*

#### Game Lenses

##### Lens of Flow

> *Does my game have clear goals? If not, how can I fix that?*

> *Are the goals of the player the same goals I intended?*

> *Do parts of the game distract players so they forget their goal? If so, can these distractions be reduced, or tied into the game goals?*

> *Does my game provide a steady stream of gradually increasing challenges?*

> *Are the player's skills improving as expected? If not, how can I change that?*

##### Lens of Skill

> *What skills does my game require from the player?*

> *Are there categories of skill that this game is missing?*

> *Which skills are dominant?*

> *Are these skills creating the experience I want?*

> *Are some players much better at these skills than others?*

> *Does this make the game feel unfair?*

> *Can players improve their skills with practice?*

> *Does this game demand the right level of skill?*

##### Concept Dependent Lenses

> *Define which Game Lenses you are going to use. Choose 1 to 5 matching ones and answer all the questions clear and concise*

> *Are we able to answer them? Does it give a clear view about the game and gameplay?*

#### Dynamics & Aesthetics

> *Are the proposed aesthetics achieved with the current mechanics? Do the dynamics support the aesthetics? Do you agree with the proposed explanation in the GDD?* 

---

### C. [Title]: User Test Plan (UTP)

`v1.2`

#### Context

##### Concept

> Write a short description of the concept

> What do we assume are its strengths and weaknesses based on our design evaluation?

##### Goals

> Which goals are we trying to achieve with this test based on our concept (use for example the identified weaknesses, client values, etc.)?

##### Hypotheses

> Which results do we expect from the test?

#### Design

##### Participants

> Describe the different types of participants (e.g. guerilla testers, target users, etc.) and their expected characteristics

##### Methods

> Which methods (e.g. observation, interview, survey, etc.) & tools (build of the game, stopwatch, pen & paper, etc.) are needed to perform the test?

##### Metrics & Benchmarks

> Which metrics & benchmarks will we be using to achieve the test goals (use 02 benchmarks & metrics for this)?

---

### D. [Title]: User Test Data Model (UTDM)

`v1.4`

#### General

> General information on the participant (e.g. age, study level, etc.) based on the test plan

##### Age

> Current age of the test subject

##### Curriculum

> Current/past study level

> - [ ] VWO
> - [ ] HAVO

##### Math level

> Current/past math level

> - [ ] D
> - [ ] B
> - [ ] A
> - [ ] C

##### Math proficiency

> Self-indication of the test subject regarding their math skills

> - [ ] Very good
> - [ ] Decent
> - [ ] Not that good

#### Environment

> Information on the test environment (e.g. location, operating system, etc.) based on the test plan

##### Location

> Current location of where the test is performed

##### Operating System

> The operating system the test is performed on

##### Game Build Version

> Current build and/or version of the prototype

#### Data

> The to be collected metric data based on the test plan, logically organized by situation/time of collection

##### During the Game

###### Game Phases

> Describe for each stage what metrics the testers should keep in mind.

> 1. Start off the game

> 2. Start of the level

> 3. End the level

> 4. End of game

##### Observations

> Describe what needs to be kept in mind during the test in general

###### Bugs

> - How many bugs did the player run into?

>   - [ ] 0
>   - [ ] 1 to 3
>   - [ ] 3 or more

> - Did it hinder gameplay?

>   - [ ] Yes
>   - [ ] No

> - Give a quick description of the bug(s) encountered

  ```text



  ```

##### Interview Afterwards

> Describe each metric and benchmark that need to be answered.

> Use either checkboxes, textboxes to show how these need to be filled in on the form.

---

### E. [Title]: User Test Report (UTR)

`v1.2`

#### Context

##### Concept

> Write a short description of the concept

##### Hypotheses

> Reiterate the hypotheses from the test plan

#### Analysis

> Describe & summarise the key findings per subject based on the test plan and `03 Data Collection & Analysis`

#### Conclusion

> Summarise the key findings from the test

#### Recommendations

> Provide recommendations based on the findings

---