using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterNum : MonoBehaviour
{
    public int num;
    void Start()
    {
        num = Random.Range(1, 5);
    }
}
