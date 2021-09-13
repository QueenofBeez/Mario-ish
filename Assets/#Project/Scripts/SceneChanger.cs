using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Player";
    }

    public string destination;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(destination);
        }
        //if(other.CompareTage("Player"))
        //{
            //int index = SceneManager.GetActiveScene().buildindex;
            //SceneManager.LoadScene(index + 1);
        //}
    }
}
