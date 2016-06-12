using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    public GameObject player;
    public GameObject zonbi;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision col)
    {
        if (player)
        {
            zonbi.SendMessage("Attack");
        }
    }
}
