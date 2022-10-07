using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public Spawn respawn;
    public Timer time;

    public void Restart()
    {
        respawn.Respawn();
        time.timeValue = 90;
        GameOverMenu.isGameOver = false;
        WinnerMenu.isWinner = false;
    }
}
