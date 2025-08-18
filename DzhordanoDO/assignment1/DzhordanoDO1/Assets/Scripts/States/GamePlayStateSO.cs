using UnityEngine;

[CreateAssetMenu(menuName = "GameStates/GamePlay")]
public class GamePlayStateSO : ScriptableObject, IGameState
{
    public void EnterState() { /* Load or init gameplay */ }
    public void ExitState() { /* Pause or cleanup */ }
    public void UpdateState() { /* Game loop logic */ }
}