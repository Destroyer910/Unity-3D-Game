using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGoToTarget : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed = 3f;
    
    void Start()
    {
        target = GameObject.Find("TurretTarget").GetComponent<Transform>();
    }

    void Update()
    {
        float stepAmount = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, stepAmount);

        if(transform.position == target.position)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
