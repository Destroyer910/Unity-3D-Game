using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearOnUnlock : MonoBehaviour
{

    [SerializeField] private IndividualLevelsSO level;
    private bool unlockLevel = false;
    private Vector3 targetPosition;
    public float speed = 1;

    void Start()
    {
        if(level.beatenLevel)
        {
            unlockLevel = true;
        }
        targetPosition = new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
    }

    void Update()
    {
        if(unlockLevel)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            Debug.Log("move");
        }
        if(transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
