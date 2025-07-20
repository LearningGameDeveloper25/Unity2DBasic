using UnityEngine;

public class _FollowPlayer : MonoBehaviour
{
    protected Transform player;
    protected float speed = 25f;
    protected float disLimit = 5f;

    protected float xEnemy = 0f;

    private void Awake()
    {
        this.xEnemy = Random.Range(-6, 6);
    }

    private void Start()
    {
        this.player = _PlayerController.instance.transform;
    }

    private void FixedUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer() 
    {
        Vector3 pos = this.player.position;
        // Create a vector3 cùng hướng với player.
        pos.x = this.xEnemy;

        Vector3 distance = pos - this.transform.position;
        // distance.magnitude is the distance between the player and the object.
        if (distance.magnitude >= this.disLimit)
        {
            // distance.normalized là 1 vector cùng hướng độ dài bằng 1.
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            // MoveTowards di chuyển object tới điểm targetPoint với tốc độ giới hạn.
            // newPos = start + hướng dịch chuyển (targetPoint) * tốc độ giới hạn (maxDistanceDelta).
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
