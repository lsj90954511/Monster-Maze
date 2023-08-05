using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float h;
    float v;
    public float Speed;
    bool isHorizonMove;
    bool attack = false;
    Vector3 playerDir;
    Rigidbody2D rigid;
    Animator anim;
    GameObject star1;
    GameObject star2;
    GameObject star3;
    public static int stars = 0;
    public static int clearStage = 0;
    public static int hp = 100;
    public static int power = 1;
    public static int shield = 0;

    public bool getAttack()
    {
        return attack;
    }
    public float getH()
    {
        return h;
    }
    public float getV()
    {
        return v;
    }
    public Vector3 getVec()
    {
        return playerDir;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.star1 = GameObject.Find("Star1");
        this.star2 = GameObject.Find("Star2");
        this.star3 = GameObject.Find("Star3");
    }

    // Update is called once per frame
    void Update()
    {
        //hp 0보다 작거나 같으면 게임오버
        if (hp <= 0)
        {
            //hp 초기화
            hp = 100;
            BossController.bossHp = 100;

            //게임오버창으로 이동
            SceneManager.LoadScene("GameOver");
        }



        attack = false;

        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //수평 방향으로 이동하는지 수직방향으로 이동하는지 저장
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            isHorizonMove = true;
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            isHorizonMove = false;
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)
            || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
            isHorizonMove = h != 0;

        //캐릭터가 보는 방향 저장
        if (h == 0 && v != 0)
        {
            if (v == 1)
                playerDir = Vector3.up;
            else if (v == -1)
                playerDir = Vector3.down;
        }
        else
        {
            if (h == 1)
                playerDir = Vector3.right;
            else if (h == -1)
                playerDir = Vector3.left;
        }

        //애니메이션
        if (anim.GetInteger("hAxisRaw") != h)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("hAxisRaw", (int)h);
        }
        else if (anim.GetInteger("vAxisRaw") != v)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("vAxisRaw", (int)v);
        }
        else
            anim.SetBool("isChange", false);

        //보스전 총 쏘기
        if (SceneManager.GetActiveScene().name == "Boss")
        {
            if (Input.GetKeyDown(KeyCode.Space))
                attack = true;
        }
    }

    void FixedUpdate()
    {
        //캐릭터 이동
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity = moveVec * Speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //골에 닿으면 월드1씬으로
        if (collision.gameObject.CompareTag("Goal"))
        {
            //this.dontDestroy.GetComponent<DontDestroyObject>().setClearStage(1);
            clearStage = 1;
            SceneManager.LoadScene("Word1Scene");
        }
        else if (collision.gameObject.CompareTag("Goal2"))
        {
            //this.dontDestroy.GetComponent<DontDestroyObject>().setClearStage(1);
            clearStage = 2;
            SceneManager.LoadScene("Word1Scene");
        }
        else if (collision.gameObject.CompareTag("Goal3"))
        {
            clearStage = 3;
            SceneManager.LoadScene("Word1Scene");
        }

        //별에 닿으면 별 지움
        if (collision.gameObject.CompareTag("Star1"))
        {
            Destroy(star1);
            //this.dontDestroy.GetComponent<DontDestroyObject>().plusStars();
            stars++;
            Debug.Log(PlayerController.stars);
        }
        if (collision.gameObject.CompareTag("Star2"))
        {
            Destroy(star2);
            stars++;
            Debug.Log(PlayerController.stars);
        }
        if (collision.gameObject.CompareTag("Star3"))
        {
            Destroy(star3);
            stars++;
            Debug.Log(PlayerController.stars);
        }
    }
}
