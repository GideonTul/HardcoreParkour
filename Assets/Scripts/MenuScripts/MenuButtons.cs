using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.Windows;

public class MenuButtons : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void toSettings()
    {
        SceneManager.LoadScene("Menu_Settings");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            LoadMainMenu();
        }
        if (SceneManager.GetActiveScene().name == "LevelThreeAnim")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene("LevelThree");
            }
        }
    }
}
