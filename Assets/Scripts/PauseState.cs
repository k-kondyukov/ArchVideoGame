using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : IGameState
{
    public void EnterState()
    {
        Debug.Log("Game Paused");
        Time.timeScale = 0f;
    }

    public void ExitState()
    {
        Debug.Log("Unpaused Game");
        Time.timeScale = 1f;
    }

    public void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.ChangeState(new GamePlayState());
        }
    }
}