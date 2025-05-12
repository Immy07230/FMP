using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string Scene;



    private void OnTriggerEnter(Collider other)
    {
        // if player tag is "Player" goto new scene

        Debug.Log("trigger");
        if (other.CompareTag("Player"))
        {

            Debug.Log("enter");
            SceneManager.LoadScene(Scene);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        /*
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Scene);
        }
        */
    }
}
