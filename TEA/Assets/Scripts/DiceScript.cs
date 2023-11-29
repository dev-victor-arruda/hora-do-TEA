using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DiceScript : MonoBehaviour
{
  private static Rigidbody rb;// Referência estática ao Rigidbody para controlar o dado.
  public Transform[] lados;// Array de posições representando os lados do dado.

  
  [SerializeField] private Player_1 player; // Referência ao script Player_1 para chamar o método MoverPersonagem.

  
  void Start() // Método chamado na inicialização para obter a referência ao Rigidbody.
  {
    rb = GetComponent<Rigidbody>();
  }

 
  private void Update() // Método chamado a cada quadro.
  {
    
    if (Input.GetKeyDown(KeyCode.Space)) // Verifica se a tecla de espaço foi pressionada.
    {
      Lancar(); // Chama o método Lancar quando a tecla de espaço é pressionada.
      return;
    }
  }

  
  private void Lancar() // Método para lançar o dado.
  {
    
    float direcaoXYZ = Random.Range(0, 500); // Gera uma direção aleatória para aplicar força ao dado.
    transform.position = new Vector3(0.04f, 3f, 4.54f); // Define a posição inicial do dado.
    transform.rotation = Quaternion.identity; // Reseta a rotação do dado.
    rb.AddForce(transform.up * 500); // Adiciona força para simular o lançamento do dado para cima.
    rb.AddTorque(direcaoXYZ, direcaoXYZ, direcaoXYZ);// Adiciona torque para dar rotação ao dado.
    Invoke("MoverJogador", 3.0f); // Invoca o método MoverJogador após 3 segundos.
  }

  
  private void MoverJogador() // Método chamado após o dado parar de se mover.
  {
    int ladoQueODadoParou = -1; // Variável para armazenar o lado em que o dado parou.
    float maiorAltura = 0.0f;// Variável para armazenar a maior altura entre os lados do dado.
    for (int index = 0; index < 6; index++)// Loop para percorrer os lados do dado.
    {
      if (lados[index].position.y > maiorAltura)// Verifica qual lado tem a maior altura.
      {
        ladoQueODadoParou = index;
        maiorAltura = lados[index].position.y;
      }
    }
    player.MoverPersonagem(ladoQueODadoParou + 1); // Chama o método MoverPersonagem do jogador, passando o número do lado do dado que parou.
  }
}
