using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

public class SpinSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _group;

    public SpinSystem(Contexts contexts)
    {
        _contexts = contexts;
        _group = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Spin, GameMatcher.View));
    }

    public void Execute()
    {
        var screenOrigin = Camera.main.ScreenToWorldPoint(Vector2.zero);

        foreach (var entity in _group)
        {
            var view = entity.view.value;
            view.transform.Rotate(0, 0, entity.spin.speed * 10f * Time.deltaTime);

            if (view.transform.position.y < screenOrigin.y - 0.7f)
            {
                entity.isDestroy = true;
            }
        }
    }
}
