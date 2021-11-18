using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotSpeed = 90f;
    private Transform ThisTransform = null;

    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ThisTransform.rotation *= Quaternion.Euler(0f,RotSpeed * Time.deltaTime,0f);
    }
}
