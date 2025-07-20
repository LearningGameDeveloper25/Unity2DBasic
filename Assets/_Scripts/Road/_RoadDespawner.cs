using UnityEngine;

public class _RoadDespawner : MonoBehaviour
{
    protected float distance = 0f;

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector3.Distance(_PlayerController.instance.transform.position, this.transform.position);
        if (this.distance > 40)
        {
            this.Despawn();
        }
    }

    protected virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
