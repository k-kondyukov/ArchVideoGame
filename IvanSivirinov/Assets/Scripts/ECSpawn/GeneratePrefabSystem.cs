using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public partial struct GeneratePrefabSystem : ISystem
{
    void OnUpdate(ref SystemState state)
    {
        Debug.Log("GeneratePrefabSystem OnUpdate");
        foreach (var prefab in SystemAPI.Query<RefRW<GeneratePrefabStruct>>())
        {
            Debug.Log("GeneratePrefabSystem create new prefab");
            var playerPos = prefab.ValueRW.playerPos;
            playerPos.y += 3;
            var newPrefab = state.EntityManager.Instantiate(prefab.ValueRW.prefab);
            state.EntityManager.SetComponentData(newPrefab, new LocalTransform { Position = playerPos, Rotation = Quaternion.identity, Scale = 1f });

    // EntityCommandBuffer ecb = new EntityCommandBuffer(Allocator.Temp);
    // Entity newEntity = ecb.Instantiate(prefabEntity);
    // ecb.SetComponent(newEntity, new LocalTransform { Position = desiredPosition, Rotation = quaternion.identity, Scale = 1f });
    // // Later, play back the ECB:
    // ecb.Playback(entityManager);
    // ecb.Dispose();


        }
    }
}
