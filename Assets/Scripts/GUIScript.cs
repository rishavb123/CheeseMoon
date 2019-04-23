using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour
{
    string text;

    public string[] texts;

    private int index;

    private GUIStyle style;

    private void Start()
    {
        index = 0;
        text = texts[0] + "\nClick N to continue";
        style = new GUIStyle("label");
        style.fontSize = 40;
    }

    private void Update()
    {
        if(Input.GetKeyDown("n"))
        {
            increment(); 
        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0.05f * Screen.width, 10, Screen.width * 0.9f, 100), text, style);
    }

    public void increment()
    {
        if(index < texts.Length)
        {
            text = texts[index] + "\nClick N to continue";
            index++;
        }
    }
}
