﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler {

    public delegate void DamagePlayer(float damage);
    public delegate void SpawnFromPlayer(EnemySpawnObject clone);

}
