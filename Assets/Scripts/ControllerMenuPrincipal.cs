﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerMenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void CargarInicio ()
    {
        SceneManager.LoadScene("SelectorNiveles");
    }

    public void CargarOpcionesMenuPrincipal()
    {
        SceneManager.LoadScene("OpcionesMenuPrincipal");
    }

    public void CargarCreditos()
    {
        SceneManager.LoadScene("MenuCreditos");
    }

    public void CargarSalir(){

            Application.Quit();
    }
}
