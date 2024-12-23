using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BulletDestroyer")
        {
            gameObject.SetActive(false);
        }
    }
}
