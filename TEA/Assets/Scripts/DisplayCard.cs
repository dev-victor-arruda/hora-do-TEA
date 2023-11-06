using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
  public int cardPosition;
  public Image cardBackground;
  public Text cardType;
  public Text cardSubtype;
  public Text cardQuestion;
  public Text cardDescription;

  void Start()
  {
    GetContainerInformation();
  }

  void GetContainerInformation()
  {
    cardPosition = Random.Range(1, CardsContainer.Length());
    CardType type = CardsContainer.At(cardPosition).getType();
    cardType.text = CardInformation.NameOfCard(type);
    cardBackground.sprite = CardInformation.BackgroundOfCardType(type);
    cardSubtype.text = CardsContainer.At(cardPosition).getSubtype();
    cardQuestion.text = CardsContainer.At(cardPosition).getQuestion();
    cardDescription.text = CardsContainer.At(cardPosition).getDescription();
  }
}
