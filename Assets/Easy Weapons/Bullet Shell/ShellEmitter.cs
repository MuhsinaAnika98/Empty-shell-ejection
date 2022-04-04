using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShellEmitter : MonoBehaviour
{
    public ParticleSystem obj;
 

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            obj.Emit(1);
        }
        
    }
}
