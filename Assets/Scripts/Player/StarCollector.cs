using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StarCollector : MonoBehaviour
{

    public int StarsCollected = 0;
    public int StarsInLvl = 1;
    public string NxtLvl = "Menu";
    public TMP_Text StarText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Star")
        {
            StarsCollected++;
            StarText.text = "Stars Collected: " + StarsCollected.ToString();
            Destroy(other.gameObject);
            if (StarsCollected == StarsInLvl)
            {
                SceneManager.LoadScene(NxtLvl);
            }
        }
        else if (other.tag == "Pizza")
        {
            SceneManager.LoadScene(NxtLvl);
        }
    }
}
