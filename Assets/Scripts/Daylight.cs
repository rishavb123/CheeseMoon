using UnityEngine;
using UnityEngine.SceneManagement;

public class Daylight : MonoBehaviour
{

    private float speed = 10f;
    private bool firstTime = true;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(Time.deltaTime * speed, 0, 0);
        if(Input.GetKeyDown("r"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetKeyDown("g"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = !GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity;
        }
        if(Input.GetKeyDown("b"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().AddForce(20 * (Camera.main.transform.forward.normalized), ForceMode.Impulse);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
