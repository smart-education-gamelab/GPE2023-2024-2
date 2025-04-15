# User Testing: Benchmarks & Metrics

This document contains a deeper exploration of the themes and questions that we would like to explore through user testing.

> ⚠️ Metrics & benchmarks are approximated and need to be translated to the correct format for said concept's `User Test Plan` ⚠️

## Structure & Key Definitions

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

To analyse our data, we are using the methodology as laid out in `03 Data Collection & Analysis`.

## Thematic Design Aspects

### Functionality

Functionality refers to the capability of the system, software, device, or game to perform its intended tasks or operations. It encompasses the features, abilities, and behaviours that allow users to achieve their goals.

#### Subjects

- Unintended Behaviour
- Goal Hindrance

#### Metrics & Benchmarks

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

Accessibility refers to the extent in which individuals with diverse abilities can effectively interact with and enjoy the game.

#### Subjects

For accessibility, we are focusing on the specific areas of:

- Control Clarity
- Text readability
- UI clarity and simplicity
- Feedback

#### Metrics & Benchmarks

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

---

### User Experience

User experience (UX) encompasses all aspects of an individual's interaction with a product, service, or system, including the interface, graphics, industrial design, physical interaction, and the overall experience. It focuses on meeting the user's needs and providing them with a positive and enjoyable experience.

#### Subjects

Within the context of game design, we are focusing on the following areas:

- Fun
- Satisfaction
- Sensation
- Challenge
- Expression
- Submission
- Sense of urgency
- Sense of agency (influence)
- Error prevention and recovery

These subjects have been based on the information in the following documents: [MDA: A Formal Approach to Game Design and Game Research](../../External/MDA_A_Formal_Approach_to_Game_Design_and_Game_Rese.pdf) and [01 Conceptual Exploration &amp; Core Values](../01%20Conceptual%20Exploration%20&%20Core%20Values.md).

Since fun and user experience is hard to define, we acknowledge that the subjects might not be as accurate as we would like them to be and should be treated with nuance.

#### Metrics & Benchmarks

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

  <!-- todo: revisit this question and maybe rephrase? -->

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

---

### Didactic Efficacy

Didactic efficacy refers to the advancement and development of knowledge, skills, and capabilities over time within an educational context. It includes the growth and improvement that individuals experience as they play the game.

In our case, it refers to the player's ability to learn, understand and apply the mathematical concepts of linear equations.

#### Subjects

We have identified the following key areas to focus on:

- Learning objectives alignment
- Assessment of knowledge acquisition
- Engagement with educational content
- Tutorial and guidance options
- Expression

These subjects are based on the [GPE Design Brief](../../External/Function%20Dungeon%20I/GPE%20Design%20Brief.pdf), [Learning goals and difficulty level](../../External/Function%20Dungeon%20I/Learning%20goals%20and%20difficulty%20level.pdf), and the [Original Paper](../../External/Function%20Dungeon%20I/Original%20Paper.pdf) documents provided by our client.

#### Metrics & Benchmarks

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

---

### Game Flow

Game flow refers to the seamless and engaging progression of gameplay experienced by the player throughout their interaction with a game. It encompasses the pacing, rhythm, and overall structure of the game experience, ensuring that players remain immersed, motivated, and challenged as they navigate through different levels or stages[^1].

#### Subjects

For game flow, we are focusing on the following areas:

- Complete concentration on the task
- Clarity of goals
- Effortlessness and ease
- Balance between challenge and skills

#### Metrics & Benchmarks

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

[^1]: H. Bradshaw, "Gameplay Flow – Designing for Player Immersion," *Game Developer*, May 25, 2016. https://www.gamedeveloper.com/design/gameplay-flow-designing-for-player-immersion (accessed May 16, 2024)
