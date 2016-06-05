using UnityEngine;
using System.Collections;

public class DethAria : MonoBehaviour
{
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(player);
        Debug.Log("aaa");
    }
}
