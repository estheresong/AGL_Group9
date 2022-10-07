using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerMenu : MonoBehaviour
{
    public static bool isWinner;

    public GameObject WinnerScreen;
    public GameState game;

    void Update ()
    {
        Winner();
    }

    void Winner()
    {
        if (isWinner)
        {
            WinnerScreen.SetActive(true);
        }
        else
        {
            WinnerScreen.SetActive(false);
        }
    }

    public void GoAgain()
    {
        Debug.Log("Go Again");
        game.Restart();
    }
}
