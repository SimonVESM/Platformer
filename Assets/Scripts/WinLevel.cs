using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WinLevel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("You Win");
    }
}
