// Dry: Don't repeat yourself + Reset.
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objPrefab;
    public GameObject spawnPos;
    public List<GameObject> objects;
    public float spawnTime;
    public float spawnDelay = 1;
    public string spawnPosName = "";
    public string prefabName = "";
    public int maxObj = 1;

    private void Update()
    {
        this.Spawn();
        this.CheckDead();
    }

    protected virtual void Spawn()
    {

    }

    protected virtual void CheckDead()
    {
        for (int i = 0; i < this.objects.Count; ++i)
        {
            if (objects[i] == null)
            {
                objects.RemoveAt(i);
            }
        }
    }
}
