using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBulletType
{
    public void ShootBullet();
    public bool enabled { get; set; }
}
