using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    Vector3 dir;
    GameObject player;

    //������ ������ �����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            //BossStageDirector�� �浹 �˸�
            GameObject director = GameObject.Find("BossStageDirector");
            director.GetComponent<BossStageDirector>().DecreaseBossHp();
            //�Ѿ� ����
            Destroy(gameObject);
            //hp �پ��
            BossController.bossHp -= PlayerController.power;
            Debug.Log(BossController.bossHp);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        dir = this.player.GetComponent<PlayerController>().getVec();
    }

    // Update is called once per frame
    void Update()
    {
        //ĳ���Ͱ� ���� �������� �Ѿ� �߻�
        transform.Translate(dir * 0.1f);


        //ȭ�� ������ ������ �Ѿ� ����
        if (transform.position.x < -9.0f || transform.position.x > 9.0f
            || transform.position.y < -5.5f || transform.position.y > 5.5f)
            Destroy(gameObject);
    }
}
