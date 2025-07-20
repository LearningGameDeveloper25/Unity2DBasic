//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerPosition : MonoBehaviour
//{
//    int maxMinions = 7;
//    List<GameObject> minionList;
//    public GameObject minionPrefab;
//    protected float spawnTimer = 0f;
//    protected float spawnDelay = 1f;

//    private void Start()
//    {
//        minionList = new List<GameObject>();
//    }

//    void Update()
//    {
//        this.Spawn();
//        CheckMinionDie();
//    }

//    void Spawn()
//    {
//        spawnTimer += Time.deltaTime;
//        if (this.spawnTimer < this.spawnDelay) return;
//        this.spawnTimer = 0f;

//        if (minionList.Count >= maxMinions) return;

//        GameObject minion = Instantiate(minionPrefab); 
//        minion.name = "Minion Prefab: " + (minionList.Count + 1);
//        minion.transform.position = transform.position;
//        minion.gameObject.SetActive(true);
//        minionList.Add(minion);
//    }

//    private void CheckMinionDie()
//    {
//        for (int i = 0; i < minionList.Count; ++i)
//        {
//            if (minionList[i] == null)
//            {
//                minionList.RemoveAt(i);
//            }
//        }
//    }
//}
