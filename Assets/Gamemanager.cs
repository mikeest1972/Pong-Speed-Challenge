using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    private int playerScore;
    private int enemyScore;

    public ball ballController;

    public UIController uI;
    void Start()
    {
        playerScore = 0;
        enemyScore = 0;
        uI.updateScoreLabled(playerScore,enemyScore);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballController.playerScored)
        {
            playerScore++;
            uI.updateScoreLabled(playerScore,enemyScore);

            if(playerScore >= 10)
            {
                // won
                uI.wonProtocal();
                ballController.gameOver();
            }
            ballController.resetBall();
        }
        else if(ballController.enemyScored)
        {
            enemyScore++;
            uI.updateScoreLabled(playerScore,enemyScore);
            if (enemyScore >= 10)
            {
                // gameover
                uI.gameOverProtocal();
                ballController.gameOver();
            }
            ballController.resetBall();
        }
        
    }
}
