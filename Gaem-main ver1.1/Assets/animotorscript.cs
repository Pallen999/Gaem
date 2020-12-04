using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animotorscript : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animering;
    public float ast = .1f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animering = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float speedpercent = agent.velocity.magnitude / agent.speed;
        animering.SetFloat("speed", speedpercent, ast, Time.deltaTime );
    }
}
