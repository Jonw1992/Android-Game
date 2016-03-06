using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour{

	public static string theme = "Default";
    public GameObject selector;
    private Color blue = new Color32(0, 120, 255, 255);
    private Color red = new Color32(255, 55, 55, 255);
    private Color purple = new Color32(154,92,176, 255);
    private Color yellow = new Color32(255, 245, 130, 255);
    private Color green = new Color32(58, 212, 91, 255);
    private Color brightgreen = new Color32(0,255,0, 255);
    private Color grey = new Color32(229,229,229, 255);
    private Color mediumgrey = new Color32(180,180,180, 255);
    private Color darkgrey = new Color32(114,114,114, 255);
    private Color transparent = new Color32(0,0,0,0);
    private Color orange = new Color32(255,185,0, 255);
    public Color words;
    public Color gameArea;
    public Color background;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public Color pegs;
    public Color walls;
    public Color dispensers;
    public Color text;
    public Color invertedtext;
    public Color catcher;
    public Color lives;

	// Use this for initialization
    void start()
    {
        setDefaultColors();
        GameObject.Find("Selector").transform.position = GameObject.Find("ColorScheme1").transform.position;
    }

	public void setDefaultColors()
    {
		theme = "Blue Prism";
        words = blue;
        gameArea = Color.black;
        background = grey;
        color1 = blue;
        color2 = red;
        color3 = purple;
        color4 = yellow;
        color5 = green;
        pegs = grey;
        dispensers = darkgrey;
        text = Color.black;
        walls = transparent;
        catcher = blue;
        lives = blue;
        invertedtext = Color.white;

    }

    public void setWhite()
    {

		theme = "Color Slate";
        words = blue;
        gameArea = grey;
        background = grey;
        pegs = Color.black;
        color1 = blue;
        color2 = red;
        color3 = purple;
        color4 = yellow;
        color5 = green;
        pegs = Color.black;
        dispensers = Color.black;
        text = Color.black;
        walls = Color.black;
        catcher = Color.black;
        invertedtext = Color.black;
		lives = blue;

    }

    public void setInvertedRetro()
    {
		theme = "Snow";
        words = Color.white;
        gameArea = Color.black;
        background = Color.white;
        color1 = Color.white;
        color2 = Color.white;
        color3 = Color.white;
        color4 = Color.white;
        color5 = Color.white;
        pegs = Color.white;
        dispensers = Color.white;
        text = Color.black;
        walls = Color.white;
        catcher = Color.white;
        lives = grey;
        invertedtext = Color.black;
    }

    public void setRetro()
    {
		theme = "Retro";
        words = Color.white;
        gameArea = Color.white;
        background = Color.black;
        color1 = Color.black;
        color2 = Color.black;
        color3 = Color.black;
        color4 = Color.black;
        color5 = Color.black;
        pegs = Color.black;
        dispensers = Color.black;
        text = Color.white;
        walls = Color.black;
        catcher = Color.black;
        lives = Color.white;
        invertedtext = Color.white;
    }

    public void setBright()
    {
		theme = "CyberPunk";
        words = purple;
        gameArea = Color.black;
        background = grey;
        color1 = blue;
        color2 = purple;
        color3 = blue;
        color4 = purple;
        color5 = red;
        pegs = grey;
        dispensers = grey;
        text = Color.black;
        walls = grey;
        catcher = purple;
        invertedtext = Color.black;
    }
	// Update is called once per frame

    public void setOrange()
    {
		theme = "Orange Prism";
        words = orange;
        gameArea = Color.black;
        background = grey;
        color1 = blue;
        color2 = red;
        color3 = purple;
        color4 = yellow;
        color5 = green;
        pegs = grey;
        dispensers = darkgrey;
        text = Color.black;
        walls = transparent;
        catcher = orange;
        lives = orange;
        invertedtext = Color.white;
    }
    public void setGreen()
    {
		theme = "Green Prism";
        words = green;
        gameArea = Color.black;
        background = grey;
        color1 = blue;
        color2 = red;
        color3 = purple;
        color4 = yellow;
        color5 = green;
        pegs = grey;
        dispensers = darkgrey;
        text = Color.black;
        walls = transparent;
        catcher = green;
        lives = green;
        invertedtext = Color.white;

    }
    public void setPurple()
    {
		theme = "Purple Prism";
        words = purple;
        gameArea = Color.black;
        background = grey;
        color1 = blue;
        color2 = red;
        color3 = purple;
        color4 = yellow;
        color5 = green;
        pegs = grey;
        dispensers = darkgrey;
        text = Color.black;
        walls = transparent;
        catcher = purple;
        lives = purple;
        invertedtext = Color.white;

    }
    public void setGrey()
    {
		theme = "Laserz";
        words = blue;
        gameArea = mediumgrey;
        background = Color.black;
        color1 = blue;
        color2 = brightgreen;
        color3 = blue;
        color4 = brightgreen;
        color5 = blue;
        pegs = Color.black;
        dispensers = Color.black;
        text = Color.white;
        walls = Color.black;
        catcher = blue;
        invertedtext = Color.black;
		lives = blue;
    }
    public void setRed()
    {
		theme = "Red Prism";
        words = red;
        gameArea = Color.black;
        background = grey;
        color1 = blue;
        color2 = red;
        color3 = purple;
        color4 = yellow;
        color5 = green;
        pegs = grey;
        dispensers = darkgrey;
        text = Color.black;
        walls = transparent;
        catcher = red;
        lives = red;
        invertedtext = Color.white;
    }
	void Update () {
	
	}
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
