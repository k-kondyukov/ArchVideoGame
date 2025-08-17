using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InitializePlayerSystem : IInitializeSystem
{
    private Contexts _contexts;

    public InitializePlayerSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        var screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        var screenOrigo = Camera.main.ScreenToWorldPoint(Vector2.zero);
        var entity = _contexts.game.CreateEntity();

        entity.isPlayer = true;
        entity.AddResource(_contexts.game.gameSetup.value.player);
        entity.AddInitialPosition(new Vector3(0f, -screenBounds.y / 1.5f, 0f));
        entity.AddAcceleration(Vector3.zero);
        entity.AddTilt(0f, 0f);
    }
}
