using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBulet : MonoBehaviour
{
    private Transform target;
    private Vector3 targetPosition;
    [SerializeField] private float speed = 3f;
    
    void Start()
    {
        target = GameObject.Find("Third Person Player").transform;
        transform.SetParent(null);
    }

    void Update()
    {
        targetPosition = target.transform.position;
        float stepAmount = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, stepAmount);

        if(transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision other)
    {

        if(!other.gameObject.CompareTag("Turret"))
        {
            Debug.Log("Test");
            Destroy(gameObject);
        }
    }
    
}
