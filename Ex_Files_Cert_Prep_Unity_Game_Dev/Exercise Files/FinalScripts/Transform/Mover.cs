using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Speed = 5f;
    private Transform ThisTransform = null;

    private void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        ThisTransform.position += ThisTransform.forward * Speed * Time.deltaTime;
    }
}
