using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

	void Start() {
		Button play = playButton.GetComponent<Button>();
		Button quit = quitButton.GetComponent<Button>();
		play.onClick.AddListener(LoadGame);
		quit.onClick.AddListener(QuitGame);
	}

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
