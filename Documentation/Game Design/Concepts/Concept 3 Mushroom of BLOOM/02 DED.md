# Mushroom of BLOOM: Design Evaluation Template

`v2.1`

In this document we outline how we are going to evaluate our designs before software implementation and user testing.

## Core Ideas and Values

### Serious Games

The concept of Mushroom of BLOOM does fall under a serious game; it intends to teach mathematical skills as taught in a classroom. It has integrated linear functions within its core mechanics, by seeing visual representations of those graphs and adjusting them in-game. Although ideas like putting the UI increments on the turret's barrel directly discourage the player from looking at the equation itself and might result in a disconnect between the math and game.

### Content

#### Learning Content

1. Playing with the fundamental characteristics of a linear function ~~first individually and then~~ in combination.
   - Partially fulfilled, they make sure the tower's trajectory are determined by the player adjusting the *a* and *b* value of the linear equations, however both are introduced at once
2. Applying the fundamental characteristics to transform one representation (verbal, graph, formula, table) into another in a playful way.
   - Fulfilled, they give the player the option to pick the linear function from a pool of cards.
3. Solving quests, tasks and problems involving multiple representations of linear function (graph, formula).
   - Fulfilled, the player has the option of having the tower shoot in multiple ways:
     - Defining the coordinates, the tower will shoot at the point was picked out by the player
     - Choosing the matching function card, the tower will shoot using the picked function as a trajectory
     - Altering a function, the player can adjust the graph lines to determine where the shot will land
     - Writing a new function, using graph lines to create a function to shoot
4. ~~Applying properties of linear functions to solve equations in a playful way.~~
   - Listed as not implemented, however we disagree; the card mechanic is an especially good example of applying properties to solve the function.
5. Applying the appropriate function representation to solve a question or problem in the game.
   - Fulfilled to an extent, there is an optimal card to choose for example, but it feels frail because you can place the tower wherever you'd like

#### Game Content

The gameplay feels entirely detached from the narrative. Try to think about more in universe concepts and events that can lead to interesting mechanics that sets the game apart from other tower defence games. In terms of UI clarity, Idea 1 and 2 from the 'Adjust Function (Intermediate)' are flawed. The learning goals require the player to interact and think about the linear functions. By placing the increment buttons on the tower's barrel instead of on the function, you are inviting the player to potentially not engage with the math and just take the trajectory at face value. The same thing is true for dragging the handler. Instead of having the player drag the handler, you can invite them to change the *x* value so the magnitued of the line is still altered but with the direct involvement of the player.

The dynamic music is a good idea, getting the player into the right mindset for the different states of the game. The sound design also alligns with the silly narrative and idle nature of tower defence games. Thinking about the theme in terms of audio with the wind and bees for example are also strong foundations for making the game immersive.

### Scalability

- **Definition:** Ability to include and expand on the learning goals.

  - While not listed in the document, there is a way to expand on the learning goals by introducing levels that already have predetermined tower positions. All you can do is 'activate' them with flowers. Then you have the option of determining their shooting trajectory. On top of that, you can restrict the ability to change either the *a* or *b* value to gradually introduce the player to both.
   
- **Definition:** Ability to scale the content and duration of the game, allowing the client to expand in the future.
  
  - The game can easily be expanded upon by introducing new types of towers, enemy types and weaknesses and level designs.

### Adaptability

**Definition:** How well is the product able to be used in different situations, e.g. it can be used in the curriculum in multiple ways.

While possible to use in a classroom setting directly, the game lends itself best as a supplemental to the curriculum, perhaps as a classroom challenge to maintain a highest possible score on the daily challenges or the furthest progress. If authorability is integrated in the final product, the teachers could design their own levels as math challenges within the classroom itself; but as the concept is currently described, Mushroom of BLOOM appears most appropriate as a side activity.

### Difficulty

#### Game Difficulty

**Definition:*** The level of challenge the game content presents.

- Yes, the game will get more difficult the longer you play. The enemies will become stronger and more plentiful as well as the level designs getting more complex.

#### Mathematics Difficulty

