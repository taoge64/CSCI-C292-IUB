using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad02: MonoBehaviour
{
    public GameObject InputPassword;
    private Text InputPasswordText;
    public GameObject Door;
    private string entered = "";
    private string password = "3752";
    private OpenDoorV1Finished doorObject;
    // Start is called before the first frame update
    void Start()
    {
        InputPasswordText = InputPassword.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        InputPasswordText.text = entered;
        doorObject = Door.GetComponent<OpenDoorV1Finished>();
       
    }

    public void enter(string enter){
        if (enter != "C" && enter != "E")
        {
            entered += enter;            
        }else if (enter == "C"){
            entered = "";
        }else{
            if (entered == password)
            {
                doorObject.sloved();
            }
        }
    }
}
