using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public PlayerManager player;
    public TicTacToeButton[] board;

    private bool playerTurn;

	void Start () {
        playerTurn = !player.isX;
	}
	
    //We learn about the Update function here
	void Update () {
        if (!playerTurn)
        {
            TakeTurn();
            playerTurn = true;
        }
	}

    //We learn about AI here
    private void TakeTurn()
    {
        bool successful = false;
        while (!successful)
        {
            int randomNum = Random.Range(0, 9);
            if (!board[randomNum].IsTaken())
            {
                board[randomNum].SetTile(false);
                successful = true;
            }
        }
    }

    //We learn about loops here
    public void CheckWinCondition()
    {

    }

    public bool IsPlayerTurn()
    {
        return playerTurn;
    }

    public void SetPlayerTurn(bool isTurn)
    {
        playerTurn = isTurn;
    }
}
