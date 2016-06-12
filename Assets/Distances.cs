using UnityEngine;
using System.Collections;

public class Distances : MonoBehaviour {
    public Transform taget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        a();
        b(a());
    }

    public float a()
    {
        float dis = Vector3.Distance(taget.position, transform.position);
        return dis;
    }

    void b(float g)
    {
        Debug.Log("Distance : " + g);
    }
}
