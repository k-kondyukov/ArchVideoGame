using Entitas;

using UnityEngine;

public class GameController : MonoBehaviour
{
  Systems _systems;

  void Start()
  {
    var contexts = Contexts.sharedInstance;
    _systems = new GameFeatures(contexts);
    _systems.Initialize();
  }

  void Update()
  {
    _systems.Execute();
    _systems.Cleanup();
  }
}
