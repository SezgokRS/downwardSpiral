using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelBulletPool
{
    /*MODEL WILL BE FIXED TO FIT SOLID PRINCIPLES*/
    public List<GameObject> SetupList(int bulletAmount, GameObject bulletPrefab, List<GameObject> pooledBullets) 
    {
        for (int i = 0; i < bulletAmount; i++)
        {
            GameObject obj = Object.Instantiate(bulletPrefab);
            obj.SetActive(false);
            pooledBullets.Add(obj);
        }
        return pooledBullets;
    }
    public GameObject GetPooledBullet(List<GameObject> pooledBullets)
    {
        for (int i = 0; i < pooledBullets.Count; i++)
        {
            if (!pooledBullets[i].activeInHierarchy)
            {
                return pooledBullets[i];
            }
        }
        return null;

    }
}
