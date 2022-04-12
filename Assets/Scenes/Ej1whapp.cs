using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1whapp : MonoBehaviour {

    public int args = 0;
    public string pasaje = "";
        
	// Use this for initialization
	void Start ()
    {
        int dolares = args / 200;
        int euros = args / 210;
        int reales = args / 24;

        if (args < 1000)

            Debug.Log("El monto tiene que ser mayor a 1000");
        
        else if (1000 < args)

            switch(pasaje)
            {
                case "D": Debug.Log(args + "pesos argentinos equivalen a ´" + dolares + "´ dolares");
                    break;
                case "E": Debug.Log(args + "pesos argentinos equivalen a ´" + euros + "´ dolares");
                    break;
                case "R": Debug.Log(args + "pesos argentinos equivalen a ´" + reales + "´ reales");
                    break;
                default: Debug.Log("La moneda extrangera no existe");
                    break;

            }

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
