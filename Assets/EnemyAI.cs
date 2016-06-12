using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
    Animator animator;

    public GameObject zonbi;
    public int enemyHP;
    bool isDeth;
    public float speed;

    public Transform player;
    private NavMeshAgent nav;
    

	// Use this for initialization
	void Start () {
        animator = zonbi.GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        //プレイヤーの距離を所得
        float dis = Vector3.Distance(player.position, transform.position);
        Debug.Log(dis);

        if (dis <= 5f)
        {
            nav.enabled = true;
            Move();           
            //2mに近づいたら攻撃
            if (dis <= 2f)
            {
                Attack();
                nav.enabled = false;
            }
        }
        else
        {
            nav.enabled = false;
        }
    }

    public void Move()
    {
        if (isDeth == false)
        {
            nav.SetDestination(player.position);
            animator.SetBool("walk", true);
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
