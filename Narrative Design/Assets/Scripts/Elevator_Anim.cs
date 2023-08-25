using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_Anim : MonoBehaviour
{
    public Animator elevator_animator;
   public void Start()
    {
        Invoke("ElevatorOpen", 6f);
    }

    public void ElevatorOpen()
    {
        elevator_animator.Play("Elevator_Open");
    }

}
