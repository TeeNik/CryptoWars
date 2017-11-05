﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerInfo : NetworkBehaviour
{

    int coin;
    int energy;

    public GameObject obj;
    public Transform place;

    private void Start()
    {
        Field.Spawn += CmdSpawnFromPlayer;
    }

    private void Update()
    {
        /*if (!isLocalPlayer)
        {
            return;
        }*/

    }

    [Command]
    public void CmdSpawnFromPlayer(EnemySpawnObject ob)
    {
        if (!isLocalPlayer || isServer)
        {
            return;
        }
        print(isServer);
        var clone = (GameObject)Instantiate(ResourceManager.getCharacter(ob.type.ToString()), EnemySpawner.getField(ob.field).position, EnemySpawner.getField(ob.field).rotation);
        clone.GetComponent<Enemy>().ChangeDirection();
        NetworkServer.Spawn(clone);
    }

    public void test(EnemySpawnObject ob)
    {
        /*if (!isLocalPlayer)
        {
            return;
        }
        CmdSpawnFromPlayer(ob);*/
    }



}