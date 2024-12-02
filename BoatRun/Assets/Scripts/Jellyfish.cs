using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    [SerializeField] private AudioClip time;
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

        SoundManager.instance.PlaySound(time);
        Destroy(this.gameObject);
        Timer.instace.addTime(3);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Jelly");
            Collect();
        }
    }

    
}