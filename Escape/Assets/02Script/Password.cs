using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Password : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject Command;
    public GameObject CommandKey;
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
    }
    // Update is called once per frame
    void OnMouseOver()
        {
        if (Distance < 2)
        {
            CommandKeyText.text = "hint to leave ";
            CommandText.text = "3752";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
            CommandKey.SetActive(false);
            Command.SetActive(false);
            //StartCoroutine(ChangeScene());
            }
        }
        else
        {
                CommandKey.SetActive(false);
                Command.SetActive(false);
        }
        }
            void OnMouseExit()
        {
            CommandKey.SetActive(false);
            Command.SetActive(false);
        }
}
