using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    public Vector3 rec;
    Vector3 originalPos;

    void Start()
    {
        originalPos = transform.localEulerAngles;
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {

            AddRecoil();
       
        }
                
         else 
        {

            stopRecoil();
        }
                    
                    
}
    void AddRecoil()
    {

        transform.localEulerAngles += rec;
        Debug.Log("Fire");
    }

    void stopRecoil()
    {
        transform.localEulerAngles = originalPos;

    }
        
   }
