using UnityEngine;

public class Call : MonoBehaviour
{
    private bool played = false;

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
        if(collision.gameObject.tag == "Player" && !played)
        {
            GetComponent<AudioSource>().Play();            
            played = true;
        }
    }
}
