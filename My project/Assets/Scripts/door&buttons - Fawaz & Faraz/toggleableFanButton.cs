// made by Fawaz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   this script is used for a button that is toggleable,
   when the button is pressed the fan turns on and pushes anything in its way
   when the button is pressed again the fan turns off
*/
public class toggleableFanButton : MonoBehaviour
{

    // vairables
    public fan fan; //refrences the fan script

    // this method is called when a game object collides with the trigger area 
    void OnTriggerEnter2D(Collider2D gameObjects) //paramater that refers to the object that collides with the trigger, in this situation the objects can be either the player or the box
    {

        // checks if the object that collided with the trigger has the "Player" or the "Box" tag, if true the switch method is called
        if (gameObjects.CompareTag("Player")|| gameObjects.CompareTag("box"))
        {
            Switch();
        }
    }
    void Switch()
    {
        // when the switch method is called, this checks if the fanOn vairable is true or false, if its false it switches it to true and vice versa
        if (fan.fanOn == false)
        {
            fan.fanOn = true;
        }
        else if (fan.fanOn == true)
        {
            fan.fanOn = false;
        }
    }
    

}
