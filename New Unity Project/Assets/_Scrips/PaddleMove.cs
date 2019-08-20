using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    PlayerPink,
    PlayerYellow
}
public class PaddleMove : MonoBehaviour
{
    public PlayerController playerSetting;
    public float speed = 1f;
    public float clampValue;
    public string axisName;


    // Start is called before the first frame update
    void Start()
    {
        if(playerSetting == PlayerController.PlayerPink)
        {
            axisName = "PlayerPink";
        }

        if (playerSetting == PlayerController.PlayerYellow)
        {
            axisName = "PlayerYellow";
        }

    }

    // Update is called once per frame
    void Update()
    {


        MovePaddle(Input.GetAxis(axisName));

    }

    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(0, 0, amountToMove * speed);
        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);


        gameObject.transform.position = clampedGameObjectPosition;
       
    }
}
