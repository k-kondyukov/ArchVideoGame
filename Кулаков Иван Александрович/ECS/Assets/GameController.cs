using Entitas;

using UnityEngine;

public class GameController : MonoBehaviour
{
  Systems _systems;

  void Start()
  {
    Time.timeScale = 1;
    var contexts = Contexts.sharedInstance;

    // Очистка всех сущностей во всех контекстах
    contexts.Reset();

    _systems = new GameFeatures(contexts);
    _systems.Initialize();
  }

  void Update()
  {
    _systems.Execute();
    _systems.Cleanup();
  }
}
