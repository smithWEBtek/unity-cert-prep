using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text MyText = null;
    private float TimeElapsed = 0f;

    // Start is called before the first frame update
    // Awake always happens first
    void Awake()
    {
        MyText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeElapsed += Time.deltaTime;
        MyText.text = TimeElapsed.ToString("00");
    }
}
