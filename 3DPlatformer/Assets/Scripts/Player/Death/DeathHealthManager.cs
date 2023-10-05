using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathHealthManager : MonoBehaviour
{

    public int health = 3;
    public bool canBeHurt = true;
    [SerializeField] private GameObject deathEffects;
    [SerializeField] private GameObject playerModel;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject heart1;
    [SerializeField] private GameObject heart2;
    [SerializeField] private GameObject heart3;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Damage") && canBeHurt)
        {
            health -= 1;
            canBeHurt = false;
            StartCoroutine(invincibilityTime());
            updateHPSprites();
        }
        if(other.gameObject.CompareTag("HealSmall"))
        {
            if(health < 3)
            {
                health += 1;
            }
            updateHPSprites();
        }
        if(other.gameObject.CompareTag("HealFull"))
        {
            health = 3;
            updateHPSprites();
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

    private void updateHPSprites()
    {
        if(health == 3)
        {
            heart1.GetComponent<Image>().sprite = fullHeart;
            heart2.GetComponent<Image>().sprite = fullHeart;
            heart3.GetComponent<Image>().sprite = fullHeart;
        }
        if(health == 2)
        {
            heart1.GetComponent<Image>().sprite = fullHeart;
            heart2.GetComponent<Image>().sprite = fullHeart;
            heart3.GetComponent<Image>().sprite = emptyHeart;
        }
        if(health == 1)
        {
            heart1.GetComponent<Image>().sprite = fullHeart;
            heart2.GetComponent<Image>().sprite = emptyHeart;
            heart3.GetComponent<Image>().sprite = emptyHeart;
        }
        if(health < 1)
        {
            heart1.GetComponent<Image>().sprite = emptyHeart;
            heart2.GetComponent<Image>().sprite = emptyHeart;
            heart3.GetComponent<Image>().sprite = emptyHeart;
        }
    }

    void Update()
    {
        if (transform.position.y < -50) { health = 0;}
        if(health <= 0)
        {
            Time.timeScale = 0;
            cam.SetActive(false);
            gameObject.SetActive(false);
        }
    }


    

}
