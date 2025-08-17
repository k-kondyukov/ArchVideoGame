using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class SpawnAsteroidsSystem : IExecuteSystem
{
    private Contexts _contexts;
    private float timeOffset = 0f;

    public SpawnAsteroidsSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        timeOffset += Time.deltaTime;
        if (timeOffset < 2f) return;
        timeOffset = 0f;

        var tr = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        var bl = Camera.main.ScreenToWorldPoint(Vector2.zero);
        var entity = _contexts.game.CreateEntity();
        var position = new Vector3(Random.Range(bl.x, tr.x), tr.y + 0.7f, 0f);
        var acceleration = new Vector3(0f, Random.Range(-3.5f, -1.5f), 0f);

        entity.AddResource(GetRandomAsteroid());
        entity.AddInitialPosition(position);
        entity.AddAcceleration(acceleration);
        entity.AddSpin(Random.Range(-5f, 5f));
    }

    private GameObject GetRandomAsteroid()
    {
        var setup = _contexts.game.gameSetup.value;
        var keys = new List<string>(setup.asteroids.Keys);
        var list = setup.asteroids[keys[Random.Range(0, keys.Count)]].list;
        return list[Random.Range(0, list.Count)];
    }
}
