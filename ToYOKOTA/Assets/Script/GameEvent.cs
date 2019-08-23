using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEvent : MonoBehaviour {
    //public string seasoningName;
    private CSVReader seasoningData = new CSVReader();
    public Text NaviText;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
    }
    public void OnClick()
    {
        seasoningData = new CSVReader();
        seasoningData.CsvRead("test");
        NaviText.text = seasoningData.csvDatas[0][0] + "に" + seasoningData.csvDatas[0][1] + "を置いてください";
        ImageChange();
    }
    public void ImageChange()
    {
        Texture2D texture = Resources.Load("Images/" + seasoningData.csvDatas[0][1]) as Texture2D;
        Image img = GameObject.Find("Canvas/Cube(" + seasoningData.csvDatas[0][0] + ")").GetComponent<Image>();
        img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        
    }
}
