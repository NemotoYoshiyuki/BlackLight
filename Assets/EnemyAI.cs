using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    public int enemyHP;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        enemyHP--;
        if (enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
