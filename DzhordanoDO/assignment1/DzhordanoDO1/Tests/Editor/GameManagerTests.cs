#if UNITY_EDITOR
using NUnit.Framework;
using UnityEngine;

public class GameManagerTests
{
    [Test]
    public void Singleton_IsUnique()
    {
        var go1 = new GameObject();
        var gm1 = go1.AddComponent<GameManager>();
        var go2 = new GameObject();
        var gm2 = go2.AddComponent<GameManager>();
        Assert.AreEqual(GameManager.Instance, gm1);
        Assert.AreNotEqual(go2.GetComponent<GameManager>(), GameManager.Instance);
    }
}
#endif