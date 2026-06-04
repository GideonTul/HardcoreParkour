using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorControl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Menu" || scene.name == "Menu_Settings")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
