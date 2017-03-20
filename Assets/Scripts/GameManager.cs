using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public PlayerManager player;
    public TicTacToeButton[] board;

    private bool gameActive;
    private bool playerTurn;

	void Start () {
        gameActive = true;
        playerTurn = !player.isX;
	}
	
    //We learn about the Update function here
	void Update () {
        if (gameActive)
        {
            if (!playerTurn)
            {
                TakeTurn();
                playerTurn = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    //[0][1][2]
    //[3][4][5]
    //[6][7][8]
    public void CheckWinCondition()
    {
        //check horizontal rows
        if (board[0].IsTaken() && board[1].IsTaken() && board[2].IsTaken())
        {
            if(board[0].IsX() && board[1].IsX() && board[2].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if(!board[0].IsX() && !board[1].IsX() && !board[2].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        if (board[3].IsTaken() && board[4].IsTaken() && board[5].IsTaken())
        {
            if (board[3].IsX() && board[4].IsX() && board[5].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[3].IsX() && !board[4].IsX() && !board[5].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        if (board[6].IsTaken() && board[7].IsTaken() && board[8].IsTaken())
        {
            if (board[6].IsX() && board[7].IsX() && board[8].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[6].IsX() && !board[7].IsX() && !board[8].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        //check vertical columns
        if (board[0].IsTaken() && board[3].IsTaken() && board[6].IsTaken())
        {
            if (board[0].IsX() && board[3].IsX() && board[6].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[0].IsX() && !board[3].IsX() && !board[6].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        if (board[1].IsTaken() && board[4].IsTaken() && board[7].IsTaken())
        {
            if (board[1].IsX() && board[4].IsX() && board[7].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[1].IsX() && !board[4].IsX() && !board[7].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        if (board[2].IsTaken() && board[5].IsTaken() && board[8].IsTaken())
        {
            if (board[2].IsX() && board[5].IsX() && board[8].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[2].IsX() && !board[5].IsX() && !board[8].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        //check diagonals
        if (board[0].IsTaken() && board[4].IsTaken() && board[8].IsTaken())
        {
            if (board[0].IsX() && board[4].IsX() && board[8].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[0].IsX() && !board[4].IsX() && !board[8].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }

        if (board[2].IsTaken() && board[4].IsTaken() && board[6].IsTaken())
        {
            if (board[2].IsX() && board[4].IsX() && board[6].IsX())
            {
                if (player.isX)
                    EndGame(true);
                else
                    EndGame(false);
            }
            else if (!board[2].IsX() && !board[4].IsX() && !board[6].IsX())
            {
                if (player.isX)
                    EndGame(false);
                else
                    EndGame(true);
            }
        }
    }

    public void EndGame(bool playerWon)
    {
        gameActive = false;
        if (playerWon)
        {
            print("YOU WIN!");
            player.IncrementScore();
            print(player.GetScore());
        }
        else
        {
            print("YOU LOSE!");
        }
    }

    //We learn about getters and setters here
    public bool IsPlayerTurn()
    {
        return playerTurn;
    }

    public void SetPlayerTurn(bool isTurn)
    {
        playerTurn = isTurn;
    }

    public bool IsGameActive()
    {
        return gameActive;
    }
}
