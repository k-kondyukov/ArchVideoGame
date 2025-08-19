using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public struct GeneratePrefabStruct : IComponentData
{
    public Entity prefab;
    public float3 playerPos;
}
