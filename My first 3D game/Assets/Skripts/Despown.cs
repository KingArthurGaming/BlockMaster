using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despown : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
       
    {
        
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject); //other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Object"))
        {
            Destroy(other.gameObject);
        }
    }
}
