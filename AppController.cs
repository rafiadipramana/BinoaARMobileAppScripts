using UnityEngine;
using UnityEngine.SceneManagement;

public class AppController : MonoBehaviour
{
    // Add a reference to the dialog controller
    [SerializeField] private ConfirmationDialogController confirmationDialogController;
    public void CloseApp()
    {
#if UNITY_EDITOR
        confirmationDialogController.Show(
            "Apakah Anda yakin ingin keluar?",
            () => UnityEditor.EditorApplication.isPlaying = false,
            null
        );
#else
        confirmationDialogController.Show("Apakah Anda yakin ingin keluar?",
            // On confirm
            () => Application.Quit(),
            // On cancel (optional)
            null
        );
#endif

        Debug.Log("App closed");
    }

    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}