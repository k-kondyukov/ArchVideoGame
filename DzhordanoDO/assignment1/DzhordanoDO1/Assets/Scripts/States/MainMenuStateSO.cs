using UnityEngine;

[CreateAssetMenu(menuName = "GameStates/MainMenu")]
public class MainMenuStateSO : ScriptableObject, IGameState
{
    public void EnterState() { /* Show MainMenu UI */ }
    public void ExitState() { /* Hide MainMenu UI */ }
    public void UpdateState() { }
}