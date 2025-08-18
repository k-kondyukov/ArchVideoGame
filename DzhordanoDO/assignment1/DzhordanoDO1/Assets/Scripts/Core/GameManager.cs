using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static event Action<GameStateType> OnStateRequested;

    private IGameStateFactory stateFactory;
    private IGameState currentState;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        stateFactory = GetComponent<IGameStateFactory>();
    }

    private void OnEnable() => OnStateRequested += HandleStateRequest;
    private void OnDisable() => OnStateRequested -= HandleStateRequest;

    private void Start() => ChangeState(GameStateType.MainMenu);

    public void RequestState(GameStateType newState) =>
        OnStateRequested?.Invoke(newState);

    private void HandleStateRequest(GameStateType newState)
    {
        ChangeState(newState);
    }

    private void ChangeState(GameStateType newState)
    {
        currentState?.ExitState();
        currentState = stateFactory.CreateState(newState);
        currentState.EnterState();
    }

    private void Update()
    {
        currentState?.UpdateState();
    }
}