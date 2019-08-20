using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone: MonoBehaviour
{
    public string teamName;

    public ScoreManager sm;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("hey Ijust destroyed a ball I dont know if that's what you wanted to do but I did it");

        BallManager.instance.InstantiateBall();

        if(teamName == "TeamPink")
        {
            sm.TeamYellowScored();
        }
        

        if(teamName == "TeamYellow")
        {
            sm.TeamPinkScored();
        }
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
