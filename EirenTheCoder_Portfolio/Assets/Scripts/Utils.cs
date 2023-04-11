using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public static class Utils
{

    public static bool animHasFinished(Animator animationToEvaluate,string nameOfAnimation) {

        bool finished = false;

        if (animationToEvaluate.GetCurrentAnimatorStateInfo(0).IsName(nameOfAnimation)) finished = true ;

        return finished;

    }
    

}
