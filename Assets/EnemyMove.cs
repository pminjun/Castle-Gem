using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public int nextMove;

    public float hp;
    public float attackPower;

    public List<GameObject> Target1 = new List<GameObject>();
    int index1;

    Animator attackAnim;

    public MonsterNum spawn;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

        hp = 100;
        attackPower = 1;

        index1 = Random.Range(0, 17);
        attackAnim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target1[index1].transform.position, Random.Range(0.005f, 0.02f)); //0.01f
        Debug.Log(Target1[index1].transform.position);
        if ((int)transform.position.y == (int)Target1[index1].transform.position.y)
        {
            attackAnim.SetBool("isAttack", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet1")
        {
            hp = hp - 30;
            Destroy(collision.gameObject);
        }
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
