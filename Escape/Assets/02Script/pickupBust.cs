using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupBust : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject Bust;
    public GameObject HoldBust;
    public void OnMouseDown(){
       GetComponent<BoxCollider>().enabled = false;
       GetComponent<Rigidbody>().useGravity = false;
       transform.position = HoldBust.transform.position;
       transform.parent = HoldBust.transform; 
    }
    public void OnMouseUp(){
        transform.parent = null;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
        Debug.Log("I AM PICKED THE BUST");
    }
}
