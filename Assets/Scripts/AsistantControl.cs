
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;



public class AsistantControl : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform TargetPosition;
    public Animator anim;
    public KeyCode waving_arm_01_Key;

    public float blinkHP = 200f;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        TargetPosition = GameObject.Find("TargetPosition").transform;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(TargetPosition.position);
        anim.SetFloat("speed", agent.velocity.magnitude);

        if (Input.GetKeyDown(waving_arm_01_Key)){
            anim.SetTrigger("HL_waving_arm_01");
        }
    }

    public void TakeDamage(float amount)
    {
        blinkHP -= amount;
        if (blinkHP <= 0f)
        {
            Kill();
        }
    }

    void Kill()
    {
        SceneManager.LoadScene("gameover");
    }



}