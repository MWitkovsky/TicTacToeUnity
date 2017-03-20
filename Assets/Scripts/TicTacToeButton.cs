using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeButton : MonoBehaviour {
    public GameManager gameManager;
    public PlayerManager player;
    public Text text;

    private bool isTaken;
    private bool isX;

    //We learn about button events here
    public void SetTile(bool isPlayer)
    {
        if (!isTaken)
        {
            if (isPlayer && gameManager.IsPlayerTurn())
            {
                if (player.isX)
                {
                    text.text = "X";
                    isX = true;
                }
                else
                {
                    text.text = "O";
                    isX = false;
                }

                gameManager.SetPlayerTurn(false);
            }
            else
            {
                if (player.isX)
                {
                    text.text = "O";
                    isX = true;
                }
                else
                {
                    text.text = "X";
                    isX = false;
                }
            }
            isTaken = true;
            gameManager.CheckWinCondition();
        }
    }

    //We learn about getters here
    public bool IsTaken()
    {
        return isTaken;
    }
}
