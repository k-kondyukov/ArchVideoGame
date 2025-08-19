using Unity.Entities;
using Unity.Mathematics;

public struct BallComponent : IComponentData
{
    public float Speed;
    public float3 Dicrection;
}