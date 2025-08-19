// using Unity.Collections;
// using Unity.Entities;
// using Unity.Jobs;
// using UnityEngine;

// using Unity.Entities;
// using Unity.Physics;
// using Unity.Collections;
// using Unity.Burst;

// using Unity.Burst;
// using Unity.Collections;
// using Unity.Entities;
// using Unity.Jobs;
// using Unity.Physics;
// using Unity.Physics.Systems;
// using UnityEngine;
// using Unity.Entities;
// using UnityEngine;
using UnityEngine;

public class DangerFloor : MonoBehaviour
{

}
// public struct TriggerWarning : IComponentData
// {
//     public FixedString4096Bytes Message; // Example data for the trigger
// }

// public struct PlayerTag : IComponentData {} // Example tag for the player entity



// public class TriggerWarningAuthoring : MonoBehaviour, IConvertGameObjectToEntity
// {
//     [SerializeField] string _message = "Trigger Activated!";

//     public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
//     {
//         if (!enabled) return;
//         dstManager.AddComponentData(entity, new TriggerWarning { Message = _message });
//     }
// }


// [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
// [UpdateAfter(typeof(ExportPhysicsWorld))]
// [UpdateBefore(typeof(EndFramePhysicsSystem))]
// public partial class TriggerDetectionSystem : SystemBase
// {
//     private StepPhysicsWorld _stepPhysicsWorldSystem;

//     protected override void OnCreate()
//     {
//         _stepPhysicsWorldSystem = World.GetOrCreateSystem<StepPhysicsWorld>();
//         RequireForUpdate(GetEntityQuery(new EntityQueryDesc { All = new ComponentType[] { typeof(TriggerWarning) } }));
//     }

//     protected override void OnUpdate()
//     {
//         var triggerWarningData = GetComponentDataFromEntity<TriggerWarning>(isReadOnly: true);
//         var playerTagData = GetComponentDataFromEntity<PlayerTag>(isReadOnly: true); // Get player tag data

//         var job = new TriggerEventJob
//         {
//             TriggerWarningData = triggerWarningData,
//             PlayerTagData = playerTagData // Pass player tag data to the job
//         };

//         Dependency = job.Schedule(_stepPhysicsWorldSystem.Simulation, Dependency);
//     }

//     [BurstCompile]
//     private struct TriggerEventJob : ITriggerEventsJob
//     {
//         [ReadOnly] public ComponentLookup<TriggerWarning> TriggerWarningData;
//         [ReadOnly] public ComponentLookup<PlayerTag> PlayerTagData;

//         public void Execute(TriggerEvent triggerEvent)
//         {
//             Entity entityA = triggerEvent.EntityA;
//             Entity entityB = triggerEvent.EntityB;

//             // Check if either entity is the trigger and the other is the player
//             if (TriggerWarningData.HasComponent(entityA) && PlayerTagData.HasComponent(entityB))
//             {
//                 Debug.Log($"Trigger '{TriggerWarningData[entityA].Message}' entered by Player!");
//             }
//             else if (TriggerWarningData.HasComponent(entityB) && PlayerTagData.HasComponent(entityA))
//             {
//                 Debug.Log($"Trigger '{TriggerWarningData[entityB].Message}' entered by Player!");
//             }
//         }
//     }
// }


// // class SpawnerBaker : Baker<DangerFloor>
// // {
// //     public override void Bake(DangerFloor authoring)
// //     {
// //         var entity = GetEntity(TransformUsageFlags.None);
// //         AddComponent(entity, new Spawner
// //         {
// //             // By default, each authoring GameObject turns into an Entity.
// //             // Given a GameObject (or authoring component), GetEntity looks up the resulting Entity.
// //             Prefab = GetEntity(authoring.myPrefab, TransformUsageFlags.Dynamic),
// //             SpawnPosition = authoring.transform.position
// //         });
// //     }
// // }



// // public class DangerFloor : MonoBehaviour
// // {
// //     [SerializeField] GameObject myPrefab;
// //     // public Transform parent;

// //     void OnTriggerEnter(Collider other)
// //     {
// //         if (other.gameObject.tag == "Player")
// //         {
// //             Debug.Log("Player stepped on DangerFloor");
// //             Vector3 playerPos = other.gameObject.transform.position;
// //             playerPos.y += 3;

// //             var entity = GetEntity(TransformUsageFlags.None);
// //             AddComponent(entity, new Spawner
// //             {
// //                 // By default, each authoring GameObject turns into an Entity.
// //                 // Given a GameObject (or authoring component), GetEntity looks up the resulting Entity.
// //                 Prefab = GetEntity(myPrefab, TransformUsageFlags.Dynamic),
// //                 SpawnPosition = playerPos
// //             });

// //             // GameObject instantiatedObject = Instantiate(myPrefab, playerPos, Quaternion.identity);
// //             // instantiatedObject.transform.SetParent(parent); 

// //             // In a SystemBase or other ECS context
// //             // EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
// //             // Entity newEntity = entityManager.Instantiate(myPrefab);

// //             // var localTransform = entityManager.GetComponentData<LocalTransform>(newEntity);
// //             // localTransform.Position = playerPos;

// //             // entityManager.SetComponentData(newEntity, localTransform);
// //             // CreateEntities(myPrefab, new float3[] { playerPos });



// //         }
// //     }

// //     // public void CreateEntities(Entity prefab, float3[] positions)
// //     // {
// //     //     int count = positions.Length;
// //     //     NativeArray<Entity> output = new NativeArray<Entity>(count, Allocator.Temp, NativeArrayOptions.UninitializedMemory);

// //     //     EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
// //     //     entityManager.Instantiate(prefab, output);

// //     //     NativeArray<LocalToWorld> localToWorld = new NativeArray<LocalToWorld>(count, Allocator.Temp, NativeArrayOptions.UninitializedMemory);

// //     //     for (int i = 0; i < count; i++)
// //     //     {
// //     //         localToWorld[i] = new LocalToWorld
// //     //         {
// //     //             Value = float4x4.TRS(
// //     //                             positions[i],
// //     //                             quaternion.LookRotationSafe(math.forward(), math.up()),
// //     //                             new float3(1f, 1f, 1f))
// //     //         };
// //     //     }


// //     //     output.Dispose();
// //     //     localToWorld.Dispose();
// //     // }

// // }
