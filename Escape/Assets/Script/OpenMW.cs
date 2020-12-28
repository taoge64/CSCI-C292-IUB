using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMW : MonoBehaviour
{
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    public GameObject MW;
    private Animator animator;
    private bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        CommandKeyText = CommandKey.GetComponent<Text>();
        CommandText = Command.GetComponent<Text>(); 
        animator = MW.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.TargetDistance;
    }

    void OnMouseOver(){
        if(Distance < 1 && !open){
            CommandKeyText.text = "[e]";
            CommandText.text = "Open";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                CommandKey.SetActive(false);
                Command.SetActive(false);
                animator.SetTrigger("Open");
                open = true;
            }
        }else if(Distance < 1 && open){
            CommandKeyText.text = "[e]";
            CommandText.text = "Close";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                CommandKey.SetActive(false);
                Command.SetActive(false);
                animator.SetTrigger("Close");
                open = false;
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
