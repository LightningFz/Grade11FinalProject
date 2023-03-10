// made by Fawaz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/*
    this class controls the buttons in the levels page and takes you to the level that you picked
 */
public class levelsSelectorMenu : MonoBehaviour
{

    //array of all the levels
    public GameObject[] level;

    //UI text element of the button that has the name of the level
    private TextMeshProUGUI levelText;

    //These variables are used to number the levels. Please keep in mind that the index of the levels has been set from the unity "Build Settings..."
    private int numberOfLevelIndex;
    private int numberOfLevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        //place all the levels in the array with the right index 
        for (numberOfLevelIndex = 0; level.Length > numberOfLevelIndex; numberOfLevelIndex++)
        {
            levelText = level[numberOfLevelIndex].GetComponentInChildren<TextMeshProUGUI>();
            levelText.text = numberOfLevel.ToString();
            numberOfLevel++;
        }
    }

    //load the level with the number that has been inputted as the perimeter for this method
    public void openScene(int number)
    {
        SceneManager.LoadScene("level " + number);
    }
}
