using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingAnimScript : MonoBehaviour
{
    private Animator animPlay;
    // Start is called before the first frame update
    void Start()
    {
        animPlay = GetComponent<Animator>();
    }

    public void AnimPlayer()
    {
        animPlay.SetTrigger("Collected");
    }
}
