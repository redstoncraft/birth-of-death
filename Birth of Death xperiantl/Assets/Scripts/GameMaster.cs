using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI    ;

public class GameMaster : MonoBehaviour
{
    public int gems;
    public int points;

    public Text gemText;
    public Text pointsText;

    void Update()
    {
        gemText.text = ("Gems: " + gems);
        pointsText.text = ("Points: " + points);
    }
}
