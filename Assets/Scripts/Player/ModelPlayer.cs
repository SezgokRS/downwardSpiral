using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ModelPlayer
{
    ViewPlayer viewPlayer = new ViewPlayer();
    TravelingPlayer traveler = new TravelingPlayer();
    RotationPlayer rotator = new RotationPlayer();
    public void TravelPlayer(float speed)
    {
        traveler.Traveler(speed);
        rotator.Rotator();
    }

    public void Fire()
    {
        BulletPool.instance.GetComponent<IBulletType>().ShootBullet();

    }
}
