using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour {
    public int valor1;
    public int valor2;

    // 1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
    void Start ()
    {
        if (valor1 == valor2)
            Debug.Log("Son iguales");

        else
            Debug.Log("Son diferentes");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
