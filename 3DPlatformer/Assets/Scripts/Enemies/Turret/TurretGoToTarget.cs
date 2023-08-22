using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGoToTarget : MonoBehaviour
{
    private Transform target;
    private Vector3 targetPosition;
    [SerializeField] private float speed = 3f;
    
    void Start()
    {
        target = GameObject.Find("TurretTarget").GetComponent<Transform>();
        targetPosition = new Vector3(target.position.x, target.position.y, target.position.z);
        transform.SetParent(null);
    }

    void Update()
    {
        float stepAmount = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, stepAmount);

        if(transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
