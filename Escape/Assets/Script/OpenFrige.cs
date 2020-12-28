using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenFrige : MonoBehaviour
{
    
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    public GameObject frige;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        CommandKeyText = CommandKey.GetComponent<Text>();
        CommandText = Command.GetComponent<Text>(); 
        animator = frige.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.TargetDistance;
    }

    void OnMouseOver(){
        if(Distance < 1){
            CommandKeyText.text = "[e]";
            CommandText.text = "Open The Frige";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                CommandKey.SetActive(false);
                Command.SetActive(false);
                animator.SetTrigger("Open");
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
