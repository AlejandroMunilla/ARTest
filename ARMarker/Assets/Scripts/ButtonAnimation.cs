using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject humanoid;
    Animator anim;
    void Start()
    {
        anim = humanoid.GetComponent<Animator>();
    }

    public void OnClick ()
    {
        anim.SetFloat("MoveSpeed", 1);
        Debug.Log("1");
    }
    // Update is called once per frame

}
