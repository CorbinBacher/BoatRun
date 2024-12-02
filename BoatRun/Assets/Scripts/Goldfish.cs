using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Goldfish : MonoBehaviour
{

   [SerializeField] private AudioClip point;
   bool canCollect = false;

   
    void FixedUpdate()
    {
        canCollect = true;
    }
    
    // Start is called before the first frame update

 
    void Collect()
    {
        if(!canCollect)
        {
            return;
        }

        SoundManager.instance.PlaySound(point);
        Destroy(this.gameObject);
        ScoreController.instance.AddPoint();

        
    }
    void OnTriggerEnter2D(Collider2D other){
      
        if(other.CompareTag("Player")){
            Debug.Log("Collected!");
            Collect();
            
        }
        Debug.Log("Gold");
    }



}
