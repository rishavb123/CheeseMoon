using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class BigCheeseDisplay : MonoBehaviour
{
    bool happened = false;
    bool happened2 = false;

    VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("l"))
        {
            videoPlayer = FindObjectOfType<Camera>().GetComponent<VideoPlayer>();
            videoPlayer.url = "file://C:/Projects/UnityProjects/Cheese Moon/Assets/Resources/ending.mp4";
            videoPlayer.Play();
            videoPlayer.loopPointReached += EndReached;
        }

        if (transform.position.y < -300 && !happened2)
        {
            transform.position = Vector3.Scale(transform.position, new Vector3(1, 0, 1)) + new Vector3(0, 100, 0);
            transform.localScale = new Vector3(20, 20, 20);
            Destroy(GetComponent<Rigidbody>());
            videoPlayer = FindObjectOfType<Camera>().GetComponent<VideoPlayer>();
            videoPlayer.loopPointReached += EndReached;
            videoPlayer.Play();
            happened2 = true;
        }
    }

    void EndReached(VideoPlayer vp)
    {
        vp.Stop();
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
