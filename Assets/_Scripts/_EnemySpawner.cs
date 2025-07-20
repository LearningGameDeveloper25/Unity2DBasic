using System.Collections.Generic;
using UnityEngine;

public class _EnemySpawner : Spawner
{
    protected float zEnemy = -5f;

    private void Awake()
    {
        this.objects = new List<GameObject>();
        this.spawnPos = GameObject.Find(this.spawnPosName);
        this.objPrefab = GameObject.Find(this.prefabName);
        //this.objPrefab.SetActive(false);

        Vector3 v3 = this.spawnPos.transform.position;
        v3.z = zEnemy;
        this.spawnPos.transform.position = v3;
    }

    private void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime < spawnDelay) return;
    }

    private void Reset()
    {
        this.spawnPosName = "EnemySpawnPos";
        this.prefabName = "EnemyPrefab";
    }

    protected override void Spawn()
    {
        if (_PlayerController.instance._damgeReceiver.IsDead()) return;
        if (this.objects.Count >= this.maxObj) return;

        // Nếu không có sẽ tạo ra quá nhiều cùng lúc, dẫn tới collecsion là enemyPrefab, không có hàm 
        // Receive() --> lỗi. 
        spawnTime = 0;
        GameObject enemy = Instantiate(objPrefab);
        enemy.transform.position = this.spawnPos.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);
        this.objects.Add(enemy);
    }
}
