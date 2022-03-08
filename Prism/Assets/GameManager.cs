using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum GameMode
    {
        idle, 
        playing,
        levelEnd
    }


    static public GameManager S;

    public int level;
    public int levelMax; // The number of levels
    public int shotsTaken;
    public Text gtLevel;

    // Start is called before the first frame update
    void Start()
    {
        S = this; // Define the Singleton
        level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ShowGT();
        // Check for level end
    }

    void ShowGT() 
    {
        // Show the data in the GUITexts
        gtLevel.text = "Level: "+(level+1)+" of "+ levelMax;
    }

    void NextLevel() 
    {
        level++;
    }
    

}
