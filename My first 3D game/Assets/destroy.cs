using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public GameObject object1;
    void Update ()
    {
        Destroy(object1,4f);
	}
}
