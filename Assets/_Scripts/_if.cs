using UnityEngine;

public class If : MonoBehaviour
{
    void Start()
    {
        int playerLocation = 19;
        int spawnLocation = 20;
        if (playerLocation == spawnLocation) this.Spawn();
        else this.NotSpawn();
    }

    void Spawn ()
    {
        Debug.Log("Player has spawned");
    }

    void NotSpawn()
    {
        Debug.Log("Player has not spawned");
    }
}
