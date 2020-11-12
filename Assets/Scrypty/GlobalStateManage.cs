using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStateManage : MonoBehaviour
{
    private int deadPlayers = 0;
    private int deadPlayerNumber = -1;
    public void PlayerDied(int playerNumber)
    {
        deadPlayers++; // 1

        if (deadPlayers == 1)
        { // 2
            deadPlayerNumber = playerNumber; // 3
            Invoke("CheckPlayersDeath", .3f); // 4
        }
    }
    void CheckPlayersDeath()
    {
        // 1
        if (deadPlayers == 1)
        {
            // 2
            if (deadPlayerNumber == 1)
            {
                Debug.Log("Player 2 is the winner!");
                // 3
            }
            else
            {
                Debug.Log("Player 1 is the winner!");
            }
            // 4
        }
        else
        {
            Debug.Log("The game ended in a draw!");
        }
    }
    // A single player died and he's the loser.
    //Player 1 died so Player 2 is the winner.
    //Player 2 died so Player 1 is the winner.
    //Both players died, so it's a draw.

}

