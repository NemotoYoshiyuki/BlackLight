using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    Animator animator;

    public GameObject zonbi;
    public int enemyHP;
    private bool isDeth;
    public float speed;

    public Transform player;
    

	// Use this for initialization
	void Start () {
        animator = zonbi.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    public void Move()
    {
        if (isDeth == false)
        {
            Vector3 playerPOS = player.position;
            Vector3 direction = playerPOS - transform.position;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }       
    }

    public void Attack()
    {
        animator.SetBool("attack", true);
    }

    void OnTriggerEnter(Collider other)
    {
        enemyHP--;
        if (enemyHP <= 0)
        {
            animator.SetBool("fall", true);         
            isDeth = true;
            Destroy(gameObject, 2f);
        }
    }
}
