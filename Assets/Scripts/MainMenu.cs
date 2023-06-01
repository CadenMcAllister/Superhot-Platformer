using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void GoToScene(string Game) {
        SceneManager.LoadScene(Game);
    }

    public void QuitApp() {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
