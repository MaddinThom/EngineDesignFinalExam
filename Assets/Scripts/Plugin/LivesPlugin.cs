using UnityEngine;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class LivesPlugin : MonoBehaviour
{
    float l = 1; //holds new speed

    [DllImport("PlayerLives")]
    private static extern float GetLives();

    [DllImport("PlayerLives")]
    private static extern void SetLives(float x);

    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        SetLives(5);
        float l = GetLives();
        text.text = l.ToString();
    }

}

