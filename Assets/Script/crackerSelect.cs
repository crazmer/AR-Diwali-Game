using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crackerSelect : MonoBehaviour
{

    public int cracketNo;

    public Button annar;
    public Button rocket;
    public Button sutliBomb;
    public Button chakri;
    void Start()
    {
        annar = GetComponent<Button>();
        rocket = GetComponent<Button>();
        sutliBomb = GetComponent<Button>();
        chakri = GetComponent<Button>();
    }

    void annarSelect()
    {
        cracketNo = 3;
    }
    void rocketSelect()
    {
        cracketNo = 1;
    }
    void sutliBombSelect()
    {
        cracketNo = 2;
    }
    void chakriSelect()
    {
        cracketNo = 4;
    }
    void Update()
    {
        annar.GetComponent<Button>().onClick.AddListener(annarSelect);
        rocket.GetComponent<Button>().onClick.AddListener(rocketSelect);
        sutliBomb.GetComponent<Button>().onClick.AddListener(sutliBombSelect);
        chakri.GetComponent<Button>().onClick.AddListener(chakriSelect);
    }
}
