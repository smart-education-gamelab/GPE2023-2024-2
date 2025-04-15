## MDA Framework Approach

Based on the MDA: A Formal Approach to Game Design and Game Research paper[^1]: the MDA framework is used to approach games from a player perspective, designing the game as an overal experience rather than a set of mechanics. Some aspects of this have proven to be vague for the GDD, so here is a quick overview of what each part of the MDA framework requires.

### Mechanics

Mechanics are the most high-level approach to the game's design as can be. There is no context given, rather just a series of actions that result in certain consequences.

Eg. Shooting: the player can shoot a projectile that explodes.
Secondary mechanic, killing: the player kills enemies with those projectiles to advance.

This sort of stuff is most interesting to a programmer and lays a foundation for the designers to work on. What feeling this is meant to evoke, what context they are placed in, is not relevant for the mechanics portion of the document.

### Dynamics

Dynamics is described in the paper as the 'player actions at run-time' which feels abstract to approach. Rather, it places the actions described in the mechanics into the game's context and argues what feeling they are meant to call on.

In the previous example, the player shoots and kills. In the game, this means the player is challenged in the level to conserve ammunition, not be hit by the enemies but to hit them effectively, and clear the level of those monsters in order to advance with the story. The feeling that this gives is feeling **challenged** by the game.

### Aesthetics

Aesthetics are used to give a more clear taxonomy to the word 'fun'. Fun is hard to define - why is a game fun? What is a game fun? How can you call a game fun, when the Sims is fun for a different reason than Call of Duty?

The idea of aesthetics is to give a clear definition to the kind of fun the player will achieve. As in the previous example, the kinds of fun are Challenge, and perhaps Narrative, or Discovery. Based on the descriptions in the taxonomy given in the paper, for aesthetics you briefly argue what aesthetic belongs to the concept.

### How Do

The order of the MDA framework generally dictates that you work backwards; from aesthetics to mechanics. In reality where there is testing involved, it is often more approachable to do it in an order of AMD.

First you determine what kind of fun you want the game to be. Then you design the mechanics that are fitting for this fun and for the game you want to build. From there, you can define your dynamics and argue aesthetics. If you find that your dynamics to not match the aesthetics you are trying to fullfill, you go back to your mechanics and adjust appropriately.

[^1]: https://www.researchgate.net/publication/228884866_MDA_A_Formal_Approach_to_Game_Design_and_Game_Research