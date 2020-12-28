using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transfer : MonoBehaviour
{
    public GameObject GameName;
    public GameObject Company;
    private Animator GameNameAnimator;
    private Animator CompanyAinamtor;
    // Start is called before the first frame update
    void Start()
    {
        GameNameAnimator = GameName.GetComponent<Animator>();
        CompanyAinamtor = Company.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(fadeout());
        GameNameAnimator.SetTrigger("Fade_out");
        CompanyAinamtor.SetTrigger("Fade_out");
    }

    IEnumerator fadeout(){
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainScene");
    }
}
