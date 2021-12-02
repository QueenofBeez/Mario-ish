using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LevelsManager levelsManager = LevelsManager.instance; // GameObject.FindObjectOfType<LevelsManager>();
        GameObject player = levelsManager.player;
        player.transform.position = transform.position;
    }

}
