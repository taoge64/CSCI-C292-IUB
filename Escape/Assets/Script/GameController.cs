using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Scene scene;
    private string scenename;
    private string thisScene;
    private string preScene;
    public bool OpenHide=false;
    public bool Opena=false;
    public bool Openb=false;
    public bool Openc=false;
    public bool door1 = false;
    public bool door2 = false;
    public bool door3 = false;
    public bool door4 = false;
    public GameObject finalDoor;
    private static GameController _instance;

    public static GameController Instance{
        get{
            return _instance;
        }
    }

    void Awake(){
        if(_instance == null){
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        thisScene = "MainScene";
        preScene = "MainScene";
        finalDoor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        scenename = scene.name;
        
        if (thisScene != scenename)
        {
            preScene = thisScene;
            thisScene = scenename;
        }
        //02 scene changing stuff
        if (thisScene=="Door2INFO"&&Input.GetButtonDown("Action")){
            Opena=true;
            SceneManager.LoadScene(preScene);
        }
         if (thisScene=="Door2INFO2"&&Input.GetButtonDown("Action")){
             Openb=true;
            SceneManager.LoadScene(preScene);
        }
        if (thisScene=="Door2INFO3"&&Input.GetButtonDown("Action")){
            Openc=true;
            SceneManager.LoadScene(preScene);
        }
        if (thisScene=="Door2INFO4"&&Input.GetButtonDown("Action")){
            OpenHide=true;
            SceneManager.LoadScene(preScene);
        }

        if(door1 && door2 && door3 && door4){
            finalDoor.SetActive(true);
        }
    }
    
    public string getPreviousScene(){
        return preScene;
    }
    public string getCurrentScene(){
        return thisScene;
    }
    public bool getHide(){
        return OpenHide;
    }

    public void passDoor1(){
        door1 = true;
    }
    public void passDoor2(){
        door2 = true;
    }
    public void passDoor3(){
        door3 = true;
    }
    public void passDoor4(){
        door4 = true;
    }
}
