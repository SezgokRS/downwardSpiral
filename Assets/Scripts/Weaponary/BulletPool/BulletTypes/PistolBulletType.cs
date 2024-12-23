using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletType : MonoBehaviour, IBulletType
{
    int bulletCount;
    public void ShootBullet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = BulletPool.instance.GetPooledBullet();

            if (bullet != null)
            {
                bullet.transform.position = ControllerPlayer.instance.transform.localPosition;
                bullet.transform.rotation = ControllerPlayer.instance.transform.rotation;
                bullet.transform.Rotate(0, 0, 270);
                bullet.SetActive(true);
            }
        }
    }
}
