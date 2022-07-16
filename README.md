# Escape from Poorly Designed Dungeon
C# game made in Windows Forms .NET with game engine made from scratch. 

![alt tag](https://github.com/Peter-Palacios/Strata-site/blob/master/images/ProjectGifs/DungeonRun.gif)

## How It's Made:

**Tech used:** C#, WinForms .NET

Game Creation was inspired by YuraMihailov123's ArenaWar c# game: https://www.youtube.com/watch?v=AAYmYiKx-64&ab_channel=DebroneConstant. 
Game utilizes same physics for character model. I design and coded map interaction and collision with ability to get object and have in character "inventory" by
setting a condition that if player interacts with the object, a key in this case, then a char tag is returned to identify that player has interacted with object and set the condition if
player interacts with door, player wins. 

Game utilizes BitMapping to draw dungeon layout and character model. Character animation by using different run frames that are being cycled through. Object collision with character
is also implemeted.

# Lessons Learned:

Learned the importance of time and memory complexity, since program noticably slows down if less efficient methods are used to determine objects in place.

