using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _enemyScore;

    public Text playerScoreText;
    public Text enemyScoreText;

    public Paddle playerPaddle;
    public Paddle enemyPaddle;

    public void PlayerScore()
    {
        _playerScore++;
         this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void EnemyScore()
    {
        _enemyScore++;
        this.enemyScoreText.text = _enemyScore.ToString();
        ResetRound();
    }

   private void ResetRound()
    {
        this.ball.AddStartingForce();
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.enemyPaddle.ResetPosition();
    }
}
