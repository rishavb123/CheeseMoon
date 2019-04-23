using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    private GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        style = new GUIStyle("label");
        style.fontSize = 40;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        
        if(GUI.Button(new Rect(0.25f * Screen.width, Screen.height * 0.3f, Screen.width * 0.5f, Screen.height * 0.1f), "Play", style))
        {
            SceneManager.LoadScene("Scene1");
        }
        if (GUI.Button(new Rect(0.25f * Screen.width, Screen.height * 0.5f, Screen.width * 0.5f, Screen.height * 0.1f), "Quit", style))
        {
            Application.Quit();
        }
    }
}
