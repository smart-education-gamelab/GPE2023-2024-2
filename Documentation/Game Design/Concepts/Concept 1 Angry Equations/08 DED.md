# [Title]: Design Evaluation Template

`v3.0`

In this document we outline how we are going to evaluate our designs before software implementation and user testing.

## Core Ideas and Values

### Serious Games

**Definition**: A game intending on teaching the player a concept or skill applicable in the real world.

The game attempts to teach the player linear equations in a very easy to understand way and in a way that is also very closely related to how trajectories impacted by gravity work in real life. The game teaches this concept by having the player aim a cannon to destroy obstacles and enemies. The trajectory of the bullet is impacted by gravity and behaves like a real bullet would. The linear function is hereby tied directly into the gameplay. This game is perfect for the introduction to linear equations as it starts on a very low level and through the simplistic gameplay also has a low entry point for inexperienced gamers. The input system is easy to understand and does not rely on any intricate skills but solely on the cursor. This concept is best used as a parallel to the introduction given by the teacher into linear equations and functions. 

This game copies the functionality of Angry Birds, a widely known game with a simple premise. The players are guaranteed a interesting yet simple experience which they have seen before and are familiar with.


### Content

#### Learning Content

The learning content has been partially met. The concept is very small and only describes one way to interact with the mathematical aspect. The progression of the mathematical aspect and the gameplay with mechanics is missing and therefore the learning goals are only partially met:

1. Playing with the fundamental characteristics of a linear function first individually and then in combination.

> Partially fulfilled. The game sets a low bar for the entry level with and lets the player interact with the function in simple way. Letting the player experience how each value works. Although it is not clearly stated how they interact with each other and in the GDD there is no progression of the mathematical and gameplay stated.

2. Applying the fundamental characteristics to transform one representation (verbal, graph, formula, table) into another in a playful way.

> Partially fulfilled. The player can interact with the formula and can see in real time how it translates to a graph. There are no tables implemented though and not described how they would be added to the game.

3. Solving quests, tasks and problems involving multiple representations of linear function (verbal, graph, formula, table).

> Partially fulfilled. The player is solving puzzles and problems with multiple representations of a linear functions, these being a graph and a formula. The concept does not explain how more could be implemented.

4. Applying properties of linear functions to solve equations in a playful way.

> Fulfilled. The gameplay experience is engaging and the way to solve the problem the player has to aim the cannon and shoot. The gameplay is inspired by Angry Birds and it reflects that playfulness.

5. Applying the appropriate function representation to solve a question or problem in the game.

> Partially Fulfilled. The game in this stage only offers one way to represent a function which is from the formula to the graph. It has potential to extend the gameplay experience to other representations as well and incorporate more mechanics.

#### Game Content

*How does the game include narrative, art, sound and further game and or level design?*

The game is very simple and is inspired by angry birds. It functions a lot like that game in multiple ways. The story is very bare bone but could be elaborated on more and worked out to create a good hook and a engaging experience. The artstyle is simple and not too flashy which works perfectly for this simple concept. The sound is not described in detail as well as the animations and particle effects which are lacking, so we cannot make a judgement on that.

### Scalability

Due to the lack of explanation and description regarding the scalability we cannot make a fair judgement based on the context, and we will not make assumptions. Therefore this section might come across as a bit depressing. The concept in itself is scalable but it is just not described. The concept is also not suited for other types of functions like exponential ones.

*Ability to include and expand on the learning goals.*
- The learning goals are not very well described how they are included in this concept so they can not be expanded on. The expansion is not described in progression. The ability is there, and there is potential in this concept but because of lacking explanation this is hard to judge.

*Ability to scale the content and duration of the game, allowing the client to expand in the future.*
- The content and duration of the game is scalable. The levels can be made harder and there is a skill tree mentioned in the concept which provides a basis to scale this concept. New skills could be added to this tree in the future which impact the gameplay experience. 

### Adaptability

*Does it align with how the team defined adaptability? Is it an adaptable game? How? Why?*

**Definition**: How well is the product able to be used in different situations, e.g. it can be used in the curriculum in multiple ways.

This concept can be used in multiple different ways. It can be used as a addition to the classroom for a intermission or a exercise at the end of the lesson. Due to the nature of the levels being quite short, this game is perfect for short time slots that need to be filled. It can also be used outside of the classroom as a extracurricular activity or a game that the students play in their free time or as homework. The game cannot be adapted to teach other equations for example exponential ones due to the nature of how it is conceptualised.

### Difficulty

