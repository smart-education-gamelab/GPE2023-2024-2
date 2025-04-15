# Myth Digger: User Test Report

## Context

### Concept

The player is someone who intends to find the supposed answer to the dying planet under the crust. Doing so will require the gathering of materials so they can craft tools necessary to dig further and be able to find the answers you're looking for. Building rails, processing ores, and using them in crafting allows you to progress through the game by digging deeper each time.
The game has a side view and the depths are dark. The light source is glowing gems that you can mine and use motes of to light up the path you're mining.

### Hypotheses

Because the game has been designed with fun in mind, we expect that the player finds the mechanics enjoyable to interact with, pulling them in for further exploration. Unfortunately, as it is only a prototype to a proof of concept, aspects of the final gameplay are lacking, which makes this compared to its entire design not a fully reliable test as a vertical slice would. It does, however, provide insight to the core mechanics and the core loop.

We believe that with how the game pacing is laid out, the game is accessible and understandable for the player to step into and grasp both the mechanics, but also the mathematics within those. 

Expected feedback is that laying down the tracks is tedious and takes too much time. This is based on previous tests with other concepts, revealing actions to be repetitive without that being a consideration by the designer originally. Additionally, the fact this game is only a prototype so far can be another issue with pacing; we do expect the player to wander around rather aimlessly in the beginning due to lack of initial guidance.

## Analysis

> Describe & summarise the key findings per subject based on the test plan and `03 Data Collection & Analysis`

### Functionality

- Unintended Behaviour
> During playtesting, there were some bugs that did hinder playtesting. Particularly two instances of crashes that ended playtesting entirely, closing out of the game and erasing all progress. Other issues were that the rail track did not have to align at the end of the tunnel and game progression was not reset properly returning to the main menu. A minor issue of being able to jump infinitely in the mineshaft also came up.

- Goal Hindrance
> The two crashes are obvious detriments to the experience and the playtesting overal, completely interrupting progress and being unable to finish the playtests. The bug of the progression not being reset also caused issues during the playtest progression, effectively cutting off one area of the game to be tested.
> The lack of track alignment and the infinite jumping glitches would be issues in an isolated context - for the playtest, however, the authors could direct the tester to progress normally.

### Accessibility

- Control Clarity
> Unilaterally, all testers were able to figure out the control scheme within 10 seconds. Only in the railtrack placing was some confusion; the lack of the popup on R later on in the tunnel made some testers not realize they had to continue pressing R and place more tracks. 

- UI clarity and simplicity
> Reading the popups on locked areas was enough for players to continue exploring and try to find out what the game wanted them to do instead. Some lack of clarity appeared during the crafting sections where players were confused on having to select which area to fill in and then click on the intended answer. The ores listed on the blueprint selection were confusing as well, making players unsure of where to click or if they had to do anything with it at all.

### User Experience

- Fun
> The target group testers expressed that they enjoyed the game quite a bit and had fun; most guerilla testers agreed, though some remarked that the nature of it being a prototype hindered their overal experience.

- Sense of urgency
> No testers experienced a sense of urgency while playing based on the game itself - one tester remarked they felt pressured, but only because they were being observed.

- Satisfaction
> Testers across both guerilla and target audience remarked feeling satisfied playing the game and would enjoy to play it further. Those that were more negative made comments on the lack of reward and progression - this is largely due to the nature of the prototype and difficult to avoid in this stage of development.

- Challenge
> The feedback on challenge was more mixed. Many stated that the gameplay was not too overly challenging but it had potential; one pointed out specifically it felt like a tutorial level rather than a part of the game. The target audience largely did not find the general gameplay challenging but some did have a hard time with the math aspect, particulary the processing and crafting. Likely, this is because the target audience testing was just a smidge too young and thus not that far ahead in mathematics to be familiar with the concepts introduced.

### Didactic Efficacy

- Learning objectives alignment
> Most players experienced all 5 learning goals aside from the few that were unable to finish the game because of time constraint/bugs and crashes.

