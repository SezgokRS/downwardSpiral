using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MachineGunAttributes : MonoBehaviour
{
    public int bulletCount = 40;
    SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (BulletPool.instance.GetComponent<IBulletType>() == null)
        {
            ControllerPlayer.instance.bulletAmount = bulletCount;
            BulletPool.instance.AddComponent<MachineGunBulletType>();
            _spriteRenderer.enabled = false;
        }
        else
        {
            Debug.Log("Already equipped with smthn");
        }
    }
}
