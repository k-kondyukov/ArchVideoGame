using UnityEngine;

public class UIFactory : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPrefab;
    [SerializeField] private GameObject pausePrefab;

    public GameObject CreateUI(GameStateType type)
    {
        return type switch
        {
            GameStateType.MainMenu => Instantiate(mainMenuPrefab),
            GameStateType.Pause    => Instantiate(pausePrefab),
            _ => null
        };
    }
}