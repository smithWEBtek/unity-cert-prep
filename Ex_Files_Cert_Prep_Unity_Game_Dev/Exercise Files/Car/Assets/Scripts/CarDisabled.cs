using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDisabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Car = GameObject.Find("FamilyCar");
        print("*********** the family car **************: " + Car);
        Rigidbody Body = Car.GetComponent<Rigidbody>();
        Body.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
