using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    GameObject stageBtn2;
    GameObject stageBtn3;
    GameObject stageBtnBoss;

    public void Reset()
    {
        //변수 초기화
        PlayerController.stars = 0;
        PlayerController.clearStage = 0;
        PlayerController.hp = 100;
        PlayerController.power = 1;
        PlayerController.shield = 0;

        //스테이지 버튼 비활성화
        this.stageBtn2.GetComponent<Button>().interactable = false;
        this.stageBtn3.GetComponent<Button>().interactable = false;
        this.stageBtnBoss.GetComponent<Button>().interactable = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.stageBtn2 = GameObject.Find("StageBtn2");
        this.stageBtn3 = GameObject.Find("StageBtn3");
        this.stageBtnBoss = GameObject.Find("StageBtnBoss");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
