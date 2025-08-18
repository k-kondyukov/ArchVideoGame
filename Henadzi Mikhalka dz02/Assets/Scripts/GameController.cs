using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameSetup gameSetup;
    private Systems _systems;

    private Systems CreateSystems(Contexts contexts)
    {
        return new Feature("Game")
            .Add(new InputSystem(contexts))
            .Add(new InitializePlayerSystem(contexts))
            .Add(new SpawnAsteroidsSystem(contexts))
            .Add(new InstantiateViewSystem(contexts))
            .Add(new ReplaceAccelerationSystem(contexts))
            .Add(new MoveSystem(contexts))
            .Add(new TiltSystem(contexts))
            .Add(new SpinSystem(contexts))
            .Add(new CrashSystem(contexts))
            .Add(new DestroyEntitySystem(contexts))
        ;
    }

    private void Start()
    {
        var contexts = Contexts.sharedInstance;
        contexts.game.SetGameSetup(gameSetup);

        _systems = CreateSystems(contexts);
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
    }
}