**Definition:** The level of challenge the learning content presents.

The math-based challenges increase in difficulty by unlocking different methods of applying the function, putting the player in a more complex situation in which the function is used. Different kinds of function applications such as tables or only a line are not used however.

### Accessibility

**Definition:** The player can play the game regardless of their mathematical skills, game skills and hardware.

- In terms of math skills, this game is accessible. It does require some knowledge of linear functions to be picked up, but not to a degree it becomes completely unusable if the player has little skills in the subject. The knowledge scales, and allows for more difficult applications of the mechanics, making it considerably less boring for those that are more knowledgable.
- For game skillls and ability, the game is easy to pick up. The mechanics are not so complicated that those with little game experience will struggle heavily; the turn-based nature allows for them to take their time and pick up the mechanics at their own pace. For more experienced players, they are not hindered, instead being able to use their knowledge of strategy and mechanics as a whole to push through it at a faster pace.
- Hardware accessibility might be a bottleneck. High end graphics are described in the GDD which does not lend itself well to a web-based game. Some of the size and scope in things like weekly or daily challenges might not be so suitable, but can be adjusted or removed based on this requirement if necessary.

### Core Values

#### Client Design Values

- Gameplay is entertainment first, education second
  - Fulfilled; the game is not preachy about the mathematics it tries to teach. They are part of the main game loop and thus on the forefront, but they are brought forward in a fun and engaging way.
- Complexity around linear functions is scalable
  - Fulfilled, as the path and enemy AI can be scaled in difficulty to require more complex linear equations.
- Gameplay needs to be validated through play tests by external players
  - This will be fullfilled further in development.
- Target audience, aged 12 to 16, level VWO
  - Fulfilled; gameplay is accessible and engaging for a wider range of ages and game experience.
- Gameplay is adaptable so it can be used inside and outside of the classroom
  - The game is most suitable as a supplemental to the class rather than be used as an active learning tool - however, it could be used if authorability for the teacher is actively involved. If the teacher can determine levels and the progression, this game could be used in the class itself.
- Game needs to be designed for web
  - The input as well as the general complexity of the gameplay seems to fulfill this, however the description of high end graphics as well as the possibility of customization unlocks and daily or weekly challenges lean more towards a more dedicated web hosting where players can make accounts or a separate dedicated (mobile) app. This is not a bad thing on its own, but should be taken into account.
- Authorability should be a key element
  - Levels could technically be designed by teachers as the simple straightfoward nature of the mechanics makes it easy to understand and build from, however, this is not directly addressed in the GDD.

#### Team Design Values

- Linear algebra has to be incorporated in the design of the core gameplay loop
  - Fulfilled; tower building and how they are aimed directly incorporate linear algebra and accurate representations of functions.
- Fun has to be considered over education in design
  - Fulfilled; the game uses linear functions, but by making it a direct part of the gameplay loop feels more like a game than an educational test.
- The game develops an understanding of the algebra it attempts to teach
  - Some implementations of interactions with the functions appear detached from each other; rather than manipulating the function and seeing the result, the player adjusts the line and sees the function, which does not stimulate active thinking about what the function could do. Depending on the implementation chosen, this could be fulfilled, or be lacking in some regard.
- Accessible and designed to be easy to pick up
  - The gameplay is simple, straightforward, and easy to understand. There is no fluff of preamble. It does require some knowledge of linear functions in order to play effectively, but not to a degree it can't be learned.
- Concept is scalable in complexity
  - Fulfilled, as the amount of towers, the complexity of those towers as well as the enemies and the maps can be increased as time progresses, leaving room for various designs.
- Game needs to be designed for web
  - As mentioned before, this is true to a degree after which it becomes slightly more complex requiring a more dedicated website or (mobile) app. However, these elements can be stripped or simplified in order to fit this requirement if the client needs it to be so.

## Game Lenses

- **[2] The Lens of Essential Experience**

  - *What experience do I want the player to have?*
    - The player should intrinsically want to play and return to the game. This is so the player can properly familiarize themselves with the linear functions.
  - *What is essential to the experience?*
    - A system that invites player retention and return value.
  - *How can my game capture that essence?*
    - Daily challenges is the easy solution. But making an Idle side mini-game could also invite the player to come back regularly to see how their game fares.
