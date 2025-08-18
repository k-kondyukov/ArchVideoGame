using UnityEngine;

public class GameStateFactory : MonoBehaviour, IGameStateFactory
{
    [SerializeField] private MainMenuStateSO mainMenuState;
    [SerializeField] private GamePlayStateSO gamePlayState;
    [SerializeField] private PauseStateSO pauseState;

    public IGameState CreateState(GameStateType type)
    {
        return type switch
        {
            GameStateType.MainMenu => mainMenuState,
            GameStateType.GamePlay => gamePlayState,
            GameStateType.Pause    => pauseState,
            _ => throw new System.ArgumentOutOfRangeException()
        };
    }
}