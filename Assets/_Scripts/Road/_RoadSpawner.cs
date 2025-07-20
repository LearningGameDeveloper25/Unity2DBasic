using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class _RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefab;
    protected GameObject roadPos;
    protected float distance = 0;
    protected GameObject currentRoadPrefab;
    protected int roadLayerOrder = 0;

    private void Awake()
    {
        this.roadPrefab = GameObject.Find("RoadPrefab");
        this.roadPos = GameObject.Find("RoadPos");
        this.currentRoadPrefab = this.roadPrefab;
        this.roadPrefab.SetActive(false);
        //this.roadLayerOrder = (int) this.roadPrefab.transform.position.z;

        this.Spawn(this.roadPrefab.transform.position);
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();  
    }

    protected virtual void UpdateRoad()
    {
        //this.distance = Vector2.Distance(this.currentRoadPrefab.transform.position, _PlayerController.instance.transform.position);
        this.distance = - this.currentRoadPrefab.transform.position.y + _PlayerController.instance.transform.position.y;
        if (this.distance > 6) this.Spawn();
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadPos.transform.position;
        pos.x = 0;
        this.Spawn(pos);
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.currentRoadPrefab = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.currentRoadPrefab.transform.parent = transform;
        this.currentRoadPrefab.SetActive(true);
    }
}
