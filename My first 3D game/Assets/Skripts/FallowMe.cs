using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowMe : MonoBehaviour {
    public Transform player;
    public Vector3 Setting; 
    void Update ()
    {
        //Debug.Log(player.position);	
        transform.position = player.position + Setting;
	}
}
