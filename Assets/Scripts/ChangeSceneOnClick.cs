using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
     private void OnMouseDown()
    {
        int puntaje = PlayerPrefs.GetInt("puntaje");
        Debug.Log(gameObject.name);
        PlayerPrefs.SetString("nombre", gameObject.name);
        PlayerPrefs.SetInt("puntaje", puntaje + 1);
        SceneManager.LoadScene("Escena Final");
    }
}
