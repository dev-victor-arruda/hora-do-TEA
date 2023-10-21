using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
  CONCEPT,
  COMUNICATION,
  BEHAVIOR,
  RESOURCES,
  STRATEGY,
  CURIOSITY
}

public class CardInformation : MonoBehaviour
{
  public static string NameOfCard(CardType type)
  {
    switch (type)
    {
      case CardType.CONCEPT:
        return "Conceitos b�sicos";
      case CardType.COMUNICATION:
        return "Comunica��o";
      case CardType.BEHAVIOR:
        return "Comportamento";
      case CardType.RESOURCES:
        return "Recursos pedag�gicos";
      case CardType.STRATEGY:
        return "Estrat�gias pedag�gicas";
      case CardType.CURIOSITY:
        return "Curiosidades";
    }
    return "";
  }
}
