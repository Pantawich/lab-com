using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
    Debug.Log("Quitting game...");
    Application.Quit();
    }
}