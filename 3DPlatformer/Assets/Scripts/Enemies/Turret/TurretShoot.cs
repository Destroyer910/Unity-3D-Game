using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{   

    [SerializeField] private GameObject bulletThing;
    public float Second_Delay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(shoot());
        
    }

    private IEnumerator shoot()
    {
        if(Time.timeScale == 1 || Time.timeScale == 0)
        {
            yield return new WaitForSeconds(Second_Delay);
        }
        else
        {
            yield return new WaitForSeconds(Second_Delay * (3/Time.timeScale));
        }
        Instantiate(bulletThing, this.transform);
        StartCoroutine(shoot());
    }
}
