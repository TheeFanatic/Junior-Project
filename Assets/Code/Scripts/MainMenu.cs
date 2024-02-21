using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject settingsMenuObject;
    public string gameSceneName = "Movement Testing";

    public void OnContinueClicked()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnNewGameClicked()
    {
        DataPersistenceManager.instance.NewGame();
        SceneManager.LoadScene(gameSceneName);
    }

    public void OnSettingsClicked()
    {
        settingsMenuObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void OnQuitClicked()
    {
        DataPersistenceManager.instance.SaveGame();
        Application.Quit();
    }
}
