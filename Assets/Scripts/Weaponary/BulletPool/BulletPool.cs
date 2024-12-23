using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    #region singletonSetup
    public static BulletPool instance { get; private set; }
    private void Awake()
    {
        if(instance != null && instance != this) Destroy(instance);
        else instance = this;
    }

    #endregion

    private List<GameObject> pooledBullets = new List<GameObject>();
    private int bulletAmount = 20;

    [SerializeField] GameObject bulletPrefab;

    private IBulletType bulletType;
    void Start()
    {
        for(int i = 0; i < bulletAmount; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            pooledBullets.Add(obj);
        }
    }

    void Update()
    {

    }

    public GameObject GetPooledBullet()
    {
        for(int i = 0; i < pooledBullets.Count; i++)
        {
            if (!pooledBullets[i].activeInHierarchy)
            {
                return pooledBullets[i];
            }
        }
        return null;
    }


}
