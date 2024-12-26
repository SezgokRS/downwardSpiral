using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunBulletType : MonoBehaviour, IBulletType
{
    float timer = 0;
    [SerializeField] float timeForShootingBullets = 0.2f;
    public void ShootBullet()
    {
        if(Time.time - timer > timeForShootingBullets && Input.GetMouseButton(0))
        {
            GameObject bullet = BulletPool.instance.GetPooledBullet();

            if (bullet != null)
            {
                bullet.transform.position = ControllerPlayer.instance.transform.localPosition;
                bullet.transform.rotation = ControllerPlayer.instance.transform.rotation;
                bullet.transform.Rotate(0, 0, 270);
                bullet.SetActive(true);
                timer = Time.time;
            }
        }
    }
}
