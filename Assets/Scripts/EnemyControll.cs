using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyControll : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject Player;
    public Animator anim;

    public float hitpoints = 60f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.transform.position);
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }


    public void TakeDamage (float amount)
    {
        hitpoints -= amount; 
        if (hitpoints <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(this.gameObject);
    }
}
