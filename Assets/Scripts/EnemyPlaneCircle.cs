using NUnit.Framework.Interfaces;
using UnityEngine;

public class EnemyPlaneCircle : BaseEnemy
{

    void Start()
    {
        InvokeRepeating("ShootBullet", 1f, 1.3f);
    }





}
