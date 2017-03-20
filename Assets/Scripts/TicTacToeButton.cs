using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeButton : MonoBehaviour {

    public PlayerManager player;
    public Text text;

    private Button button;
    private bool isTaken;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetTile);
    }

	private void SetTile()
    {
        if (!isTaken)
        {
            if (player.isX)
            {
                text.text = "X";
            }
            else
            {
                text.text = "O";
            }

            isTaken = true;
        }
    }
}
