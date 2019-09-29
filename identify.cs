using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Vuforia;
using UnityEngine.Experimental.XR;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
//using UnityEngine.Sprite;

public class identify : MonoBehaviour
{
	public static string b, c, d, e;
	public int vamsi = 0;
	public static int a;
	public static string pat,pats;
	public static string susmi;
	Texture2D tex;
	public static int life;
	static int s;
	//public SpriteRenderer bg;
	static string st;
	// public  GameObject H;
	//public static GameObject AB;
	string url3;


	public Button ob;
	public GameObject cub;
	int l = 0;

	int m = 0;
	int p = 0;
	List<Button> v = new List<Button>();
	List<Button> v1 = new List<Button>();
	List<Button> v2 = new List<Button>();
	List<Button> v3 = new List<Button>();
	List<Button> v4 = new List<Button>();
	public List<GameObject> sc = new List<GameObject>();
	public List<GameObject> con = new List<GameObject>();

	void Start()
	{
		vamsi = 0;
	}


	void Update()
	{
		ob = GameObject.Find("Button").GetComponent<Button>();

		StateManager sm = TrackerManager.Instance.GetStateManager();

		IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();


		foreach (TrackableBehaviour tb in tbs)
		{
			string name = tb.TrackableName;

			////Debug.Log(name);
			if (vamsi == 0)
			{
				susmi = name;
				if (name == "Tandoori")
				{
					m = 0;

					sc[0].GetComponent<ScrollRect>().scrollSensitivity = 5;
					//string url = "file:///storage/F0CC-3BFB/Menu/Tandoori/Items";
					//string url = Application.persistentDataPath+"/Tandoori/Items";
					//Debug.Log(url);
					GameData gamedata = new GameData();
					//string path = GetAndroidInternalFilesDir() + "//0403-0201" + "//Menu//data.json"; 
					//string path = "C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json"; 
					string path=Application.persistentDataPath+"/data.json";
					string contents = System.IO.File.ReadAllText(path);
					//JSONWrapper wrapper = JsonUtility.FromJson<JSONWrapper>(contents);
					gamedata = JsonUtility.FromJson<GameData>(contents);

					DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Tandoori//Items//");
					//DirectoryInfo dir = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/Tandoori/Items/");

					FileInfo[] items = dir.GetFiles();
					for (int i = 0; i < items.Length; i++)
					{
						Debug.Log(items[i].Name);
					}

					vamsi = vamsi + 1;
					for (int i = 0; i < items.Length; i++)
					{
						var k = Instantiate(ob, con[0].transform.position + new Vector3(40f, 0f, 0f), Quaternion.identity);
						k.transform.SetParent(con[0].transform);
						//k.transform.Rotate(180f, 0f, 0f);
						v.Add(k);
						string st = m.ToString();

						

						WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Tandoori//Items//"+items[i].Name));
						//WWW www = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/Tandoori/Items/"+ items[i].Name);

						//Debug.Log(url + items[i].Name);
						Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
						//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
						www.LoadImageIntoTexture(sprites);

						
						k.GetComponent<RawImage>().texture = sprites ;

						k.GetComponentInChildren<Text>().text = gamedata.Tandoori[i].name;
						int h = m;
						
						//cub.GetComponent<Renderer>().material.mainTexture = sprites;

						v[i].GetComponent<Button>().onClick.AddListener(() => TaskOnClick(h,"Tandoori"));
						m += 1;
					}
					pat = "Tandoori";
					//vamsi = 0;
				}

				if (name == "Biriyani")
				{
					m = 0;
					//String st;

					GameData gamedata = new GameData();
					//string path = GetAndroidInternalFilesDir() + "//0403-0201" + "//Menu//data.json"; 
					//string path = "C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json"; 
					string path = Application.persistentDataPath + "/data.json";
					string contents = System.IO.File.ReadAllText(path);
					//JSONWrapper wrapper = JsonUtility.FromJson<JSONWrapper>(contents);
					gamedata = JsonUtility.FromJson<GameData>(contents);





					sc[1].GetComponent<ScrollRect>().scrollSensitivity = 5;
					DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Biryani//Items//");
					FileInfo[] items = dir.GetFiles();
					
					//string path = Application.persistentDataPath + "/data.json";
					

					vamsi = vamsi + 1;
					for (int i = 0; i < items.Length; i++)
					{
						var k = Instantiate(ob, con[1].transform.position + new Vector3(40f, 0f, 0f), Quaternion.identity);
						k.transform.SetParent(con[1].transform);
						//k.transform.Rotate(180f, 0f, 0f);
						v1.Add(k);
						string st = m.ToString();

						WWW www = new WWW( GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Biryani//Items//" + items[i].Name));
						//Debug.Log(url + items[i].Name);
						Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
						//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
						www.LoadImageIntoTexture(sprites);


						k.GetComponent<RawImage>().texture = sprites;
						k.GetComponentInChildren<Text>().text = gamedata.Biryani[i].name;
						int h = m;
						v1[m].GetComponent<Button>().onClick.AddListener(() => TaskOnClick(h,"Biryani"));
						m += 1;
					}
					//  v[m].GetComponent<Button>().onClick.AddListener(() => TaskOnClick(st));
					
					pat = "Biryani";
					//vamsi = 0;
				}

				if (name == "Juices")
				{
					m = 0;
					GameData gamedata = new GameData();
					////Debug.Log("1");
					sc[4].GetComponent<ScrollRect>().scrollSensitivity = 5;
					DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Juice//Items//");
					FileInfo[] items = dir.GetFiles();
					vamsi = vamsi + 1;
					string contents = System.IO.File.ReadAllText(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//data.json");
					gamedata = JsonUtility.FromJson<GameData>(contents);


					for (int i = 0; i < items.Length; i++)
					{
						var k = Instantiate(ob, con[4].transform.position + new Vector3(40f, 0f, 0f), Quaternion.identity);
						k.transform.SetParent(con[4].transform);
						//k.transform.Rotate(180f, 0f, 0f);
						v4.Add(k);
						string st = m.ToString();

						WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Juice//Items//" + items[i].Name));
						//Debug.Log(url + items[i].Name);
						Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
						//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
						www.LoadImageIntoTexture(sprites);


						k.GetComponent<RawImage>().texture = sprites;
						////Debug.Log("chinni"+st+m);
						//cub.GetComponent<Renderer>().material.mainTexture = sprites;
						k.GetComponentInChildren<Text>().text = gamedata.Juice[i].name;
						int h = m;
						v4[m].GetComponent<Button>().onClick.AddListener(() => TaskOnClick(h,"Juice"));
						m += 1;
					}
					pat = "Juice";
					// vamsi = 0;
				}
				if (name == "Cakes")
				{
					m = 0;
					GameData gamedata = new GameData();
					sc[2].GetComponent<ScrollRect>().scrollSensitivity = 5;
					DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Cake//Items//");
					FileInfo[] items = dir.GetFiles();
					vamsi = vamsi + 1;
					string contents = System.IO.File.ReadAllText(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//data.json"));
					gamedata = JsonUtility.FromJson<GameData>(contents);


					for (int i = 0; i < items.Length; i++)
					{
						var k = Instantiate(ob, con[2].transform.position + new Vector3(40f, 0f, 0f), Quaternion.identity);
						k.transform.SetParent(con[2].transform);
						//k.transform.Rotate(180f, 0f, 0f);
						v2.Add(k);
						string st = m.ToString();

						WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Cake//Items//" + items[i].Name));
						//Debug.Log(url + items[i].Name);
						Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
						//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
						www.LoadImageIntoTexture(sprites);


						k.GetComponent<RawImage>().texture = sprites;
						////Debug.Log("chinni"+st+m);
						//cub.GetComponent<Renderer>().material.mainTexture = sprites;
						int h = m;
						k.GetComponentInChildren<Text>().text = gamedata.Cake[i].name;
						v2[m].GetComponent<Button>().onClick.AddListener(() => TaskOnClick(h,"Cake"));
						m += 1;
					}

					pat = "Cake";
					//  vamsi = 0;
				}
				if (name == "Tiffins")
				{
					GameData gamedata = new GameData();
					m = 0;
					////Debug.Log("1");
					sc[3].GetComponent<ScrollRect>().scrollSensitivity = 5;
					DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Tiffin//Items//");
					FileInfo[] items = dir.GetFiles();
					vamsi = vamsi + 1;
					string contents = System.IO.File.ReadAllText(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//data.json");
					gamedata = JsonUtility.FromJson<GameData>(contents);




					for (int i = 0; i < items.Length; i++)
					{
						var k = Instantiate(ob, con[3].transform.position + new Vector3(40f, 0f, 0f), Quaternion.identity);
						k.transform.SetParent(con[3].transform);
						//k.transform.Rotate(180f, 0f, 0f);
						v3.Add(k);
						string st = m.ToString();

						WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//Tiffin//Items//" + items[i].Name));
						//Debug.Log(url + items[i].Name);
						Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
						//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
						www.LoadImageIntoTexture(sprites);

						int h = m;
						k.GetComponent<RawImage>().texture = sprites;
						////Debug.Log("chinni"+st+m);
						//cub.GetComponent<Renderer>().material.mainTexture = sprites;
						k.GetComponentInChildren<Text>().text = gamedata.Tiffin[i].name;
						v3[m].GetComponent<Button>().onClick.AddListener(() => TaskOnClick(h,"Tiffin"));
						m += 1;
					}
					pat = "Tiffin";
					// vamsi = 0;
				}
			}
			if (name != susmi)
			{
				vamsi = 0;
			}
		}
	}
	void TaskOnClick(int n,String k)
	{
		//Debug.Log("You have clicked the button!");
		Debug.Log(n);
		a = n;
		pat = k;
		life = 0;
		Debug.Log(life);
		//
		//pat = susmi;
		// vamsi = 0;
		//vam = n;

		GameData gamedata = new GameData();
		//string path = GetAndroidInternalFilesDir() + "//0403-0201" + "//Menu//data.json"; 
		//string path = "C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json"; 
		string path = Application.persistentDataPath + "/data.json";
		string contents = System.IO.File.ReadAllText(path);
		//JSONWrapper wrapper = JsonUtility.FromJson<JSONWrapper>(contents);
		gamedata = JsonUtility.FromJson<GameData>(contents);





		DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//");
		//DirectoryInfo dir = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/"+pat+"/objects/"+a.ToString()+"/sample1/");

		FileInfo[] items = dir.GetFiles();

		if (items.Length == 1)
		{
			SceneManager.LoadScene("sdf");
		}
		else
		{
			SceneManager.LoadScene("image");
		}
	}
	public static string GetAndroidInternalFilesDir()
	{
		string[] potentialDirectories = new string[]
		{
		"/storage",
		"/sdcard",
		"/storage/emulated/0",
		"/mnt/sdcard",
		"/storage/sdcard0",
		"/storage/sdcard1",
		"/SD Card"
		};
		if (Application.platform == RuntimePlatform.Android)
		{
			for (int i = 0; i < potentialDirectories.Length; i++)
			{
				if (Directory.Exists(potentialDirectories[i]))
				{
					return potentialDirectories[i];
				}
			}
		}
		return "";
	}
	public static string GetFileURL(string path)
	{
		return (new System.Uri(path)).AbsoluteUri;
	}
}

