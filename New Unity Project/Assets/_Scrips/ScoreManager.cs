using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int TeamPink;
    public int TeamYellow;
    private UIManager uiMan;

    private void Start()
    {
        uiMan = GetComponent<UIManager>();
    }

    public void TeamPinkScored()
    {
        TeamPink += 1;
        uiMan.UdateScore(TeamPink, TeamYellow);
    }


    public void TeamYellowScored()
    {
        TeamYellow += 1;
        uiMan.UdateScore(TeamPink, TeamYellow);
    }


}