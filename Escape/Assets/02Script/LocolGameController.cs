using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LocolGameController : MonoBehaviour
{
    private static GameController _instance;
    // Start is called before the first frame update
 void OnMouseOver()
        {
        if (Input.GetButtonDown("Action"))
            {
            Debug.Log("I click the e");
            SceneManager.LoadScene("02Scene");
            //StartCoroutine(ChangeScene());
            }
        }
void OnMouseExit()
        {

        }
}
