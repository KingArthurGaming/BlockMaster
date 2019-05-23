using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newposicion : MonoBehaviour {

    public Transform player;
    public Vector3 Setting1;
    void Start()
    {
        //Debug.Log(player.position);	
        transform.position = player.position + Setting1;
    }

    }

