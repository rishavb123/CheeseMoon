using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject player;

    private float theta = 0;
    private float phi = 0;
    private float r = 2f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        theta += 5 * Input.GetAxis("Mouse X");
        phi -= 3 * Input.GetAxis("Mouse Y");

        if (Input.GetKeyDown("q"))
            theta -= 180;

        if (phi > 20)
            phi = 20;
        else if (phi < -40)
            phi = -40;
        transform.eulerAngles = new Vector3(phi, theta, 0);
        transform.position = player.transform.position - r * new Vector3(Mathf.Sin(theta / 180 * Mathf.PI), -1.4f / r, Mathf.Cos(theta / 180 * Mathf.PI));
       

    }
}
