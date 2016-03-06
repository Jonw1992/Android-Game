using UnityEngine;
using System.Collections;

public class Theme : MonoBehaviour {

	public static string theme = "Default";
	public GameObject selector;
	public static Color blue = new Color32(0, 120, 255, 255);
	public static Color red = new Color32(255, 55, 55, 255);
	public static Color purple = new Color32(154,92,176, 255);
	public static Color yellow = new Color32(255, 245, 130, 255);
	public static Color green = new Color32(58, 212, 91, 255);
	public static Color brightgreen = new Color32(0,255,0, 255);
	public static Color grey = new Color32(229,229,229, 255);
	public static Color mediumgrey = new Color32(180,180,180, 255);
	public static Color darkgrey = new Color32(114,114,114, 255);
	public static Color verydarkgrey = new Color32(30,30,30, 255);
	public static Color pink = new Color32(253,40,226, 255);
	public static Color cyberblue= new Color32(8,217,247, 255);
	public static Color cyberpurple = new Color32(166,77,212, 255);
	public static Color cyberyellow = new Color32(254,237,10, 255);
	public static Color transparent = new Color32(0,0,0,0);
	public static Color orange = new Color32(255,185,0, 255);
	public static Color words;
	public static Color gameArea;
	public static Color background;
	public static Color color1;
	public static Color color2;
	public static Color color3;
	public static Color color4;
	public static Color color5;
	public static Color pegs;
	public static Color walls;
	public static Color dispensers;
	public static Color text;
	public static Color invertedtext;
	public static Color catcher;
	public static Color lives;
	
	// Use this for initialization
	void start()
	{
		setDefaultColors();
		GameObject.Find("Selector").transform.position = GameObject.Find("ColorScheme1").transform.position;
	}
	
	public static void setDefaultColors()
	{
		theme = "Blue Prism";
		words = blue;
		gameArea = Color.black;
		background = grey;
		color1 = blue;
		color2 = red;
		color3 = green;
		color4 = yellow;
		color5 = purple;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.black;
		walls = grey;
		catcher = blue;
		invertedtext = Color.black;
		lives = blue;
		
	}
	
	public static void setWhite()
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
		catcher = blue;
		invertedtext = Color.black;
		lives = blue;
		
	}
	
	public static void setInvertedRetro()
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
	
	public static void setRetro()
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
	
	public static void setBright()
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
	
	public static void setOrange()
	{
		theme = "Orange Prism";
		words = orange;
		gameArea = Color.black;
		background = grey;
		color1 = blue;
		color2 = red;
		color3 = green;
		color4 = yellow;
		color5 = purple;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.black;
		walls = grey;
		catcher = orange;
		lives = orange;
		invertedtext = Color.white;
	}
	public static void setGreen()
	{
		theme = "Green Prism";
		words = green;
		gameArea = Color.black;
		background = grey;
		color1 = blue;
		color2 = red;
		color3 = green;
		color4 = yellow;
		color5 = purple;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.black;
		walls = grey;
		catcher = green;
		lives = green;
		invertedtext = Color.white;
		
	}
	public static void setPurple()
	{
		theme = "Purple Prism";
		words = purple;
		gameArea = Color.black;
		background = grey;
		color1 = blue;
		color2 = red;
		color3 = green;
		color4 = yellow;
		color5 = purple;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.black;
		walls = grey;
		lives = purple;
		invertedtext = Color.white;
		catcher = purple;
		
	}
	public static void setGrey()
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

	public static void setRedBlue()
	{
		theme = "Red-Blue";
		words = blue;
		gameArea = Color.black;
		background = Color.black;
		color1 = blue;
		color2 = red;
		color3 = blue;
		color4 = red;
		color5 = blue;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.white;
		walls = Color.black;
		catcher = verydarkgrey;
		invertedtext = Color.black;
		lives = blue;

	}

	public static void setBlack()
	{
		theme = "Red-Blue";
		words = blue;
		gameArea = Color.black;
		background = Color.black;
		color1 = blue;
		color2 = red;
		color3 = green;
		color4 = yellow;
		color5 = purple;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.white;
		walls = Color.black;
		catcher = yellow;
		invertedtext = Color.black;
		lives = yellow;
		
	}
	public static void setCyberPunk()
	{
		theme = "Cyberpunk";
		words = blue;
		gameArea = Color.black;
		background = Color.black;
		color1 = cyberpurple;
		color2 = yellow;
		color3 = cyberblue;
		color4 =  yellow;
		color5 = pink;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.white;
		walls = Color.black;
		catcher = cyberblue;
		invertedtext = Color.black;
		lives = purple;
		
	}


	public static void setBlackOut()
	{
		theme = "Blackout";
		words = blue;
		gameArea = Color.black;
		background = Color.black;
		color1 = blue;
		color2 = blue;
		color3 = blue;
		color4 = blue;
		color5 = blue;
		pegs = Color.black;
		dispensers = Color.black;
		text = Color.white;
		walls = Color.black;
		catcher = blue;
		invertedtext = Color.black;
		lives = blue;
		
	}
	public static void setRed()
	{
		theme = "Red Prism";
		words = red;
		gameArea = Color.black;
		background = grey;
		color1 = blue;
		color2 = red;
		color3 = green;
		color4 = yellow;
		color5 = purple;
		pegs = verydarkgrey;
		dispensers = verydarkgrey;
		text = Color.black;
		walls = grey;
		catcher = red;
		lives = red;
		invertedtext = Color.white;
	}
	void Update () {
		
	}
	void Awake()
	{
		//DontDestroyOnLoad(transform.gameObject);
	}
}
