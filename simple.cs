 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;



public class simple : identify
{

	public GameObject obd;
	//string url="";
	public int k = 100000;
	FileInfo[] items;
	//DirectoryInfo dir;
	public Text nam, prices,des;
	public GameObject ob;
	public float s = 10f;
	string[] words;
	public RawImage im;
	//AssetBundle testbundle;

	//string a = "0";
	//string pat = "Tandoori";

	// Use this for initialization
	//IEnumerator Start () {
	void Start() { 
		life = 0;
		//a = 0;
		//pat = "Tandoori";
		//testbundle.Unload(true);


		GameData gamedata = new GameData();
		string contents = System.IO.File.ReadAllText(Application.persistentDataPath + "/data.json");
		//string contents = System.IO.File.ReadAllText("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json");

		gamedata = JsonUtility.FromJson<GameData>(contents);



		DirectoryInfo dird = new DirectoryInfo(GetAndroidInternalFilesDir() + "//" + gamedata.CardName + "//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//");
		//DirectoryInfo dird = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/"+pat+"/objects/"+a.ToString()+"/sample1/");

		FileInfo[] items1 = dird.GetFiles();




		WWW wwwi = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//" + gamedata.CardName + "//Menu//Logo//logo.png"));
		//WWW wwwi = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/Logo/logo.png");

		//Debug.Log(url + items[i].Name);
		Texture2D sprites1 = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
		//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
		wwwi.LoadImageIntoTexture(sprites1);

		im.GetComponent<RawImage>().texture = sprites1;







		//prices.text = gamedata.Tandoori[a].name;


		if (pat == "Tandoori")
		{
			nam.text ="Name: "+ gamedata.Tandoori[a].name;
			prices.text ="Price: Rs."+ gamedata.Tandoori[a].price;
			des.text ="Decription:\n "+ gamedata.Tandoori[a].desc;
		}
		else if (pat == "Biryani")
		{
			nam.text = "Name: "+gamedata.Biryani[a].name;
			prices.text = "Price: Rs."+gamedata.Biryani[a].price;
			des.text = "Decription:\n " + gamedata.Biryani[a].desc;
		}
		else if (pat == "Juice")
		{
			nam.text = "Name: "+gamedata.Juice[a].name;
			prices.text = "Price: Rs."+gamedata.Juice[a].price;
			des.text = "Decription: \n" + gamedata.Juice[a].desc;
		}

		if (items1.Length == 1)
		{

			////////////WWW www = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/arone/test/testbundl");
			//WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//0403-0201//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//testbundl"));

			//string[] words;
			/////////////////while (!www.isDone)
				////////////////yield return null;
			//////////testbundle = www.assetBundle;
			/*if (testbundle != null)
			{

				Debug.Log("hiis");
				//t.text = "workdone";
				string[] k = testbundle.AllAssetNames();
				Debug.Log(k[0]);
				words = k[0].Split('/');
				var ds = testbundle.LoadAsset(words[3].Split('.')[0]) as GameObject;
				ob = Instantiate(ds, new Vector3(0, 0, 0), Quaternion.identity);
				ob.transform.Rotate(0f, 0f, 0f);
				Debug.Log(words[3].Split('.')[0]);

			}*/


		}
		else
		{
			//prices.text = "hii vamsi";

			//Debug.Log(a);
			//a=1;
			//prices.text = a.ToString() + "  " + pat;
			/*GameData gamedata = new GameData();
			string contents = System.IO.File.ReadAllText(GetAndroidInternalFilesDir() + "//0403-0201//Menu//data.json");
			//string contents = System.IO.File.ReadAllText("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json");

			gamedata = JsonUtility.FromJson<GameData>(contents);

			//prices.text = gamedata.Tandoori[a].name;


			if (pat == "Tandoori")
			{
				nam.text = gamedata.Tandoori[a].name;
				prices.text = gamedata.Tandoori[a].price;
			}
			else if (pat == "Biryani")
			{
				nam.text = gamedata.Biryani[a].name;
				prices.text = gamedata.Biryani[a].price;
			}
			else if (pat == "Juice")
			{
				nam.text = gamedata.Juice[a].name;
				prices.text = gamedata.Juice[a].price;
			}*/
			//pat = "Tandoori";
			//a = 0;
			//pat = "Tandoori";
			//prices.text = GetAndroidInternalFilesDir() + "//0403-0201//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//"+items[0].Name;
			//prices.text = "hi";
			try
			{
				DirectoryInfo dir = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//");
				//DirectoryInfo dir = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/"+pat+"/objects/"+a.ToString()+"/sample1/");

				items = dir.GetFiles();

				WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//" + items[k % items.Length].Name));
				//WWW www = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/" + pat + "/objects/" + a.ToString() + "/sample1/" + items[k % items.Length].Name);

				//Debug.Log(url + items[i].Name);
				Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
				//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
				www.LoadImageIntoTexture(sprites);

				//nam.text = "done";
				this.GetComponent<Renderer>().material.mainTexture = sprites;
				//nam.text = nam.text + " hii " + items.Length + "\n";// + GetFileURL(GetAndroidInternalFilesDir() + "//0403-0201//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//"+items[0].Name);

			}
			catch (Exception ed)
			{
				nam.text = ed.ToString() + "\n" + GetFileURL(GetAndroidInternalFilesDir() + "//0403-0201//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//");
			}

			/*DirectoryInfo dir2 = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/" + pat + "/objects/" + a.ToString() + "/sample1/");
			FileInfo[] items3 = dir2.GetFiles();
			string[] k1 = testbundle.GetAllAssetNames();
			words = k1[0].Split('/');
			var ds = testbundle.LoadAsset(words[3].Split('.')[0]) as GameObject;
			ob = Instantiate(ds, new Vector3(0, 0, 0), Quaternion.identity);
			ob.transform.Rotate(0f, 0f, 0f);*/
		}
	}


