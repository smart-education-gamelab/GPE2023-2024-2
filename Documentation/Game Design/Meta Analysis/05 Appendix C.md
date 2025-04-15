# Appendix C: Generic Metrics & Benchmarks

This document outlines the generic metrics and benchmarks that can be used to evaluate the design aspects of the game prototype. 

## Table of Contents

<!-- TOC -->

- [I. Structure & Key Definitions](#i-structure--key-definitions)
- [II. Thematic Design Aspects](#ii-thematic-design-aspects)
    - [A. Functionality](#a-functionality)
        - [Subjects](#subjects)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [B. Accessibility](#b-accessibility)
        - [Subjects](#subjects)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [C. User Experience](#c-user-experience)
        - [Subjects](#subjects)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [D. Didactic Efficacy](#d-didactic-efficacy)
        - [Subjects](#subjects)
        - [Metrics & Benchmarks](#metrics--benchmarks)
    - [E. Game Flow](#e-game-flow)
        - [Subjects](#subjects)
        - [Metrics & Benchmarks](#metrics--benchmarks)

<!-- /TOC -->

## I. Structure & Key Definitions

The document is structured into five main sections, each focusing on a different aspect of design. These sections are:

1. Functionality
2. Accessibility
3. User Experience
4. Didactic Efficacy
5. Game Flow

These main sections are further divided into the subsections of subjects, metrics, and benchmarks:

- **Subjects:** Specific areas that we want to focus on within said design aspect.
- **Metrics:** Possible gauges or indicators that can be used to measure the subjects.
- **Benchmarks:** Thresholds or standards that can be used to evaluate quantitive metrics.

Metrics have been categorized into **`quantitative`** and `qualitative`:

- **`Quantitative:`** Are numerical and can be measured objectively.
- `Qualitative:` Are descriptive and require interpretation.

## II. Thematic Design Aspects

### A. Functionality

Functionality refers to the capability of the system, software, device, or game to perform its intended tasks or operations. It encompasses the features, abilities, and behaviours that allow users to achieve their goals.

#### 1. Subjects

- Unintended Behaviour
- Goal Hindrance

#### 2. Metrics & Benchmarks

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

### B. Accessibility

Accessibility refers to the extent in which individuals with diverse abilities can effectively interact with and enjoy the game.

#### 1. Subjects

For accessibility, we are focusing on the specific areas of:

- Control Clarity
- Text readability
- UI clarity and simplicity
- Feedback

#### 2. Metrics & Benchmarks

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

### C. User Experience

User experience (UX) encompasses all aspects of an individual's interaction with a product, service, or system, including the interface, graphics, industrial design, physical interaction, and the overall experience. It focuses on meeting the user's needs and providing them with a positive and enjoyable experience.

#### 1. Subjects

Within the context of game design, the focus is on the following areas:

- Fun
- Satisfaction
- Sensation
- Challenge
- Expression
- Submission
- Sense of urgency
- Sense of agency (influence)
- Error prevention and recovery

These subjects have been based on the information in the following documents: `MDA: A Formal Approach to Game Design and Game Research`[^1] and `01 Conceptual Exploration & Core Values`[^2]. Since fun and user experience is hard to define, it is acknowledged that the subjects might not be as accurate and they should be treated with nuance.

#### 2. Metrics & Benchmarks

- Fun

  - **`Quantitative:`** Did the player ask to continue the game?

    ```text
    Boolean: Yes (ideal)
    ```
  - `Qualitative:` Would the player continue play if we made more content?
- Sense of urgency

  - `Qualitative:` Did the player feel time pressure to finish the prototype / level / game?
- Satisfaction

  - `Qualitative:` How do you feel after completing the prototype / level / game?
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
- Error prevention and recovery

  - **`Quantitative:`** How many tries did it take the player to finish the concept (/level) to 100%?

    ```text
    Count: 1 (ideal)
    ```
  - **`Quantitative:`** How many times did the player finish the concept (/level) in one try?

    ```text
    Count: 1 (ideal)
    ```

### D. Didactic Efficacy

Didactic efficacy refers to the advancement and development of knowledge, skills, and capabilities over time within an educational context. It includes the growth and improvement that individuals experience as they play the game. In the context of this project, it refers to the player's ability to learn, understand and apply the mathematical concepts of linear equations.

#### 1. Subjects

We have identified the following key areas to focus on:

- Learning objectives alignment
- Assessment of knowledge acquisition
- Engagement with educational content
- Tutorial and guidance options
- Expression

These subjects are based on the `GPE Design Brief`[^3], `Learning goals and difficulty level`[^4], and the `Original Paper`[^5] documents provided by our client.

#### 2. Metrics & Benchmarks

- Learning objectives alignment

  - `Qualitative:` Does the player know which mathematical concepts were in the game?
- Assessment of knowledge acquisition:

  - **`Quantitative:`** Is the player able to finish the game / each level within a set amount of time?

    ```text
    Level 1:

    Level 2:
    ```

    ```text
    Boolean: Yes (ideal)
    ```
- Engagement with educational content

  - `Qualitative:` Would the player continue playing the game?
- Tutorial and guidance options

  - **`Quantitative:`** Is the player making use of the tutorials / math-content explanations offered by the game?

    ```text
    Boolean: Yes (ideal)
    ```
- Expression

  - `Qualitative:` Would you play this game / concept to improve your math abilities?

### E. Game Flow

Game flow refers to the seamless and engaging progression of gameplay experienced by the player throughout their interaction with a game. It encompasses the pacing, rhythm, and overall structure of the game experience, ensuring that players remain immersed, motivated, and challenged as they navigate through different levels or stages[^6].

#### 1. Subjects

For game flow, the focus is on the following areas:

- Complete concentration on the task
- Clarity of goals
- Effortlessness and ease
- Balance between challenge and skills

#### 2. Metrics & Benchmarks

- Complete concentration on the task

  - **`Quantitative:`** How many times would the players let themselves be interrupted / distracted?

    ```text
    Count: 0 (ideal)
    ```
- Clarity of goals

  - **`Quantitative:`** How many times did the players aks questions?

    ```text
    Count: 0 (ideal)
    ```
- Effortlessness and ease

  - **`Quantitative:`** Are the players able to finish each level / concept / game within a set amount of time / tries?

    ```text
    Level 1:

    Level 2:
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

[^1]: R. Hunicke, M. Leblanc, and R. Zubek, “MDA: A Formal Approach to Game Design and Game Research,” 2004. Available: https://users.cs.northwestern.edu/~hunicke/MDA.pdf

[^2]: Team Burning Equations, "01 Conceptual Exploration & Core Values", May 8, 2024.

[^3]: Smart Education Lab, "GPE Design Brief", Version 11, April 2024.

[^4]: Smart Education Lab, "Learning goals and difficulty level", Version 12, April 2024. 

[^5]: Smart Education Lab, "Original Paper", June 7-10, 2023.

[^6]: H. Bradshaw, "Gameplay Flow – Designing for Player Immersion," *Game Developer*, May 25, 2016. https://www.gamedeveloper.com/design/gameplay-flow-designing-for-player-immersion
