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
        return "Conceitos básicos";
      case CardType.COMUNICATION:
        return "Comunicação";
      case CardType.BEHAVIOR:
        return "Comportamento";
      case CardType.RESOURCES:
        return "Recursos pedagógicos";
      case CardType.STRATEGY:
        return "Estratégias pedagógicas";
      case CardType.CURIOSITY:
        return "Curiosidades";
    }
    return "";
  }
}
