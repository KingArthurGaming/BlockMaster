using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown1 : MonoBehaviour {

    public GameObject Gem50;
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
            Gems = Random.Range(0, 60);
            

            transform.position = spown.position + Setting;

            Vector3 spownPosition = new Vector3(Random.Range(-spownValues.x, spownValues.x), 1, Random.Range(-spownValues.z, spownValues.z));

            if (Gems == 1|| Gems == 2)
            {
                Instantiate(Gem50, transform.position + spownPosition, Quaternion.identity);
            }
            //Instantiate(enemies, transform.position + spownPosition, Quaternion.identity);
            // Instantiate(enemies[randenemy], spownPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spownwait);

        }

    }

}
