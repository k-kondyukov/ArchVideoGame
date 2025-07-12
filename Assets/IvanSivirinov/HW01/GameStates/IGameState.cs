using UnityEngine;

public interface IGameState
{
    void EnterState(); // state entrance

    void ExitState(); // exit of state

    void UpdateState(); // refresh state
}
