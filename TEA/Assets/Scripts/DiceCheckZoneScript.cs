using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour
{
    private bool isDiceRolling = false;

    private void Update()
    {
        // Verifique se o dado está rolando com base em sua velocidade.
        isDiceRolling = DiceScript.diceVelocity.magnitude > 0.1f;

        if (!isDiceRolling)
        {
            // O dado parou de rolar, então podemos fazer a leitura da face.
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (!isDiceRolling)
        { 
            if (col.gameObject.name == "Side1")
            {
                DiceScript.diceNumber = 6;
                Debug.Log("Lado 1 detectado. Valor do dado: 6");
            }
            else if (col.gameObject.name == "Side2")
            {
                DiceScript.diceNumber = 5;
                Debug.Log("Lado 2 detectado. Valor do dado: 5");
            }
            else if (col.gameObject.name == "Side3")
            {
                DiceScript.diceNumber = 4;
                Debug.Log("Lado 3 detectado. Valor do dado: 4");
            }
            else if (col.gameObject.name == "Side4")
            {
                DiceScript.diceNumber = 3;
                Debug.Log("Lado 4 detectado. Valor do dado: 3");
            }
            else if (col.gameObject.name == "Side5")
            {
                DiceScript.diceNumber = 2;
                Debug.Log("Lado 5 detectado. Valor do dado: 2");
            }
            else if (col.gameObject.name == "Side6")
            {
                DiceScript.diceNumber = 1;
                Debug.Log("Lado 6 detectado. Valor do dado: 1");
            }

            Debug.Log("Verificação de dado concluída!");
        }
    }
}