	public void Update()
	{

		GameData gamedata = new GameData();
		string contents = System.IO.File.ReadAllText(Application.persistentDataPath + "/data.json");
		//string contents = System.IO.File.ReadAllText("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json");

		gamedata = JsonUtility.FromJson<GameData>(contents);


		if (pat == "Tandoori")
		{
			nam.text = "Name: " + gamedata.Tandoori[a].name;
			prices.text = "Price: Rs." + gamedata.Tandoori[a].price;
			des.text = "Decription:\n " + gamedata.Tandoori[a].desc;
		}
		else if (pat == "Biryani")
		{
			nam.text = "Name: " + gamedata.Biryani[a].name;
			prices.text = "Price: Rs." + gamedata.Biryani[a].price;
			des.text = "Decription:\n " + gamedata.Biryani[a].desc;
		}
		else if (pat == "Juice")
		{
			nam.text = "Name: " + gamedata.Juice[a].name;
			prices.text = "Price: Rs." + gamedata.Juice[a].price;
			des.text = "Decription: \n" + gamedata.Juice[a].desc;
		}



		DirectoryInfo dir1 = new DirectoryInfo(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//");
		//DirectoryInfo dir1 = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/"+pat+"/objects/"+a.ToString()+"/sample1/");

		FileInfo[] items2 = dir1.GetFiles();


		

		if (items2.Length == 1)
		{

			

			Debug.Log(life);
			if ( life == 0)
			{

				/*Debug.Log("hiis");
				//t.text = "workdone";
				//WWW www1 = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/arone/test/testbundl");
				//while (!www.isDone)
					//yield return null;
				//testbundle = www1.assetBundle;
				string[] k = testbundle.GetAllAssetNames();
				Debug.Log(k[0]);
				words = k[0].Split('/');
				var ds = testbundle.LoadAsset(words[3].Split('.')[0]) as GameObject;
				ob = Instantiate(ds, new Vector3(0, 0, 0), Quaternion.identity);
				ob.transform.Rotate(0f, 0f, 0f);
				Debug.Log(words[3].Split('.')[0]);
				life = life + 1;*/

				StartCoroutine(krish());


			}

			//testbundle.Unload(true);

			OnMouseDrag();

		}
		else
		{ 
			OnDrag();

		}

	

	}

	IEnumerator krish()
	{


		GameData gamedata = new GameData();
		string contents = System.IO.File.ReadAllText(Application.persistentDataPath + "/data.json");
		//string contents = System.IO.File.ReadAllText("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json");

		gamedata = JsonUtility.FromJson<GameData>(contents);




		//WWW www = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/arone/test/testbundl");
		WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//testbundl"));

		string[] words;
		while (!www.isDone)
			yield return null;
		AssetBundle testbundle = www.assetBundle;
		if (testbundle != null)
		{

			Debug.Log("hiis");
			//t.text = "workdone";
			string[] k = testbundle.AllAssetNames();
			Debug.Log(k[0]);
			words = k[0].Split('/');
			var ds = testbundle.LoadAsset(words[3].Split('.')[0]) as GameObject;
			ob = Instantiate(ds, new Vector3(0, 0, 0), Quaternion.identity);
			ob.transform.Rotate(0f, 0f, 0f);
			Debug.Log(words[3].Split('.')[0]);

		}
		testbundle.Unload(false);
	}


	public void OnMouseDrag()
	{
		//Debug.Log("djskal");
		float x = Input.GetAxis("Mouse X") * s * Mathf.Deg2Rad;
		//float y = Input.GetAxis("Mouse Y") * s * Mathf.Deg2Rad;
		ob.transform.RotateAround(Vector3.up, -x);
		//ob.transform.RotateAround(Vector3.right, y);

	}

	public void OnDrag()
	{
		if (Input.GetAxis("Mouse X") < -0.8f)
		{
			k = k + 1;
			vamsi(k);
			//Debug.Log("positive");
		}
		if (Input.GetAxis("Mouse X") > 0.8f)
		{
			k = k - 1;
			vamsi(k);
			//Debug.Log("negative");
		}
	}


	public void vamsi(int i)
	{

		GameData gamedata = new GameData();
		string contents = System.IO.File.ReadAllText(Application.persistentDataPath + "/data.json");
		//string contents = System.IO.File.ReadAllText("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json");

		gamedata = JsonUtility.FromJson<GameData>(contents);


		//WWW www = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/" + pat + "/objects/" + a.ToString() + "/sample1/" + items[i % items.Length].Name);
		WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//" + items[i%items.Length].Name));
		
		//Debug.Log(url + items[i].Name);
		Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
		//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
		www.LoadImageIntoTexture(sprites);

		//nam.text = "done";
		this.GetComponent<Renderer>().material.mainTexture = sprites;

	
	}


	public void next()
	{
		a += 1;
		ob = this.gameObject;
		//pat = "Tandoori";

		GameData gamedata = new GameData();
		string contents = System.IO.File.ReadAllText(Application.persistentDataPath + "/data.json");
		//string contents = System.IO.File.ReadAllText("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/data.json");

		gamedata = JsonUtility.FromJson<GameData>(contents);


		DirectoryInfo dird = new DirectoryInfo(GetAndroidInternalFilesDir() + "//" + gamedata.CardName + "//Menu//" + pat + "//items//");
		//DirectoryInfo dird = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/" + pat + "/items/");

		FileInfo[] items= dird.GetFiles();

		if (a > items.Length)
		{
			a = 0;
		}


		DirectoryInfo dir1 = new DirectoryInfo(GetAndroidInternalFilesDir() + "//" + gamedata.CardName + "//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//");
		//DirectoryInfo dir1 = new DirectoryInfo("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/" + pat + "/objects/" + a.ToString() + "/sample1/");

		FileInfo[] items2 = dir1.GetFiles();





		//WWW www = new WWW("C:/Users/vamsi_56ftbm4/OneDrive/Desktop/Challenge/Menu/" + pat + "/objects/" + a.ToString() + "/sample1/" + items2[k % items2.Length].Name);
		WWW www = new WWW(GetFileURL(GetAndroidInternalFilesDir() + "//"+gamedata.CardName+"//Menu//" + pat + "//objects//" + a.ToString() + "//sample1//" + items[k%items.Length].Name));

		//Debug.Log(url + items[i].Name);
		Texture2D sprites = new Texture2D(1024, 1024, TextureFormat.DXT1, false);
		//LoadImageIntoTexture compresses JPGs by DXT1 and PNGs by DXT5     
		www.LoadImageIntoTexture(sprites);

		//nam.text = "done";
		this.GetComponent<Renderer>().material.mainTexture = sprites;






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


	// Update is called once per frame
	
}
