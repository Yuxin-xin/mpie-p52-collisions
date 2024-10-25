using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("AmmoBox")){
            ammoCount += 20;
            other.gameObject.SetActive(false);
        }
    }

    void Update(){
        if(Input.GetButtonDown("Fire1") && ammoCount > 0){

            Shoot();

        }
    }

    void Shoot(){
        Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
        RaycastHit result; 
        Physics.Raycast(ray, out result);
        
            // 检查是否击中了目标
            GameObject g = result.collider.gameObject;
            Animation a = g.transform.parent.GetComponent<Animation>();
            a.Play("LowerBridge");
    
        }
}
