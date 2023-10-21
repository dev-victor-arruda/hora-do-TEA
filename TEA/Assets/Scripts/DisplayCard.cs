using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
  public int cardPosition;
  public Text cardId;
  public Text cardType;
  public Text cardDescription;

  void Start()
  {
    GetContainerInformation();
  }

  void GetContainerInformation()
  {
    cardPosition = 1;
    cardId.text = "" + CardsContainer.At(cardPosition).getId();
    cardType.text = "" + CardsContainer.At(cardPosition).getType();
    cardDescription.text = "" + CardsContainer.At(cardPosition).getDescription();
  }
}
