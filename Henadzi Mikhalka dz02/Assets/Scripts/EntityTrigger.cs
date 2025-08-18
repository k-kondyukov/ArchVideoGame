using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class EntityTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var entity = Contexts.sharedInstance.game.CreateEntity();
        entity.AddCollision(gameObject, other.gameObject);
    }
}
