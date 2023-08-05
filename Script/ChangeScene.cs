using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //월드1씬으로 이동
    public void GoWord1()
    {
        SceneManager.LoadScene("Word1Scene");
    }
    public void GoStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void GoStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void GoStage3()
    {
        SceneManager.LoadScene("Stage33");
    }
    public void GoBoss()
    {
        SceneManager.LoadScene("Boss");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
