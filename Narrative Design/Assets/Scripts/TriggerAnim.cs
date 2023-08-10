using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnim : MonoBehaviour

{
    Animator animController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animController.Play("Door_Open");
            animController.SetBool("Door_Open", true);

        }

    }
}