#### Game Difficulty

**Definition**: The level of challenge the game content presents.

This concept has a very low entry bar and presents itself as perfect for students who are not gamers but also for those who are experienced in this field because it is heavily inspired by angry birds, a very well known game. The game is simple and allows for a nice and easy introduction to linear equations and functions, provided by the simplicity of the mechanic of adjusting the variables of the formula. There is no further description of how the progression works in regards to the game difficulty and if other mechanics will be introduced so we cannot make an informed judgement.

#### Mathematics Difficulty

**Definition**: The level of challenge the learning content presents.

This game starts with a very simple task which allows the player to get familiar with how the different variables interact with each other in the function and how they work together. There is no progression of this concept described in the GDD!

### Accessibility

**Definition**: The player can play the game regardless of their mathematical skills, game skills and hardware.

- Mathematical skills: this game is very simplistic and has a easy introduction to linear equations and the mathematical aspect. It serves as a very easy entry point for students who just learned about how linear functions work.
- Gameplay skills: the input system is very simple, the player just needs to adjust the function by pressing a button which is very easy to do and requires no prior knowledge of how to play games. So this game is suitable for non gamers as well as hard-core gamer.
- Hardware: the game is intended to be played on web, so the hardware is not a big focus. As long as the player has a browser, they are able to play the game.

### Core Values

#### Client Design Values

- Gameplay is entertainment first, education second
  - The gameplay is indeed entertainment first. The mathematical aspect is only important in the beginning of each shot, and the player then can see how much destruction they can cause. The gameplay is simple and engaging.

- Complexity around linear functions is scalable
  - This is not described in the concept.

- Gameplay needs to be validated through play tests by external players
  - Guerilla testing was conducted for this concept and further testing is planned with the target audience.

- Target audience, aged 12 to 16, level VWO
  - Yes

- Gameplay is adaptable so it can be used inside and outside of the classroom
  - The gameplay is adaptable and can be used for classroom activities, homework of for the player to play on their own free time.

- Game needs to be designed for web
  - This game is designed for web in mind, and also takes mobile into consideration by having an input system solely based on the cursor / touch with no expensive rendering or calculations.

- Authorability should be a key element
  - This concept is not described as very authorable. The levels need to be built and tested for how good they work because the player destroys them. So this concept is not suitable to be edited by the teachers. There are different variables at play here which work tightly together and should not be edited or altered in any way by the outside.

#### Team Design Values

- Linear algebra has to be incorporated in the design of the core gameplay loop
  - The core gameplay loop is not specifically described but from the texts it can be extracted that the mathematical aspect is deeply tied into the core gameplay loop.

- Fun has to be considered over education in design
  - The game is inspired by Angry Birds and plays very similar which promises an engaging gameplay experience. The nature of the interaction is very much tied into destruction which can be seen as fun by some players.

- The game develops an understanding of the algebra it attempts to teach
  - The game is perfect for an easy introduction into linear algebra, functions and math. It has a very low entry bar and is easy to pick up both in the mechanics but also considering the complexity of the mathematical aspect.

- Accessible and designed to be easy to pick up
  - Fulfilled. The design is very accessible as it only relies on buttons and has a visual component to enhance the understanding of the relation between the formula and the graph. Mechanics-wise it is also very easy to pick up as the mechanic is simple and clear.

- Concept is scalable in complexity
  - The scalability is not described in the concept.

- Game needs to be designed for web
  - The game is designed for web and also kept mobile in mind as well.

## Game Lenses

### Lens of Flow

*Does my game have clear goals? If not, how can I fix that?*
- The game has a clear goal, which is to destroy the enemies and collect the bananas. Because it is inspired by Angry Birds and the gameplay are fairly similar it should be easy to pick up as Angry Birds is quite easy to play as well and well known.

*Are the goals of the player the same goals I intended?*
- The goals of the player are to destroy the enemies and the structures. The goal of the designers is to teach them math in a fun and engaging way. These two things (the mechanic and the destruction) are so tightly knit together that the goals overlap.

*Do parts of the game distract players so they forget their goal? If so, can these distractions be reduced, or tied into the game goals?*
- The goal of the player is to destroy enemies and the gameplay never looses sight of that. The camera is static and the levels are conceptualized to only fulfil that goal. There are no distractions.

*Does my game provide a steady stream of gradually increasing challenges?*
- This is not defined in the GDD. The concept lacks the explanation of challenge both in math but also in mechanics.

