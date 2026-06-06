using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Transform spawn;
    private CharacterController controller;

    void Start()
    {
        GameObject spawnObj = GameObject.FindGameObjectWithTag("Respawn");
        if (spawnObj != null)
        {
            spawn = spawnObj.transform;
        }

        controller = GetComponent<CharacterController>();
    }

    public void Respawn()
    {
        if (spawn != null)
        {
            if (controller != null) controller.enabled = false;

            transform.position = spawn.position;

            if (controller != null) controller.enabled = true;
        }
    }
}