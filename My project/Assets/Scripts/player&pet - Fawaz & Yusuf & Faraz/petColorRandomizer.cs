// made by Yusuf

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class randomizes the pet color
    this class also allows the player to turn off the randomization
 */
public class petColorRandomizer : MonoBehaviour
{
    public SpriteRenderer petImage;
    public Color[] color;
    public Color defaultColor;
    public bool changePetColor;
    private int randomizer;

    // Start is called before the first frame update
    void Start()
    {
        randomizer = Random.Range(0, color.Length);
        if(changePetColor == true)
        {
            petImage.color = color[randomizer];
        }else if(changePetColor == false)
        {
            petImage.color = defaultColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (changePetColor == false)
        {
            petImage.color = defaultColor;
        }
    }
}
