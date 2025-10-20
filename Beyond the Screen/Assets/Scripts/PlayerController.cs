using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody2D RB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            vel.y = speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            vel.x = speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vel.y -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            vel.x -= speed;
        }

        RB.linearVelocity = vel;

        //if(tag.Equals("Coin") = null)
        //{
            
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }
}
