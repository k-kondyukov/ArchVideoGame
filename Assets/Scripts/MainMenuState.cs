using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : IGameState
{
    public void EnterState()
    {
        Debug.Log("Entered Main Menu");

    }

    public void ExitState()
    {
        Debug.Log("Exited Main Menu");

    }

    public void UpdateState()
    {

    }
}