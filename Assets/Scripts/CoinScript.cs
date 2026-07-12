using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public Animator animator;
    public GameObject functionManager;
    public AudioSource sound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator animation()
    {
        yield return new WaitForSeconds(1);
        animator.SetBool("Pickup", false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            functionManager.GetComponent<FunctionManagerScript>().addCoins(1);
            animator.SetBool("Pickup", true);
            StartCoroutine(animation());
            sound.PlayOneShot(sound.clip);
            gameObject.SetActive(false);
        }
    }
}