*Are the player's skills improving as expected? If not, how can I change that?*
- This has to be tested, but the player has a very easy introduction and the learning curve could be very steep in the beginning.

### Lens of Skill

*What skills does my game require from the player?*
- The skill level required from the player regarding the interaction and mechanics is fairly simple and easy to pick up as the player only has to adjust variables in the formula which he can do by clicking on buttons. Mathematical wise, the player has to have a very basic understanding of linear functions, he should have at least seen a linear equation formula once. But also without a lot of knowledge the player is able to play this game.

*Are there categories of skill that this game is missing?*
- The game covers the very basics and has potential to scale up and also cover more of the learning goals and by extension more categories of skill. But this is not described in the GDD and therefore cannot be judged.

*Which skills are dominant?*
- The skill of understanding how the variables in the linear equations work together. Other to that the player does not need any knowledge or skills, it certainly helps if he already has an advanced understanding but it is not needed.

*Are these skills creating the experience I want?*
- Due to the game not needing any great skills, the experience that the designers intended is very likely to occur.

*Are some players much better at these skills than others?*
- Some players will inevitably be better at this game and pick up the math and mechanics faster, but this is to be expected as not all students are on the same level of understanding.

*Does this make the game feel unfair?*
- No, this game is not reliant on skill or mathematical knowledge which makes it fair and easy also for first time players.

*Can players improve their skills with practice?*
- Yes, if the players invest more time into perfecting their skills and knowledge it will become easier and the player will improve.

*Does this game demand the right level of skill?*
- This game does not demand a specific level of skill which makes it easy for every type of player to pick up and succeed. Mathematical wise the game is easier to play if the player has a basic understanding of linear equations and graphs.

### Concept Dependent Lenses

*Define which Game Lenses you are going to use. Choose 1 to 5 matching ones and answer all the questions clear and concise*

*Are we able to answer them? Does it give a clear view about the game and gameplay?*

- [69] The Lens of Interest Curve

  - If I draw an interest curve of my experience, how is it shaped?
    - Start: The player is interested in how exactly the game works and the interest is high.
    - Midpoint: The player gets used to the functionality of the game and the interest drops. It might spike every time he starts a new level as he wants to know how it looks and how to solve it.
    - End: The interest will plummet because the game has no described end and no hook to keep the player engaged aside from clearing every level.

  - Doest it have a hook?
    - No, this game does not have a hook. It is a very casual game and there is no hook described in the GDD. The players will only keep on playing because they want to progress and see which levels will come after. But there is no defined end and the game could be made more interesting by adding different mechanics and a progression through-line which aims at a greater end. They could work through different biomes etc.

  - Is there gradually rising interest, punctuated by periods of rest?
    - No. This game peaks in the beginning and will become very repetitive over time especially because it does not aim at something greater and has no hook and no end.

  - Is there a grand finale, more interesting than everything else?
    - No, in the GDD there is no end described.

  - What changes would give me a better interest curve?
    - New mechanics, new or different types enemies, maybe different worlds that the player can discover, each with their own special set of enemies with different abilities.

  - Is there a fractural structure to my interest curve?
    - No, the curve peaks in the beginning and then steadily goes down until the player is bored, and there is nothing in place to prevent that from happening.

  - Do my intuitions about the interest curve match the observed interest of the players? If I ask play testers to draw an interest cure, what does it look like?
    - *We cannot answer this question as of now*

- [38] The Lens of Challenge

  - What are the challenges in my game?
    - The challenges are to defeat the enemy by launching different missiles and bombs at him with a cannon. The mechanics and input system is very easy to pick up the the math is fairly simple as well as the player only has to adjust the different variables in the formula.

  - Are they too easy, too hard, or just right?
    - For players experienced and with a deep understanding of math it might be too easy, but for first time players who just had their first introductory lesson about linear equations this game is perfect. It offers a interesting gameplay experience for a broad audience but it cannot cover all of them.

  - Can my challenges accommodate a wide variety of skill levels?
    - For students who are new to linear equations the challenge is matching and because there is no progression described, we cannot make an assumption or judgement on how this challenge will evolve and cover more skills or extended skill sets of more experienced players.

  - How does the level of challenge increase as the player succeeds?
    - This is not described in the GDD.

  - Is there enough variety in my challenges?
    - There is only one demo level and no progression described, so they cannot be used to form judgement of the variety of challenge in the game.

  - What is the maximum level of challenges in my game?
    - This is not described in the GDD.

## Dynamics & Aesthetics

*Are the proposed aesthetics achieved with the current mechanics? Do the dynamics support the aesthetics? Do you agree with the proposed explanation in the GDD?* 

