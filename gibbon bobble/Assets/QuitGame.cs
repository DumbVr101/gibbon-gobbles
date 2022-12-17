using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}