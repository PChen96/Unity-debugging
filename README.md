# project-unity-rpg-project-proposal
project-unity-rpg created by GitHub Classroom
Project Proposal:

Title: Unity RPG

Group Members:
James Zhao
Hubert Ye
Paolo Tejeda
Phillip Chen

Introduction
	Our project is to create a 2-D Side Scroller RPG game in Unity using C#. Each person will be responsible for every part of the project including some sprites, enemy ai, bosses ai, and a bit of storyline, etc. Using the already existing template in Unity, we will make modifications and add in original designs. We will start with a generic “Hero on a quest to defeat the Big Bad Evil Guy (BBEG)” story and add twists and more complex backstories for each playable character as time goes on.

Features
Bullet hell mechanics - The players need to dodge enemy projectiles or else they take damage.
Create an object script so that when an object collides/touches a wall or entity, it destroys itself and removes itself from the screen. 
If a “bullet” touches a entity, it deals the corresponding “damage” depending on the origin of the “bullet” 
HP system for player characters so they have incentive to dodge enemy projectiles and MP system to let players use special skills.
Every playable player character will have variables that will denote what the character can do and make each one play differently. So a character with high HP and low MP will be inclined to play differently than a character with low HP but a lot of MP
Rebindable keys so players can customize their own unique key bindings to what they feel comfortable with
Save system and checkpoints, so that players can respawn when they die and not have to start over from the beginning.
Stores the state of all the player characters and their current location in a variable that when the player dies, they can choose to restart from the beginning or from that save point.
A character swapping feature - Because the player can only control 1 character at a time and the player’s characters are working in a party, players will be able to swap between them (by pressing the shift key, the game will pause to let the player change to a different character) to change between how they battle.(each unique character will have a unique ultimate skill bound to the I key)
Each playable character will be stored in a map.
We create a class which contains the template for each player character that will be stored in the map for reference. So that it is expandable in the future for when there are more player characters developed. 
The current player character will be stored/update the one in the map in 5a, and then replace the variables with new character’s variables from the map in 5a.
A skill tree/point system (map implementation) where players can learn more skills. But only able to equip 4 at a time to the J, K, I, L keys. (movement through W,A,S,D) at the start of a stage.
All possible skills will be stored in a map. This will reduce redundancy for when some player characters have the same skill.
Each playable character will have a map of skills from the map that are learnable. And when a player learns one, a bool will update saying that it is learned or not learned.
Each player character will have a vector of skills that are chosen from the ones in 6b before a stage starts and the vector will be in 5b.
Create a database of items (map implementation) in the game players can equip their characters with, that they can pick up along the way. 
Create a map of all the possible items that a player character can pick up and have different abilities or effects upon being picked up,
Create a variable on player characters that when an item is picked up, the variable updates to having that item by using the id of the item.
Possibly delete obtained items upon exiting a stage by returning the variable to null.

Bonus Features:
Local/Online co-op, allowing for a friend/s to play with you
A template map for enemies so we can randomly generate a stage so it’s different every time.
Replace all placeholder art with good pixel art so that it looks nice and add sound files so it sounds nice too.
Replace dialogue with an actual story.

Test Plan (1 paragraph)

Our plan to test our game will be to make sure all the features work. Our beta testing will include putting in 
dev cheats to jump to certain stages and parts of the levels to test stages and boss mechanics. We will also
allow our friends and family to playtest the game, so we get more opinions about its playability. We will then
ask questions according to whether they enjoyed playing the game, what they would want the game to include, whether
they encountered any bugs, etc. Then, according to their feedback, we will improve the game mechanics and we
will repeat this process until the game is completed. Afterwards, we will go through a few more tests for debugging
the game until we officially publish the game. 
