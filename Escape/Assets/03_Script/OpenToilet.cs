using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenToilet : MonoBehaviour
{
    
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;

    public GameObject key;

    public GameObject ToiletClose;
    
    public GameObject ToiletOpen;
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
    }

    void OnMouseOver(){
        if(Distance < 2){
            CommandKeyText.text = "[e]";
            CommandText.text = "Open Toilet";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                ToiletClose.SetActive(false);
                ToiletOpen.SetActive(true);
                key.SetActive(true);
                CommandKey.SetActive(false);
                Command.SetActive(false);
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
