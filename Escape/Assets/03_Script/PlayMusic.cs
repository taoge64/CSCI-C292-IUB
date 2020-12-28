using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayMusic : MonoBehaviour
{
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    public GameObject acoustic;
    public AudioSource BGM;
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
        if(Distance < 3){
            CommandKeyText.text = "[e]";
            CommandText.text = "Play";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                CommandKey.SetActive(false);
                Command.SetActive(false);
                BGM.Play();
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
