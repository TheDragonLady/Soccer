using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text PlayerPinkScore;
    public Text PlayerYellowScore;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPinkScore.text = "0";
        PlayerYellowScore.text = "0";
    }
    
    public void UdateScore(int ppScore, int pyScore)
    {
        PlayerPinkScore.text = ppScore.ToString();
        PlayerYellowScore.text = pyScore.ToString();
    }
}