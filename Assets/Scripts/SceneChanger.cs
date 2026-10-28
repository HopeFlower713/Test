using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    
    void Changer()
    {
        SceneManager.LoadScene(sceneName);
    }
    private void Quit()
    {
        Application.Quit();
    }
}