- Assessment of knowledge acquisition
> Most players were able to somewhat describe the type of math concepts in the game but none actually listed 'linear equations'.

- Engagement with educational content
> None of the players were able to complete mining within 2 minutes. 4 out of the 13 players finished processing within 45 seconds. 3 out of 11 finished crafting within 35 seconds while reading coordinates and none out of the 9 players that finished the workbench doing the calculation were able to do it within a minute. From observation, this could to a degree be attributed to two things: lack of guidance in the mechanics, and lack of sufficient math skill.


- Tutorial and guidance options
> N/A

- Expression
> Some players expressed themselves by using larger 'a' values to cover more ground quickly. Others jumped to place the track higher rather than adjust the 'b' value manually. This is unintended in design, but an interesting approach by the players nonetheless.

### Game Flow

- Complete concentration on the task
> Once the players sunk their teeth into a task, they were not interrupted or distracted.


- Clarity of goals
> The goals were not clear, nearly every player needed to be guided by the observer at some point, needing to be directed to the next objective. At the railtrack placement this was especially prevalent, either asking for help or getting stuck and needing to be pointed to the right mechanics by the observer.


- Effortlessness and ease
> Some players expressed confusion regarding the control scheme. They expected to be able to jump with the 'spacebar' but they were required to use 'WASD' for all movement. Some attempted to use the arrow keys to walk around rather than WASD, and needed to be pointed to the correct keys. There were some issues with the rail placement key after it no longer showed on screen, and some struggled with the identification of which part of the table was being filled in.


- Balance between challenge and skills
> There is a steep increase in challenge after the player is done with laying down tracks and going into the workshop. Some testers were taken aback by the game's sudden demand of skill, particularly among the target audience testers as they were not so familiar with the different concepts surrounding linear functions.

## Conclusion

Overal, the results were positive and somewhat along the lines of expectation. Generally, the game was considered enjoyable and many of the target audience testers would use this game to improve their math skills. The mechanics were not so complex that they took away the focus from the math challenges, although the way they were currently implemented felt too steep in some areas due to lack of familiarity. There is a slight lack of challenge in the game-side of things however, though this is largely attributed to the fact this is intended as a proof of concept prototype, rather than a vertical slice of the game.

Issues with the UI were more prevalent. The lack of the control scheme on the screen as suggested in the GDD caused some confusion in areas where the traditional keyboard input was deviated from, such as placing the railtracks with R. Filling in the table on the workbench was also a point of issue as it was unclear in what order the buttons needed to be pressed, or how the table should be filled in. 

Lack of clarity in how to progress is also brought forward as an issue; the tester needed to be guided in order to know what to do and where to do it. Largely this can be attributed to the way the game is presented right now; a barebones prototype with no real introduction or explanation, while a fully fledged game would have more of a gradual introduction to mechanics to help the player understand what is expected of them. Nevertheless, this should remain a point of consideration.

All-in-all, many issues found in the game could be attributed to the state of the game as it is right now; a prototype. 

## Recommendations

- Implement a progression of mechanics, such as a tutorial that gradually introduces the mechanics to the player. A proposed way to do it can be found in [Myth Digger GDD](01%20GDD.md) under the 'Progression' chapter.
- When the overal progression is designed, the increase of challenge needs to be actively considered. This is not only in the aspect of the gameplay; rather, designers should pay close attention to the math questions, the difficulty thereof, and how they are presented as the game continues. A grade setting might be useful - intercepts are not so familiar for students in the first year, but are very familiar concepts for those in later grades. 
- Narrative presentation is rather key in this concept to reflect progress and incentivise the player to continue as they are.
- Adjust the UI to have the controls on screen at all times - this is also added in the GDD for clarity.
- Adjust the UI on the processsing menu to a drag-and-drop of the numbers into the table. 
- Disable placement of rails while jumping, as this completely removes the use of the b-value.

