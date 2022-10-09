using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadScene(int SceneIndex) 
    {
        SceneManager.LoadScene(SceneIndex);
        Debug.Log("Pindah ke Scene Index: " + SceneIndex);
    }
}
