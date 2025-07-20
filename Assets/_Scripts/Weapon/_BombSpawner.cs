using System.Collections.Generic;
using UnityEngine;

public class _BombSpawner : Spawner
{

    private void Awake()
    {
        this.objects = new List<GameObject>();
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);
        this.objPrefab.SetActive(false);
    }

    private void Reset()
    {
        this.spawnPosName = "BombSpawnPos";
        this.prefabName = "BombPrefab";
        this.maxObj = 7;
    }

    protected override void Spawn()
    {
        spawnTime += Time.deltaTime;
        if (this.spawnTime < this.spawnDelay) return;
        this.spawnTime = 0f;

        if (this.objects.Count >= maxObj) return;

        int index = this.objects.Count + 1;
        GameObject minion = Instantiate(this.objPrefab);

        minion.name = "Minion Prefab: " + (this.objects.Count + 1);
        minion.transform.position = this.spawnPos.transform.position;
        minion.gameObject.SetActive(true);

        this.objects.Add(minion);
    }
}
