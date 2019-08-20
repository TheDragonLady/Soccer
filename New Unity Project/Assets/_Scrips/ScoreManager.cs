using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int TeamPink;
    public int TeamYellow;


    public void TeamPinkScored()
    {
        TeamPink += 1;
    }


    public void TeamYellowScored()
    {
        TeamYellow += 1;
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
