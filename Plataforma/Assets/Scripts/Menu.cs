using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//inserir a biblioteca de scene
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject menuPanel;
    public GameObject optionsPanel;
    void Start()
    {
        menuPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
