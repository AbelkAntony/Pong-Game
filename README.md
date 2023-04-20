# Pong-Game
 
Pong is one of the first computer games that ever created, this simple "tennis like" game features two paddles and a ball, the goal is to defeat your opponent by being the first one to gain10 point, a player gets a point once the opponent misses a ball.

The game objective is to hit the ball with the peddle. The one who miss the ball will loss the game. the points will be added when the peddle hit the ball .

In this left side paddle for Player and the right side paddle for computer. For player I use Vector2.up and Vector2.down for the direction for the peddle and add force to rigid body to by multiplying speed to the direction . For the computer paddle movement I use references to the movement and position of the ball. If the ball is moving towards the computer peddle the computer peddle refer the Y position of the ball and move toward that position . If the ball moves away from the computer peddle the peddle moves towards the center on Y axis.



#ScreenShots

![Capture1](/ScreenShots/1.png)
![Capture1](/ScreenShots/2.png)
![Capture1](/ScreenShots/3.png)
![Capture1](/ScreenShots/4.png)
![Capture1](/ScreenShots/5.png)
