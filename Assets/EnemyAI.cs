using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    Animator anima;

    public GameObject zonbi;
    public int enemyHP;

	// Use this for initialization
	void Start () {
        anima = zonbi.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        enemyHP--;
        if (enemyHP <= 0)
        {
            anima.SetBool("fall", true);
            //Destroy(gameObject);
        }
    }
}
