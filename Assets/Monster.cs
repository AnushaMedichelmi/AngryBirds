using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public Sprite monster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BirdController birdController = collision.gameObject.GetComponent<BirdController>(); //Monoster should only collides by gameobject which is in Birdcontroller.
        if (birdController != null || collision.gameObject.tag == "Crate") //If bird hits the monster or crate hits the monster, the monster had to die.
        {
            //Destroy(gameObject);
            MonsterDeath();

        }



    }
    private void MonsterDeath()
    {
        //gameObject.SetActive(false); //making it to inactive,monsoter still in gamewindow.
        GetComponent<SpriteRenderer>().sprite = monster;

    }

}