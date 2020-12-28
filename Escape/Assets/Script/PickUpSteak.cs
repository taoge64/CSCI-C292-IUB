using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpSteak : MonoBehaviour
{
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    public GameObject worldSteak;
    public GameObject playerSteak;
    private bool status;
    // Start is called before the first frame update
    void Start()
    {
        CommandKeyText = CommandKey.GetComponent<Text>();
        CommandText = Command.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.TargetDistance;
        status = Player.hold;
    }

    void OnMouseOver(){
        if(Distance < 1 && !status){
            CommandKeyText.text = "[e]";
            CommandText.text = "Pick Up Steak";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                worldSteak.SetActive(false);
                playerSteak.SetActive(true);
                CommandKey.SetActive(false);
                Command.SetActive(false);
                Player.changeholding();
            }
        }else{
            CommandKey.SetActive(false);
            Command.SetActive(false);
        }
    }
    void OnMouseExit(){
        CommandKey.SetActive(false);
        Command.SetActive(false);
    }
}
