using Project.Tools.DictionaryHelp;
using UnityEngine;
using System;
using System.Collections.Generic;
using Entitas.CodeGeneration.Attributes;

[CreateAssetMenu]
[Game, Unique]
public class GameSetup : ScriptableObject
{
    public GameObject player;
    public float speed = 5f;
    public float tiltY = 20f;
    public float tiltZ = 5f;

    public SerializableDictionary<string, Asteroids> asteroids;
}

[Serializable]
public class Asteroids
{
    public List<GameObject> list;
}
