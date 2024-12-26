using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DropWeapon: MonoBehaviour
{
    public void DropingWeapon()
    {
        if(BulletPool.instance.GetComponent<IBulletType>() != null && Input.GetKeyDown(KeyCode.G)) {

            //we add the enabled to the interface code (i guess you gotta add every attribute manually?)
            BulletPool.instance.GetComponent<IBulletType>().enabled = false;
        }
    }
}
