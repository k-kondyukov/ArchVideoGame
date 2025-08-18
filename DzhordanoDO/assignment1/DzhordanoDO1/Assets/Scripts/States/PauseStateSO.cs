using UnityEngine;

[CreateAssetMenu(menuName = "GameStates/Pause")]
public class PauseStateSO : ScriptableObject, IGameState
{
    public void EnterState() { /* Show Pause UI */ }
    public void ExitState() { /* Hide Pause UI */ }
    public void UpdateState() { }
}