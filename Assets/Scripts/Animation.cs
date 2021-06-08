using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(60f);

        GetComponent<Animator>().Play("Sitting");
       
    }
}
