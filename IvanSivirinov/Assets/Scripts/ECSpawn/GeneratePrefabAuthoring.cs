using UnityEngine;
using Unity.Entities;
using Unity.Entities.UniversalDelegates;

public class GeneratePrefabAuthoring : MonoBehaviour
{
    public GameObject prefab;
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Dodgy The Player").transform;
    }

    private class Baker : Baker<GeneratePrefabAuthoring>
    {
        public override void Bake(GeneratePrefabAuthoring authoring)
        {
            // Debug.Log("GeneratePrefabAuthoring Bake");
            var entity = GetEntity(authoring, TransformUsageFlags.Dynamic);
            AddComponent(entity, new GeneratePrefabStruct()
            {
                prefab = GetEntity(authoring.prefab, TransformUsageFlags.Dynamic),
                playerPos = authoring.player.transform.position,
            });
        }
    }
}