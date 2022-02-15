using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gcon = GameObject.FindGameObjectWithTag("GameController");
        MenuGame menuGame = gcon.GetComponent<MenuGame>();
        menuGame.humanoid = gameObject;
        menuGame.anim = GetComponent<Animator>();

    }

    private void OnEnable()
    {
        GameObject gcon = GameObject.FindGameObjectWithTag("GameController");
        MenuGame menuGame = gcon.GetComponent<MenuGame>();
        menuGame.humanoid = gameObject;
        menuGame.anim = GetComponent<Animator>();
    }


}
