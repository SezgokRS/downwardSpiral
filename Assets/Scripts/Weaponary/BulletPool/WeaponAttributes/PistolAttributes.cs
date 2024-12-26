using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PistolAttributes : MonoBehaviour
{
    public int bulletAmount;
    SpriteRenderer spriteRenderer;
    private void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (BulletPool.instance.GetComponent<IBulletType>() == null)
        {
            ControllerPlayer.instance.bulletAmount = bulletAmount;
            BulletPool.instance.AddComponent<PistolBulletType>();
            spriteRenderer.enabled = false;
        }
        else
        {
            Debug.Log("Already equipped with smthn");
        }
    }
}
