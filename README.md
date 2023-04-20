# Pong-Game
 
Pong is one of the first computer games that ever created, this simple "tennis like" game features two paddles and a ball, the goal is to defeat your opponent by being the first one to gain10 point, a player gets a point once the opponent misses a ball.

The game objective is to hit the ball with the peddle. The one who miss the ball will loss the game. the points will be added when the peddle hit the ball .

In this left side paddle for Player and the right side paddle for computer. For player I use Vector2.up and Vector2.down for the direction for the peddle and add force to rigid body to by multiplying speed to the direction . For the computer paddle movement I use references to the movement and position of the ball. If the ball is moving towards the computer peddle the computer peddle refer the Y position of the ball and move toward that position . If the ball moves away from the computer peddle the peddle moves towards the center on Y axis.

In this I added the point system . When the ball hit on the back side wall of the peddle the opposite player point is added by one. For that I use on collision enter 2d to add score when the ball collide on the respective walls . To Increase the speed of the ball while playing I use a BouncySurface script and attached to the both up and down wall and both peddles to add force to the -normal direction multiplied by bounce strength .

Use a Game Manager script to manage all the function in game like adding points , reset the peddle position , reset the position of the ball add starting force to ball .


# ScreenShots

![Capture1](/ScreenShots/1.png)
![Capture1](/ScreenShots/2.png)
![Capture1](/ScreenShots/3.png)
![Capture1](/ScreenShots/4.png)
![Capture1](/ScreenShots/5.png)
