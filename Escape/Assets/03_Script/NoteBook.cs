using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NoteBook : MonoBehaviour
{
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    private Animator animator;
    public GameObject PencilGameObject;
    private Pencil PencilObject;
    public GameObject noteBookTop;
    public GameObject noteBook;
    public GameObject HoldNoteBook;
    // Start is called before the first frame update
    void Start()
    {
        CommandKeyText = CommandKey.GetComponent<Text>();
        CommandText = Command.GetComponent<Text>(); 
        animator = noteBookTop.GetComponent<Animator>();
        PencilObject = PencilGameObject.GetComponent<Pencil>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.TargetDistance;
    }

    void OnMouseOver(){
        if(Distance < 3){
            CommandKeyText.text = "[e]";
            CommandText.text = "Open Notebook";
            CommandKey.SetActive(true);
            Command.SetActive(true);            
            if(Input.GetButtonDown("Action"))
                {
                    CommandKey.SetActive(false);
                    Command.SetActive(false);
                    animator.SetTrigger("OpenBook");
                }
            if(PencilGameObject.activeSelf)
                {
                        CommandKey.SetActive(true);
                        Command.SetActive(true);
                        CommandKeyText.text = "[e]";
                        CommandText.text = "Use Pencil";
                        if(Input.GetButtonDown("Action"))
                        {
                        CommandKey.SetActive(false);
                        Command.SetActive(false);
                        noteBookTop.SetActive(false);
                        noteBook.SetActive(false);
                        HoldNoteBook.SetActive(true);
                        PencilGameObject.SetActive(false);
                        }      
                }
            }
        }
        void OnMouseExit(){
        CommandKey.SetActive(false);
        Command.SetActive(false);
        }
}
