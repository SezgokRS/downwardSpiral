using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer
{
    public void Rotator()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 objectPosition = Camera.main.WorldToScreenPoint(ControllerPlayer.instance.transform.position);

        mousePosition.x -= objectPosition.x;
        mousePosition.y -= objectPosition.y;

        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        ControllerPlayer.instance.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

    }
}