**Challenge**: Game as obstacle course
- Challenge is found in the levels as the player has to find out how the linear equations work and which one works best to defeat the enemy and bring the structure to collapse. There is no further challenged as the GDD has not described the progression of the gameplay and math aspect, and we cannot make judgement.

**Discovery**: Game as uncharted territory
- The game offers each level new enemies and structures to defeat and destroy. The player can also level up with the skill tree which can be looked at as discovering new abilities. In the GDD discovery is also described as the player discovering new functions and equations that help him defeat the enemy and progress through the levels. Other to that there is no discovery described. The game-loop is repetitive especially because there is no progression described.

## Notes

### Learning Goals
- The learning goals are described as all met, how are they met though? Describe in detail for each learning goal individually!

#### Evaluation
- After the level is cleared a function will fade into display. Why only after the player has cleared the level? Does the function display the "perfect" function for this level? What if the player used multiple different functions to clear the level? Can't the player see the trajectory and use the visual aid provided by the function to clear the level? It is described that with this, the player can make a connection between the math in the level and the gameplay. Arguably this is not true, as the break between the player actually interacting with the function and clearing the level is too long for the player to make the connection to how his trajectory looks like as a function. 

#### Scoring System
- Describe how the scoring system exactly works with a table. Otherwise it is not clear enough, where the breakpoints from each score to the next are.

### Currency
- The player has to use the bananas to "buy" new levels? He has to have a set amount of bananas to progress through the level and unlock the next one. Describe what happens if the player only gets one banana each run, can he still unlock the higher levels or does he need to get all the 3 bananas?

### Implementation

#### Controls
- The controls are not specified enough. It states that the player uses touch and on desktop the cursor. But what if the player proceeds through the levels and needs to enter a value. He should be able to use the keyboard.

#### Consumables and Skillpoints
- For every 10 bananas the player gets a skill point which he then can use for the skill-tree. Describe how this skill tree works:
    - what kind of skills can the player unlock?

### Progression

Progression is not defined properly. How do the players progress and how does the game scale? How does the mathematical aspect scale? Does it get harder, are visual aids removed to further the challenge? How does the gameplay change? Are new mechanics introduced throughout the gameplay experience? How does the mechanic and gameplay scale? A lot of the DED is dependant on the progression being defined properly and because it is missing a lot of evaluation points cannot be done properly!

#### Game loops

Gameplay loop:
- The game loop is centred around the long term game loop. The core gameplay loop is not described. Describe
    - When is the math done?
    - How is it done?
    - What happens when the player fails / succeeds?
    - Can they still progress through the levels without the use of power-ups?
    - Use mermaid-diagrams as flowchart with a distinct start and end together with decisions.

Negative Feedback loop:
- Negative feedback loop is rather short and high level
    - Describe exactly what happens, when does the player succeed?
    - How do the player get better at math? How do you measure that? In amount of tries?
    - How does the game get more difficult?
    - How exactly do they balance each other?

Positive Feedback Loop:
- Loop is described on a high level
    - what kind of upgrades are we talking about?
    - How do they make the game easier?
    - Accompanied text is pretty short, add a better description on the loop.

#### HUD and UI

- Level selection has no sketch. Add one for clarity.
- Make two seperate images out of the pause screen and the main layout. Also keep the pause level description seperated from the In-Level UI.
- Option to restart the level should be added to the pause menu.
- Inconsistent UI choices: In the cleared level it is stated that the button for next level is greyed out but in the failed Level UI design the button is not disabled but missing entirely. 

#### Game Objects

- Ammunition: describe how exactly the ammunition works and if there is other ammunition as well. How does it differ?
- Destructible Blocks: what kind of blocks are these exactly? What are they made of? Are they visually distinct from indestructible blocks?
- Connecting planks: can be destroyed when one or both attached blocks are destroyed -> are they indestructible by themselves or do they take damage as well? Describe more in detail.
- Game Objects is missing the description of bananas. They are also game objects and can be found in the level!
- Possible Level Design: Work with colours! The text should be accompanied by a visual that speaks for itself with a legend of what is what exactly. 

#### Polish

- Animation: are there no animations in this game? Do the enemies not have animations?
- Story: the story is very short. It is concise but lacks substance. There is no hook in this story, this feels more like an elevator pitch. Describe in detail what the story is about.
- Sound: describe the sound more clearly for each game object that should have a sound. I.e planks that fall make a noise when they break, enemies make a sound when they die etc.