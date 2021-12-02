using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{

    public static LevelsManager instance = null;

    public GameObject playerPrefab;
    public GameObject player;
    public static int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        // print(gameobject.name);
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject); // permet de garder un objet quand on change de scène
            instance = this;
            player = Instantiate(playerPrefab);
            DontDestroyOnLoad(player);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void LoseLife()
    {
        lives--;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print(lives);
        if(lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
