using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class ControlAis : MonoBehaviour
{

    GameObject[] ais;
    bool happened;

    public float r = 100f;

    // Start is called before the first frame update
    void Start()
    {
        happened = false;
        ais = GameObject.FindGameObjectsWithTag("AI");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (GetComponent<AudioSource>().isPlaying)
            {
                GetComponent<AudioSource>().Stop();
            }
            else
            {
                GameObject.FindGameObjectWithTag("Cheese").GetComponent<AudioSource>().Stop();
                GetComponent<AudioSource>().Play();
            }
            Vector3 position = Vector3.Scale(GameObject.FindGameObjectWithTag("Cheese").transform.position, new Vector3(1, 0, 1));
            if(!happened)
                GameObject.FindGameObjectWithTag("CheeseDisplay").transform.position = position - new Vector3(0, 67.2f, 0);
            for (int i = 0; i < ais.Length; i++)
            {
                float theta = 2 * Mathf.PI * i / ais.Length;
                AICharacterControl control = ais[i].GetComponent<AICharacterControl>();
                control.SetPosition(position + r * new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta)));
            }
            happened = true;
        }
        if(happened)
        {
            Vector3 position = Vector3.Scale(GameObject.FindGameObjectWithTag("Cheese").transform.position, new Vector3(1, 0, 1));
            for (int i = 0; i < ais.Length; i++)
            {
                float theta = 2 * Mathf.PI * i / ais.Length;
                AICharacterControl control = ais[i].GetComponent<AICharacterControl>();
                control.SetPosition(position + r * new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta)));
            }
        }
    }

}
