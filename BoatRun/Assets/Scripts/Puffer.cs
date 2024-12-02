using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puffer : MonoBehaviour
{
    [SerializeField] private AudioClip buzz;
    bool canCollect = false;

    void FixedUpdate()
    {
        canCollect = true;
    }
 
    void Collect()
    {
        if(!canCollect)
        {
            return;
        }

        SoundManager.instance.PlaySound(buzz);
        Destroy(this.gameObject);
        Timer.instace.subTime(2);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Puffer");
            Collect();
        }
    }

    
}
