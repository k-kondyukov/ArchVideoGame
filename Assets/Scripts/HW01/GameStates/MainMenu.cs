using UnityEngine;

public class MainMenu : IGameState
{
    public void EnterState() => Debug.Log("Entering to " + GetType().Name);

    public void ExitState() => Debug.Log("Exit of " + GetType().Name);

    public void UpdateState() => Debug.Log("Update " + GetType().Name);
}
