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

        // Get the CharacterController reference once
        controller = GetComponent<CharacterController>();
    }

    public void Respawn()
    {
        if (spawn != null)
        {
            // 1. Disable the controller to stop physics/collision checks
            if (controller != null) controller.enabled = false;

            // 2. Teleport the player
            transform.position = spawn.position;

            // 3. Re-enable the controller immediately
            if (controller != null) controller.enabled = true;
        }
    }
}