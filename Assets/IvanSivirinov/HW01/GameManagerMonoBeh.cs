using UnityEngine;

public class GameManagerMonoBeh : MonoBehaviour
{
    void Awake()
    {
        var gm = GameManager.Instance();

        gm.AddTarget("pause", new Pause());
        gm.AddTarget("gamePlay", new GamePlay());
        gm.AddTarget("mainMenu", new MainMenu());
    }



    void OnDestroy()
    {
        GameManager.Clean();
    }
}
