using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisactivateParrent : MonoBehaviour
{
    public void Disactivate(float time)
    {
        StartCoroutine(ExecuteAfterTime(time));
    }


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        transform.parent.gameObject.SetActive(false);
    }
}
