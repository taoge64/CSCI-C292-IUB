using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalController : MonoBehaviour
{
    public static bool OpenHide;
    public static bool Opena;
    public static bool Openb;
    public static bool Openc;
    //public static GameObject NormalWall;

    public static void setBool(GameObject NormalWall){
        OpenHide=true;
        NormalWall.SetActive(false);
    }
    public static void setBool2(){
        Opena=true;
    }
    public static void setBool3(){
        Openb=true;
    }
     public static void setBool4(){
        Openc=true;
    }
    
}
