using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public float mouseSensitivity;

    private float xRotation = 0f;

    public Rigidbody RB;
    public Camera eyes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, xRot, 0);

        float yRot = -Input.GetAxis("Mouse Y") * mouseSensitivity;
        eyes.transform.Rotate(yRot, 0, 0);

        transform.Rotate(0, xRot, 0);

        xRotation += yRot;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        eyes.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Vector3 vel = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            vel = transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            vel = transform.right * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vel = -transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            vel = -transform.right * speed;
        }

        RB.linearVelocity = vel;

        
    }
}
