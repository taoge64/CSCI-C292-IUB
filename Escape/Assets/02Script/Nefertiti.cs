using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nefertiti: MonoBehaviour
{
    public GameObject Command;
    public GameObject CommandKey;
    public GameObject NormalWall;
    private Text CommandText;
    private Text CommandKeyText;
    public float Distance;
    void Start()
    {
        
    }
    void Awake()
    {
    CommandKeyText = CommandKey.GetComponent<Text>();
    CommandText = Command.GetComponent<Text>();
    }
    void Update()
    {
    Distance = Player.TargetDistance;
    if (LocalController.OpenHide){
         NormalWall.SetActive(false);
     }
    }
    // Update is called once per frame
    void OnMouseOver()
        {
        if (Distance < 2)
        {
            CommandKeyText.text = "[e]";
            CommandText.text = "guide you to your destiny";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            NormalWall.SetActive(false);
            if (Input.GetButtonDown("Action"))
            {
            LocalController.setBool(NormalWall);
            //NormalWall.SetActive(false);
            CommandKey.SetActive(false);
            Command.SetActive(false);
            SceneManager.LoadScene("Door2INFO4");
            //StartCoroutine(ChangeScene());
            }
        }
        else
        {
                CommandKey.SetActive(false);
                Command.SetActive(false);
                NormalWall.SetActive(true);
        }
        }
            void OnMouseExit()
        {
            CommandKey.SetActive(false);
            Command.SetActive(false);
        }
    IEnumerator ChangeScene(){
        Debug.Log("we changed the scene");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("02Scene");
    }
}
