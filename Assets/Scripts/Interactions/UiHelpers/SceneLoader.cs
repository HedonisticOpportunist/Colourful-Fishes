using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Variables
    [SerializeField] private string nextScene;
    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
