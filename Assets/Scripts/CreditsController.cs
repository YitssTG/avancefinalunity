using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    public string scene;
    public void CloseCredits()
    {
        SceneManager.LoadScene(scene);
    }
}
