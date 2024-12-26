using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
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

    ModelBulletPool modelBulletPool = new ModelBulletPool();
    ViewBulletPool viewBulletPool = new ViewBulletPool();

    [SerializeField] GameObject bulletPrefab;

    private IBulletType bulletType;
    private DropWeapon dropWeapon;
    void Start()
    {
        pooledBullets = modelBulletPool.SetupList(bulletAmount, bulletPrefab, pooledBullets);
        dropWeapon = new DropWeapon();
    }
    void Update()
    {
        dropWeapon.DropingWeapon();
    }

    public GameObject GetPooledBullet()
    {
        return modelBulletPool.GetPooledBullet(pooledBullets);
    }
}
