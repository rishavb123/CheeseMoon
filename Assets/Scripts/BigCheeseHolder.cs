using UnityEngine;

public class BigCheeseHolder : MonoBehaviour
{
    bool happened = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!happened && collision.gameObject.tag == "Player")
        {
            gameObject.AddComponent<Rigidbody>();
            happened = true;
        }
    }
}
