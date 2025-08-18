using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

public class CrashSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;

    public CrashSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Collision);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasCollision;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            var player = entity.collision.first;
            var asteroid = entity.collision.second;

            var playerEntity = _contexts.game.GetEntitiesWithView(player).SingleEntity();
            var asteroidEntity = _contexts.game.GetEntitiesWithView(asteroid).SingleEntity();

            playerEntity.isDestroy = true;
            asteroidEntity.isDestroy = true;
        }
    }
}
