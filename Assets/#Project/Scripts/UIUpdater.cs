using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{

    public Image[] lifeImages;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int index=0; index < lifeImages.Length;index++)
        {
            lifeImages[index].enabled = index < LevelsManager.lives;
        }

    }
}
