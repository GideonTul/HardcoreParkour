using UnityEngine;

public class KillZone : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Inside KillZone Check");
            PlayerRespawn re = other.GetComponent<PlayerRespawn>();
            if (re == null) { Debug.Log("NO RE"); }
            if (re != null)
            {
                Debug.Log("Rspawn() Called");
                re.Respawn();
            }
        }
    }
}
