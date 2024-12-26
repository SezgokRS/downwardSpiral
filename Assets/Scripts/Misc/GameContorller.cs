using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContorller : MonoBehaviour
{
    #region SingletonSetup
    public static GameContorller instance;
    private void Awake()
    {
        if (instance != null && instance != this) Destroy(instance);
        else instance = this;
    }
    #endregion
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
