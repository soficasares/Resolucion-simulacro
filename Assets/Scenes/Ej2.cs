// Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero 
// disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto 
// dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour {

    public int product1;
    public int product2;
    public int product3;
    public int dinerodisponible;
    int dinerofalta;
    int suma;
    int dinerosobrante;

    void Start ()
    {
        suma = product1 + product2 + product3;

        if (suma > dinerodisponible)
        {
            dinerofalta = suma - dinerodisponible;
            Debug.Log("No le alcanza el dinero, le falta:" + dinerofalta);
        }
           
        

        else if (dinerodisponible > suma)
        { 
            dinerosobrante = dinerodisponible - suma;
            Debug.Log("Le alcanza exitosamente el dinero y le sobra:" + dinerosobrante);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
