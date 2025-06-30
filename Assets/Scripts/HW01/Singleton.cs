using UnityEngine;

abstract class Singleton<T> where T : class, new() {

    private static T _instance = null;

    public static T Instance() => _instance ??= new T();

    public static void Destroy() => _instance = null;
}
