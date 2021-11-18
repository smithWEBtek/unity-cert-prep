using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float RotSpeed = 90f;
    private Transform ThisTransform = null;

    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horz = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");

        ThisTransform.position += ThisTransform.forward * MoveSpeed * Time.deltaTime * Vert;
        ThisTransform.rotation *= Quaternion.Euler(0f,RotSpeed * Time.deltaTime * Horz,0f);
    }
}
