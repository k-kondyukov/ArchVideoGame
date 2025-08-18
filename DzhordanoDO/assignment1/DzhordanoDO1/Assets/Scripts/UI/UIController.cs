using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button mainMenuButton;

    private void Start()
    {
        playButton.onClick.AddListener(() => GameManager.Instance.RequestState(GameStateType.GamePlay));
        pauseButton.onClick.AddListener(() => GameManager.Instance.RequestState(GameStateType.Pause));
        resumeButton.onClick.AddListener(() => GameManager.Instance.RequestState(GameStateType.GamePlay));
        mainMenuButton.onClick.AddListener(() => GameManager.Instance.RequestState(GameStateType.MainMenu));
    }
}