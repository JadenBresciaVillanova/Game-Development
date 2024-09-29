using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter (Collision other) {
        switch(other.gameObject.tag){
            case "Friendly":
            Debug.Log("The collision is friendly");
            break;
            case "Finish":
            Debug.Log("The game is finished");
            break;
            default:
            Debug.Log("Default case");
            ReloadLevel();
            break;
        }
    }

    private void ReloadLevel(){
        Scene sceneManager = SceneManager.GetActiveScene();
        int currentIndex = sceneManager.buildIndex;
        SceneManager.LoadScene(currentIndex);
    }
}
