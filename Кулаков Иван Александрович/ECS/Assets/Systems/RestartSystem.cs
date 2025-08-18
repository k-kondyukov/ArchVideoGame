using UnityEngine;
using UnityEngine.SceneManagement;
using Entitas;

public sealed class RestartSystem : IExecuteSystem
{
  public void Execute()
  {
    if (Input.GetKeyDown(KeyCode.R))
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  }
}
