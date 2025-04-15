# Myth Digger: User Test Plan

`v1.2`

## Context

### Concept

The player is someone who intends to find the supposed answer to the dying planet under the crust. Doing so will require the gathering of materials so they can craft tools necessary to dig further and be able to find the answers you're looking for. Building rails, processing ores, and using them in crafting allows you to progress through the game by digging deeper each time.
The game has a side view and the depths are dark. The light source is glowing gems that you can mine and use motes of to light up the path you're mining.

##### Strengths
- Strong emphasis on entertainment and weaving the mathematics into the core of the gameplay allowing for an experience focused on fun.
- Scalability and authorability considered in the original concept.
- The feel of a game, rather than a 'math game'.

##### Weaknesses
- Possibility of disconnect between mathematics and the narrative, feeling more like a test environment than a teaching game.
- The player might be confused as to what to do due to lack of guidance or visible progress.
- Scope and size make the game less suitable for in-class use and more as an extracurricular activity.

---

### Goals

Entertainment first was a large client value, and this concept was made with that specifically in mind. Although the mathematics are intertwined with the gameplay loop, the initial core of the mechanics was considered separately. The risk this has led to is a potential disconnect between the idea of a learning game and a game as a challenge, causing the game to feel more like a test environment rather than a game that teaches these skills on their own. This test is to determine whether this is the case with this concept and if an approach to concepts in this fashion would be feasible for future iterations of this particular concept, or new concepts made for the client.

Additionally, this test serves as a general point to find out whether the core of the game is enjoyable to play. A game intended to entertain first and foremost that is not entertaining fails to reach its own goals. This test will help identify key issues that can be resolved in later iterations. 

As a final point, this test will also show the accessibility of its current design in both UI and general game progression. Bottlenecks can be spotted and adjusted based on the feedback from the participants.

---

### Hypotheses

Because the game has been designed with fun in mind, we expect that the player finds the mechanics enjoyable to interact with, pulling them in for further exploration. Unfortunately, as it is only a prototype to a proof of concept, aspects of the final gameplay are lacking, which makes this compared to its entire design not a fully reliable test as a vertical slice would. It does, however, provide insight to the core mechanics and the core loop.

We believe that with how the game pacing is laid out, the game is accessible and understandable for the player to step into and grasp both the mechanics, but also the mathematics within those. 

Expected feedback is that laying down the tracks is tedious and takes too much time. This is based on previous tests with other concepts, revealing actions to be repetitive without that being a consideration by the designer originally. Additionally, the fact this game is only a prototype so far can be another issue with pacing; we do expect the player to wander around rather aimlessly in the beginning due to lack of initial guidance.

## Design

### Participants

#### Guerilla testers

Basically anyone we can find that are willing to test the game. The intent of this type of test is to find out if the game works on a general level, but also to measure the immediate experience of fun. This group will have a wide variety of ages, even outside of the original target group, as well as highly variant mathematic skills.

##### Ideal Test Environment

The ideal location for testing is somewhere void of outside influences. Try to sit down with the tester in a place where there isn't much noise and as little other people as possible. We want test results to be as clean as can be, for that to happen we provide the tester with an environment that allows them to focus on the game.

The operating system the game is running on should remain consistent in order to reduce the potential for bugs caused by variants in OS use (eg. MacOS and Windows). We aim to use machines that run Windows 10 and 11 for this reason.

---

#### Target Users
Target users are the group the game was designed for; students of VWO level education aged 12-16 with any level of mathematic skills, but also a wide range of experience in games. The general expectation is that all are familiar with linear equations to some degree. However, this group's participation is based largely on voluntary basis, which does mean we might see students with more experience and affinity for games in general.

##### Ideal Test Environment

The target demographic is 12 - 16 year olds. It's hard to get a hold of them for us as we would have to rely on sibblings, nephews nieces. This is why we are looking to approach high schools to test our game. Therefor the test environment will be located within the school. The conditions will be similar to the guerilla testers; location with as little outside influences as possible. Try to secure a separate classroom for testing and ideally don't have multiple testers in the room. We want to avoid the testers communicating with each other because it might influence their mood and view of the game. 

The operating system the game is running on should remain consistent in order to reduce the potential for bugs caused by variants in OS use (eg. MacOS and Windows). We aim to use machines that run Windows 10 and 11 for this reason.

### Methods

##### Observation
The foremost concern is observing for actions of interest by the tester. As the observer, we need to cover the qualitative metrics. We also need to take note of aspects that aren't in the form like body language and the spoken words by the tester.

##### Interview
After the tester has played the prototype, they will be interviewed on a few key points that are outlined under the section Metrics and Benchmarks. Their opinions are distilled to some primary words that will be placed in a wordcloud to give us a fast indication of the overal feeling and opinion, and allows us to identify the general consensus.

##### Required Tools
- Laptop + charger
- Prototype build on test machine
- Stopwatch
- Separate laptop with a text editing program for notetaking, OR
- Pen and paper for notetaking

Latter depends on overal setup and available machines.

### Metrics & Benchmarks

#### Functionality

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

#### Accessibility

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

#### User Experience

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

---

#### Didactic Efficacy

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

---

#### Game Flow

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
