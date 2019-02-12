using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickups : MonoBehaviour {

    // C#
    // Instantiates a prefab in a circle

    public GameObject prefab;
    public int numObjects = 12;
    public float radius = 4.8f;
    private Vector3 origin = new Vector3(0, 0.5f, 0);
    void Start()
    {

        for (int i = 0; i < numObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numObjects;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            GameObject pickup = Instantiate(prefab, origin + pos, Quaternion.identity);

            switch(i % 3 + 1)
            {
                case 1:
                  pickup.tag = "cyanCube";
                  pickup.GetComponent<Renderer>().material.color = Color.cyan;
                  break;

                case 2:
                pickup.GetComponent<Renderer>().material.color = Color.red;
                pickup.tag = "redCube";
                break;

                case 3:
                pickup.GetComponent<Renderer>().material.color = Color.magenta;
                pickup.tag = "magentaCube";
                break;

            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
