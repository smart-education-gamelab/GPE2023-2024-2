# Muschroom of BLOOM: User Test Report

`v1.2`

## Context

### Concept

Mushroom of BLOOM is a kind of tower defence game where the player places towers to defend their kingdom from the enemy, infected mushrooms called Bloomers. The player can place the towers alongside the enemies pathway and aim different types ammunition from towers using linear functions or coordinates. Before each wave the player has the ability to place the towers, upgrade, repair or buy new ones and aim their muzzles in his liking to defend his towers and in extension the kingdom.

### Hypotheses

We believe that the player will have a good experience with an engaging interaction. They will learn in a playful way how linear functions work. The player will be able to understand the link between how a function looks as a graph and how the formula for this specific function looks like and how they interact.

## Analysis


### Functionality

- Unintended Behaviour
    > During the playtest, several bugs hindered the gameplay experience. One major issue was that if the tester failed, the game would crash. When placing a new tower, the variables from the old tower placement persisted, causing unintended behaviors. Additionally, if the tester died, the game would crash, further disrupting the experience. Another problem was the flower value, which snapped back to 30 after some rounds. Enemies sometimes didn't attack towers as expected, leading to inconsistent gameplay. Finally, the game was not balanced which making it difficult to achieve a fair and enjoyable experience for the testers.

- Goal Hindrance
    > 75% of the testers were hindred by this bug as they had to restart the whole game if they messed up once

### Accessibility

- Control Clarity
    > All testers were able to figure out the controls, but sometimes it took a little bit longer. It is not really clear that if you click a button you can place a tower and where you can actually place a tower. Players were unsure about if it was drag or drop. We also observed some unclarity when adjusting the formula / ccoordinates of a shooting / bomb tower. Players thought they could move the line / point or wanted to click a point to set the bomb. Also players immediately touched confirm on the equation setter for the shooting tower.

- Feedback 
    > During 50% of the tests we saw players repeating the same mistake. The most common mistake was not figuring out how to place a tower and when figured out trying again. 

### User Experience

- Fun
    > 75% of the testers did not want to continue playing the game. Their reasons were: The game needs to be more balanced, the UX made it very frustrating to play and needs to be improved to indicate what you're supposed to do, the mechanics were the issue, not the content and there needs to be more variety in enemy and tower

- Challenge
    > 37.5% of the testers thought the gameplay was challeging enough in its current state. 37.5% of the testers thought that the game is unbalanced but because of that it is challenging. the other 25% of testers thought the game was not challenging because of either bugs or because it was not clear what to do.

- Error prevention and recovery
    > 2 players finished level 1 wave 2 in 1 time. The other testers either did it in more tries or did not finish the wave.


### Didactic Efficacy

- Learning objectives alignment
    > Every tester could at least tell one mathematicla concept which is in the game. Things we heard were graphs, linear equations, linear algebra, coordinates, formula on graphs, angles, coordinate system and trajectory. All those concepts are displayed in this concept.

- Assessment of knowledge acquisition
    > The results varied when measuring the time of completion. For Level 1, Wave 1, no one could finish within a minute. For Level 1, Wave 2, only a small amount of testers managed to finish within 40 seconds. This can be because they placed most towers somewhere at the middle of the level, causing them to wait for longer then is needed.


- Engagement with educational content
    > Even when given the possibilty, none of the testers wanted to continue the game, as it was still in it's early development and didn't have much variety.
    

- Expression
   > When asked if they would play this game or concept to improve their math abilities, the feedback was mixed. Three testers felt the game seemed far removed from math, noting that you just move a line and could simply type in values instead. Two testers gave a straightforward "no." One tester said "no" because the graphs were not readable. Another tester responded with "sort of," and one tester thought it could work.

### Game Flow

- Complete concentration on the task
    > Most testers attention was wavering during the time their towers were destroyed and they had to wait for them to lose. Making it quite a punishement when failing a wave. But besides that there their attention was fixated on the game.

- Clarity of goals
    > Most testers it was clear what the goal was. This could presumably be as they've had prior experience with similair tower defence game. This is merely an observation and might not reflect reality.

- Effortlessness and ease
    > In the beginning the testers had difficulty understanding the gameplay, as it was not obvious how the towers worked in the initial wave. Afterwards they had less difficulty as they began to understand the gameplay through trail and error.

- Balance between challenge and skills
    > During gameplay, half of the testers made remarks about the game's difficulty without being promted to. Some players felt the level was too easy, explaining that the bomb tower made it trivial. Others found the game too challenging due to the user experience, which made it hard to understand what was happening. Additionally, the inconsistent movement of enemies, which allowed them to attack towers from a tile away, contributed to the difficulty.

## Conclusion

The user test of Mushroom of BLOOM revealed several key insights into the game's functionality, accessibility, user experience, didactic efficacy, and game flow. The test highlighted significant issues with the game's stability, as frequent crashes and unintended behaviors hindered the gameplay experience. Players encountered persistent bugs, such as variables from old tower placements affecting new ones and enemies not attacking as expected. These issues, combined with a lack of balance, led to a frustrating and inconsistent experience for most testers.

In terms of accessibility, while testers eventually figured out the controls, there was initial confusion about how to place towers and adjust their settings. The feedback mechanisms were insufficient, causing players to repeat the same mistakes without clear guidance on how to proceed. This negatively impacted their overall enjoyment and willingness to continue playing.

From a user experience perspective, a majority of testers found the game unappealing due to its imbalanced difficulty, unclear mechanics, and lack of variety in enemies and towers. Although some players appreciated the challenge, many were discouraged by the game's frustration-inducing elements.

Despite these issues, the game's educational potential was evident. Testers could identify mathematical concepts such as graphs, linear equations, and coordinates within the game. However, the current implementation did not effectively engage players with the educational content, and most testers did not see the game as a viable tool for improving math skills.

Overall, while Mushroom of BLOOM has a promising concept that blends tower defense gameplay with educational content, significant improvements are needed to enhance its stability, clarity, and engagement. Addressing the identified bugs, improving feedback mechanisms, balancing gameplay, and making tower placement more intuitive are crucial steps toward realizing the game's full potential.

## Recommendations

- Resolve bugs where the UI doesnt reflect the actual game state.
- Resolve crashes that happen when the enemy reaches the end of the level and when restarting the level.
- Improve feedbak mechanics by adding instant feedback
- Introduce more variety of enemies and towers to promote replayabilty
- Clarify controls of placing towers from the tower UI
- Balance gameplay by reevaluating enemy strength and tower capabilities to ensure a fair challenge.
- Improve the UI for placing towers by making it clear which tower is currently selected and where they can place them by highlighting the area.
