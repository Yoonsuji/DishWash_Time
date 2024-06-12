using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon_Player : MonoBehaviour
{
    public int maxHP;
    public int currentHP;

    void Start()
    {
        currentHP = maxHP;
    }
}
