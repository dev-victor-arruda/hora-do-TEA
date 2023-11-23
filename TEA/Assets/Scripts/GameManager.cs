// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GameManager : MonoBehaviour
// {
//     public DiceScript diceScript;
//     public Player_1 player1;

//     private bool firstRoll = true;

//     // Chame esse método quando quiser realizar a leitura do dado e mover o peão.
//     public void RealizarJogada()
//     {
//         if (!firstRoll)
//         {
//             int diceNumber = diceScript.LancarDado(); // Chama o método no DiceScript para lançar o dado
//             player1.MoverPersonagem(diceNumber); // Chama o método no Player_1 para mover o personagem
//         }
//         else
//         {
//             firstRoll = false;
//         }
//     }
// }
