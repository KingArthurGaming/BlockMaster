using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour {

    public GameObject enemies;
    public GameObject Gem1;
    public GameObject Gem5;
    public Vector3 spownValues;
    public float spownwait;
    public float spownMustwait;
    public float spownleastwait;
    public int startwait;
    public bool stop;
    public Transform spown;
    public Vector3 Setting;
    //float XY = 0f;
    int randenemy;
    int Gems;
    void Start () {
        StartCoroutine(waitspowner());
	}
	
	void Update ()
    {
        
        spownwait = Random.Range(spownleastwait, spownMustwait);
	}
    IEnumerator waitspowner()
    {
        yield return new WaitForSeconds(startwait);
        while (!stop)
        {
            randenemy = Random.Range(0, 14);

            transform.position = spown.position + Setting;

            Vector3 spownPosition = new Vector3(Random.Range(-spownValues.x, spownValues.x), 1.5f, Random.Range(-spownValues.z, spownValues.z));

            if (randenemy == 9 || randenemy == 1|| randenemy == 7 || randenemy == 13 || randenemy == 3 || randenemy == 6 || randenemy == 5|| randenemy == 10 || randenemy == 12)
            {
                Instantiate(enemies, transform.position + spownPosition, Quaternion.identity);
            }
             
             if (randenemy == 4|| randenemy == 2 || randenemy == 8 || randenemy == 12)
            {
                Instantiate(Gem1, transform.position + spownPosition, Quaternion.identity);
            }

            if (randenemy == 0)
            {
                Instantiate(Gem5, transform.position + spownPosition, Quaternion.identity);
            }
           
            //Instantiate(enemies, transform.position + spownPosition, Quaternion.identity);
            // Instantiate(enemies[randenemy], spownPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spownwait);

        }

    }

}
