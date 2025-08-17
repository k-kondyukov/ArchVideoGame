using Entitas;
using Entitas.Unity;
using UnityEngine;

public sealed class ReplaceAccelerationSystem : IExecuteSystem
{
    private Contexts _contexts;

    public ReplaceAccelerationSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        var input = _contexts.game.input.value;
        var player = _contexts.game.playerEntity;
        var acceleration = player.acceleration.value;
        var speed = _contexts.game.gameSetup.value.speed;

        player.ReplaceAcceleration(acceleration * 0.98f + input * speed * Time.deltaTime);
    }
}
