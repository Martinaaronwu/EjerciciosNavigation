using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navigation : MonoBehaviour

{
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] Transform targetTransform;
    [SerializeField] Animator anim;


    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = targetTransform.position;
        anim.SetFloat("speed", agent.velocity.magnitude);
    }
}
