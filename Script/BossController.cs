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
        //hp 0���� �۰ų� ������ ����Ŭ����
        if (bossHp <= 0)
        {
            //���ӿ���â���� �̵�
            SceneManager.LoadScene("Clear");

            //hp �ʱ�ȭ
            bossHp = 100;
            PlayerController.hp = 100;
        }
    }
}
