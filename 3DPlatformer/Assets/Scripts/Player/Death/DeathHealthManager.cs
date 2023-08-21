using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHealthManager : MonoBehaviour
{

    public int health = 3;
    public bool canBeHurt = true;
    [SerializeField] private GameObject deathEffects;
    [SerializeField] private GameObject playerModel;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject cam;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Damage") && canBeHurt)
        {
            health -= 1;
            canBeHurt = false;
            StartCoroutine(invincibilityTime());
        }
        if(other.gameObject.CompareTag("HealSmall"))
        {
            if(health < 3)
            {
                health += 1;
            }
        }
        if(other.gameObject.CompareTag("HealFull"))
        {
            health = 3;
        }
    }

    private IEnumerator invincibilityTime()
    {
        Color tempColor = playerModel.GetComponent<Renderer>().material.color;
        playerModel.GetComponent<Renderer>().material.color = new Color(tempColor.r, tempColor.g, tempColor.b, .5f);
        yield return new WaitForSeconds(2f);
        playerModel.GetComponent<Renderer>().material.color = new Color(tempColor.r, tempColor.g, tempColor.b, 1f);
        canBeHurt = true;
    }

    void Update()
    {
        if(health <= 0)
        {
            cam.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    

}
