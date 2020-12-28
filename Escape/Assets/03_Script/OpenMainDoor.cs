using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenMainDoor : MonoBehaviour
{
    
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    public GameObject door;
    private Animator animator;
    public GameObject keyGameObject;
    private OpenToilet keyObject;
    private GameObject gamecontroller;
    public AudioSource OpenDoor;
    // Start is called before the first frame update
    void Start()
    {
        CommandKeyText = CommandKey.GetComponent<Text>();
        CommandText = Command.GetComponent<Text>(); 
        animator = door.GetComponent<Animator>();
        keyObject = keyGameObject.GetComponent<OpenToilet>();
        gamecontroller = GameObject.FindGameObjectsWithTag("GameController")[0];
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.TargetDistance;
    }

    void OnMouseOver(){
        if(Distance < 3){
            if (keyGameObject.activeSelf) 
            {
                CommandKeyText.text = "[e]";
                CommandText.text = "Open Door";
                CommandKey.SetActive(true);
                Command.SetActive(true);

                if(Input.GetButtonDown("Action"))
                {
                    CommandKey.SetActive(false);
                    Command.SetActive(false);
                    animator.SetTrigger("Open");
                    OpenDoor.Play();
                    SceneManager.LoadScene("MainScene");
                    gamecontroller.GetComponent<GameController>().passDoor3();
                }
            }
            else{
                CommandText.text = "Need A Key";
                Command.SetActive(true);
            }
        }

    }
    void OnMouseExit(){
        CommandKey.SetActive(false);
        Command.SetActive(false);
    }
}
