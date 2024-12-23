using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelingPlayer
{
   public void Traveler(float speed)
    {
        float moveAmount = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        ControllerPlayer.instance.gameObject.transform.localPosition += new Vector3(0, moveAmount, 0);
        moveAmount = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        ControllerPlayer.instance.transform.localPosition += new Vector3(moveAmount, 0, 0);
    }

}
