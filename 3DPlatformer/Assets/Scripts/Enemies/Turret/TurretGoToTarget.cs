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
        //Grabs the child object of the parent of this object which would be the target location for this bullet.
        target = transform.parent.gameObject.transform.GetChild(0).gameObject.GetComponent<Transform>();
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
        if(!other.gameObject.CompareTag("Turret") && !other.gameObject.CompareTag("Damage"))
        {
            Destroy(gameObject);
        }
    }
}
