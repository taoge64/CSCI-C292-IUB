using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
    public GameObject door;
    private Animator animator;
    private bool can = false;
    private GameObject gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        CommandKeyText = CommandKey.GetComponent<Text>();
        CommandText = Command.GetComponent<Text>(); 
        animator = door.GetComponent<Animator>();
        gamecontroller = GameObject.FindGameObjectsWithTag("GameController")[0];
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Player.TargetDistance;
        Debug.Log(can);
    }

    void OnMouseOver(){
        if(Distance < 1 && can){
            CommandKeyText.text = "[e]";
            CommandText.text = "Open The Door";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if(Input.GetButtonDown("Action")){
                CommandKey.SetActive(false);
                Command.SetActive(false);
                StartCoroutine(opening());
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

    IEnumerator opening(){
        animator.SetTrigger("Open");
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("MainScene");
        gamecontroller.GetComponent<GameController>().passDoor1();
    }

    public void sloved(){
        can = true;
    }
}
