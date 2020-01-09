using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public bool hit = false;
    private int life = 5;
    public Text lifeText;
    public GameObject menuButton;
    private Button menu;
    
    // Start is called before the first frame update
    void Start()
    {
        lifeText.text = life.ToString();
        menu = menuButton.GetComponent<Button>();
		menu.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            life -= 1;
            hit = false;
            lifeText.text = life.ToString();
        if (life <= 0){
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        GameObject.Find("arms_handgun_01").GetComponent<HandgunScriptLPFP>().enabled = false;
        menuButton.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
