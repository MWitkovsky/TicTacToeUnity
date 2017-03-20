using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public bool isX;

    private static int score;

    public void IncrementScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
