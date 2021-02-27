﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int[] array = {1, 2, 3, 4, 5};

    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Magic(int magic)
    {
        this.mp -= magic;
        if(mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else if(mp < 5)
        {
            //課題修正点
            mp = mp;
            Debug.Log("MPが足りないため魔法が使えない。");
        } 
        //課題修正点
        else if(mp <= 0)
        {
            mp = 0;
        }
    }

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}
