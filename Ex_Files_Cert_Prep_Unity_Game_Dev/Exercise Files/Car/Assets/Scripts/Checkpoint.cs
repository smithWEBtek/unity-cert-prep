using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{

    public Text UIText = null;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        UIText.text = "Checkpoint reached!";
    }
}
