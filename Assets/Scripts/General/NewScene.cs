using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    private const string Key = "Continue";
    public void CambiarScena(string sceneName)
    {
        if (sceneName == "Game" || sceneName == "Game 1")
        {
            PlayerPrefs.SetString(Key, sceneName);
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene(sceneName);

    }
    public void CerraJuego()
    {
        print("Se cerro el juego");
        Application.Quit();
    }
    public void Continue()
    {
        string scene=PlayerPrefs.GetString(Key);
        SceneManager.LoadScene(scene);
    }
}
