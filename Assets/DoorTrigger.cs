using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        GameObject parent = transform.parent.gameObject;       
        Animation animation = parent.GetComponent<Animation>();       
        animation.Play("OpenDoor");
    }
}
