using UnityEngine;

public class PlayerView : MonoBehaviour, IView<GameEntity>
{
  public GameEntity Entity { get; set; }

  void Update()
  {
    if (Entity != null && Entity.hasPosition)
    {
      transform.position = Entity.position.value;
    }
  }
}