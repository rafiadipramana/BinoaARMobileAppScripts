using UnityEngine;
using UnityEngine.SceneManagement;

public class BackActionCatcherController : MonoBehaviour
{
    public string sceneNameToLoad;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Back button pressed");
            // Add your code here
            SceneManager.LoadScene(sceneNameToLoad);
        }       
    }
}
