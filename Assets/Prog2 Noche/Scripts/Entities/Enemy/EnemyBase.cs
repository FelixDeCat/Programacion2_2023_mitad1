using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Programacion2.Noche;

public class EnemyBase : MonoBehaviour
{
    Transform point;
    NavMeshAgent agent;

    [SerializeField] bool DirectLookAt = false;

    float timer = 0;
    [SerializeField] float time_to_move = 3f;

    [SerializeField] Transform pivotPoint;
    [SerializeField] Transform shootPoint;

    [Range(0f,5f)]
    [SerializeField] float lookatSpeed = 0.1f;

    public Renderer myRenderer;

    public Gradient gradient;
    public AnimationCurve curve;

    public Transform ScaleObject;


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        point = GameManager.instance.character.transform;
    }

    private void Update()
    {
        Vector3 dir = point.position - pivotPoint.position;

        if(!DirectLookAt) dir.y = 0;

        
        pivotPoint.forward = Vector3.Slerp(pivotPoint.forward, dir, lookatSpeed * Time.deltaTime);

       

        if (agent == null) return;
        if (timer < time_to_move)
        {
            timer = timer + 1 * Time.deltaTime;

            float scale = curve.Evaluate(timer / time_to_move);
            ScaleObject.transform.localScale = new Vector3(scale, scale, scale);
            
            myRenderer.material.color = gradient.Evaluate(timer / time_to_move);
            //myRenderer.material.color = Color.Lerp(Color.blue, Color.red, timer / time_to_move);
        }
        else
        {
            agent.isStopped = false;
            agent.destination = point.position;
            timer = 0;
        }

        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    agent.isStopped = false;
        //    agent.destination = point.position;
        //}

        
    }
}
