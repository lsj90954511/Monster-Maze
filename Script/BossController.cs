using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{
    public static int bossHp = 100;
    public static int power = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //hp 0보다 작거나 같으면 게임클리어
        if (bossHp <= 0)
        {
            //게임오버창으로 이동
            SceneManager.LoadScene("Clear");

            //hp 초기화
            bossHp = 100;
            PlayerController.hp = 100;
        }
    }
}
