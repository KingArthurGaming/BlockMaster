using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciq : MonoBehaviour {

    public Animator ani;
    public AudioClip Sound;
 
public void Start()
    {
        ani.enabled = false;
    }

    public void OnTriggerEnter(Collider Player)
    {
        AudioSource.PlayClipAtPoint(Sound, transform.position);
        ani.enabled = true;
        Destroy(gameObject);
    }
}
