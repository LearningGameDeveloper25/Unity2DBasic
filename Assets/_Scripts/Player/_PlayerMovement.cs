using UnityEngine;

// Tự động add khi chạy, phòng tránh trường hợp quên.
[RequireComponent(typeof(Rigidbody2D))]
public class _PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb2d;
    public Vector2 velocity = new Vector2(0f, 0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    public float speedUp = 0.5f;
    public float speedMax = 5f;
    public float speedDown = 0.3f;
    public float speedHorizontal = 4f;
    public bool autoRun = false;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        pressHorizontal = Input.GetAxis("Horizontal");
        pressVertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }


    protected virtual void UpdateSpeed()
    {
        if (autoRun)
        {
            this.pressVertical = 1;
        }
        this.velocity.x = this.pressHorizontal * speedHorizontal;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();

        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }


    protected virtual void UpdateSpeedUp()
    {
        if (this.pressVertical <= 0) return;

        this.velocity.y += this.speedUp;
        if (this.velocity.y > speedMax) this.velocity.y = speedMax;

        if (transform.position.x > 7 || transform.position.x < -7)
        {
            this.velocity.y -= 1f;
            if (this.velocity.y < 3f) this.velocity.y = 3f;
        }
    }

    protected virtual void UpdateSpeedDown()
    {
        if (this.pressVertical != 0) return;

        if (this.velocity.y > 0) this.velocity.y -= speedDown;
        else this.velocity.y = 0;
    }
}
