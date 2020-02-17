using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
  public bool top = false;
  public string suit;
  public int value;
  public int row;

  public bool faceUp = false;
  public bool inDeckPile = false;

  private string valueString;
  
  // Start is called before the first frame update
  void Start()
  {
    if(CompareTag("Card")) {
      suit = transform.name[0].ToString();

      for(int i=1; i<transform.name.Length; i++) {
        char c = transform.name[i];
        valueString = valueString + c.ToString();
      }

      if(valueString == "A") {
        value = 1;
      }

      else if(valueString == "J") {
        value = 11;
      }

      else if(valueString == "Q") {
        value = 12;
      }

      else if(valueString == "K") {
        value = 13;
      }

      else if(valueString != "ard"){
        value = int.Parse(valueString);
      }



    }
      
  }

  // Update is called once per frame
  void Update()
  {
      
  }
}
