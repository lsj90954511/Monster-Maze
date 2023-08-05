using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    public float x, y;

    //ĳ���Ϳ� ������ �����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //hp ����
            if (PlayerController.shield <= 0)
            {
                //BossStageDirector�� �浹 �˸�
                GameObject director = GameObject.Find("BossStageDirector");
                director.GetComponent<BossStageDirector>().DecreasePlayerHp();
                //hp ���
                PlayerController.hp -= BossController.power;
            }
            else
            {
                PlayerController.shield--;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�Ѿ� �̵�
        transform.Translate(x, y, 0);

        //ȭ�� ������ ������ �Ѿ� ����
        if (transform.position.x < -9.0f || transform.position.x > 9.0f
            || transform.position.y < -5.5f || transform.position.y > 5.5f)
            Destroy(gameObject);
    }
}
