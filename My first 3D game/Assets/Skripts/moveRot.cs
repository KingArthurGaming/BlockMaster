using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRot : MonoBehaviour {
    
    
    void Update () {
        
        transform.Rotate(0.3f, 0.3f, 0.3f * Time.deltaTime);
	}
}
