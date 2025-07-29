using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class BallAuthering : MonoBehaviour
{
    public float Speed;
    public float3 Dicrection;

    private class Baker : Baker<BallAuthering>
    {
        public override void Bake(BallAuthering authoring)
        {
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new BallComponent
            {
                Speed = authoring.Speed,
                Dicrection = authoring.Dicrection
            });
        }
    }
}

