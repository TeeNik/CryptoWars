﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerHealth : NetworkBehaviour
{

    [SerializeField]
    float maxHealth;

    float curHealth;



    void Start () {
        curHealth = maxHealth - 20;
    }
	
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }
        ResourceManager.inst.healthBar.fillAmount = curHealth / maxHealth;
    }
}