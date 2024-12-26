using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    #region singletonSetup
    public static ControllerPlayer instance { get; private set; }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    #endregion

    public float speed;
    public int bulletAmount;
    ModelPlayer modelPlayer = new ModelPlayer();
    ViewPlayer viewPlayer = new ViewPlayer();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        modelPlayer.TravelPlayer(speed);
        modelPlayer.Fire();
    }
}
