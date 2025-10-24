using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour
{
    public float speed;

    Rigidbody2D RB;
    GameManager gm;

    public float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = speed;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = speed;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            vel.y -= speed;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x -= speed;
        }

        RB.linearVelocity = vel;

        timer -= Time.deltaTime;

        if (timer < 1)
        {
            //gm.Score += 250;
            SceneManager.LoadScene(3);
            Debug.Log("I Win");
            FindFirstObjectByType<TimeBar>().ResetTimer();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("MovingBox"))
        {
            SceneManager.LoadScene(2);
            Destroy(gameObject);
            Debug.Log("Im dead");
        }
    }
}
