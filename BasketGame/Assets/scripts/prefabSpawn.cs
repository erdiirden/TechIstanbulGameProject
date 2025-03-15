using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabSpawn : MonoBehaviour
{
    public AudioSource skor;
    float speed = 1f;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "basket")
        {
            skor.Play();
            speed = 0f;
            Invoke("destroyFruit", 1f);
        }
    }

    void Update()
    {
        
        if (gameOver.isGame == true)
        {
            speed = 0f;
        }
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void destroyFruit()
    {
        Destroy(gameObject);
    }
}
