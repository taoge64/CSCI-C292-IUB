using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float TargetDistance;
    public float Distance;
    public static bool hold;
    // Start is called before the first frame update
    void Start()
    {
        hold = false;
    }

    // Update is called once per frame
 void Update()
    {   RaycastHit objectHit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out objectHit))
        {
            Distance = objectHit.distance;
            TargetDistance = Distance;
        }
    }

 public static void changeholding(){
     hold = !hold;
 }
}
