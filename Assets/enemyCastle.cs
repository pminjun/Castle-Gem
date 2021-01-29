using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyCastle : MonoBehaviour
{
    public Slider hpBar;
    public float maxHP;
    public float currentHP;

    void Start()
    {
        maxHP = 100.0f;
        currentHP = 100.0f;
    }

    void Update()
    {
        hpBar.value = currentHP / maxHP;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy1")
        {
            Debug.Log(currentHP);
            currentHP -= 0.1f;
        }
    }

}
