using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayState : IGameState
{
    public void EnterState()
    {
        Debug.Log("Game Started");
        Time.timeScale = 1f;
    }

    public void ExitState()
    {
        Debug.Log("Exiting GamePlay");
    }

    public void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.ChangeState(new PauseState());
        }
    }
}
