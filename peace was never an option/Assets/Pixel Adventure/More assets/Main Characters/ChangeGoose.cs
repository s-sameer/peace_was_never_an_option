using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGoose : MonoBehaviour
{
    //public RuntimeAnimatorController gooseAnimatorController;
    public AnimatorOverrideController goose_1;
    public AnimatorOverrideController goose_2;
    public AnimatorOverrideController goose_3;

//    void Start()
//    {
       // GetComponent<Animator>().runtimeAnimatorController = gooseAnimatorController;
//    }

    public void Goose_1()
    {
        GetComponent<Animator>().runtimeAnimatorController = goose_1 as RuntimeAnimatorController;
        //goose_1.runtimeAnimatorController = gooseAnimatorController;
    }

    public void Goose_2()
    {
        GetComponent<Animator>().runtimeAnimatorController = goose_2 as RuntimeAnimatorController;
        //goose_2.runtimeAnimatorController = gooseAnimatorController;
    }

    public void Goose_3()
    {
        GetComponent<Animator>().runtimeAnimatorController = goose_3 as RuntimeAnimatorController;
        //goose_3.runtimeAnimatorController = gooseAnimatorController;
    }
}
