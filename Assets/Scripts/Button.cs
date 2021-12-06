using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("box"))
        {
            objectToDisable.SetActive(false);
            objectToEnable.SetActive(true);
            Debug.Log("DoorActivated");
        }
    }
}
