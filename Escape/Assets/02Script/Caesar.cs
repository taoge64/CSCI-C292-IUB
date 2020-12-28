using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Caesar: MonoBehaviour
{
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
            CommandKeyText.text = "[e]";
            CommandText.text = "King have word to say";
            CommandKey.SetActive(true);
            Command.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
                LocalController.setBool4();
            CommandKey.SetActive(false);
            Command.SetActive(false);
            SceneManager.LoadScene("Door2INFO3");
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
    IEnumerator ChangeScene(){
        Debug.Log("we changed the scene");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("02Scene");
    }
}
