using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadTip : MonoBehaviour
{
    public float Distance;
    public GameObject CommandKey;
    private Text CommandKeyText;
    public GameObject Command;
    private Text CommandText;
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
        if(Distance < 1){
            CommandText.text = "1.Under The Buger \n 2.Heat the Pan \n 3. Nummber of steak \n 4. Press the One";
            Command.SetActive(true);
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