- **[34] The Lens of Skill**

  - *What skills does my game require from the player?*
    - First and foremost it requires skill and knowledge in linear functions, as well as a degree of strategic thinking for the tower placement and upgrades.
  - *Are there categories of skill that this game is missing?*
    - No categories are missing given the game's genre and context.
  - *Which skills are dominant?*
    - Stategy, and math skills.
  - *Are these skills creating the experience I want?*
    - These skills force the player to think about and consider linear functions as well as their placement with in the context of the world, which is part of the design goals lined out prior to creating this concept.
  - *Are some players much better at these skills than others?*
    - Yes - some students will grasp math quicker and easier than others, and thus have a higher skill at a quicker pace.
  - *Does this make the game feel unfair?*
    - No, because the game paces the difficulty carefully to not make the player feel like they are stuck in something above their skill level right off the bat.
  - *Can players improve their skills with practice?*
    - Yes, thanks to the gradual increase of difficulty and the possibility to replay levels at any moment. This allows the player to grow with the game.
  - *Does this game demand the right level of skill?*
    - The game has taken the target group into consideration, as well as the questions they would be asked in a math class for that level and scaled the game accordingly. Additionally, the tower defense elements of the game are appropriate for multiple skill levels, without demanding more than the player might be able to handle.
- **[39] The Lens Of Meaningful Choices**

  - *What choices am I asking the players to make?*
    - Tower placement and upgrades, to defeat the enemies that swarm the player.
  - *Are they meaningful? How?*
    - The player has to make well-thought out decisions in order to keep themselves alive and the game progress further.
  - *Am I giving the player the right number of choices? Would more make them feel more powerful? Would fewer make the game clearer?*
    - This is heavily reliant on game design, and if the towers are limited - if so, the amount of towers has to be refined in order to give the player the right amount of power without feeling overly powerful. Otherwise, purchasing an infinite amount of towers may result in too many choices, being overly powerful or like the input of the world itself will not matter.
  - *Are there dominant strategies in my game?*
    - As this game is in the prototyping phase, this question cannot be answered as of yet.
- **[93.5] The Lens of Presence**

  - *Is my player experience a sense of presence? Could it be stronger?*
    - The player is a royal strategist defending the kingdom. Their presence is the one commanding everything to happen. But the player could have a stronger sense of presence.
  - *What in my game is diminishing or breaking presence?*
    - There is no physical representation for the player within the level. They're an almighty entity dictating where and what towers will be placed.
  - *What in my game is building or strengthening presence?*
    - The instant feedback the player gets when placing a tower gives them a sense of agency. Which is essential for the player to feel their presence in the game.

## Dynamics & Aesthetics

- Sensation: the game as sense pleasure
  Especially in polish, this game does reach a level of sense-pleasure; the screen shakes, the particles fly out on a successful hit, the sound reflects all input and makes the overal experience *feel* satisfying to perform. Thus, this game achieves the aesthetic of sensation.
- Challenge: the game as obstacle course
  The game provides several levels and challenges within, placing towers strategically and making them fire in the correct directions. Incorrect decisions or strategic blunders provide a danger and are an obstacle to overcome, honing their skill and adapting to the situation at hand, giving them a challenge.
- Expression: the game as self-discovery
  The player can experiment and figure out their preferred strategy to complete the levels. You can play to turtle or you can play aggresive. Playing for economy or playing to permanently better your units. Invest in many smaller units or getting a few big ones. All these allow the player to express themselves and their preferences within the game, allowing for the aesthetic of expression.
- Submission the game as pastime
  The game doesn't require many inputs from the player. Once the turrets are set up, it's basically just a waiting game. This can be desirable for people that want to do other tasks while still having something to be engaged by. However, those with little knowledge of tower defense games or who lack in math skill might find this game more difficult and not as much of a relaxing or engaging pastime, leaving this aesthetic somewhat questionable.
