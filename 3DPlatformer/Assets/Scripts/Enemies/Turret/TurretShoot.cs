using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{   

    [SerializeField] private GameObject bulletThing;
    public float Second_Delay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shoot());
    }

    private IEnumerator shoot()
    {
        yield return new WaitForSeconds(Second_Delay);
        Instantiate(bulletThing, this.transform);
        StartCoroutine(shoot());
    }
}
