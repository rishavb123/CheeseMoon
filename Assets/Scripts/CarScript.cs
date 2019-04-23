using UnityEngine;
using UnityEngine.SceneManagement;
public class CarScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Scene2");
    }
}
