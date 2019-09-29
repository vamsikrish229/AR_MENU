using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class GameData
{
	//public string date="";
	//public string time="";
	public string CardName="";
	public List<Quest> Tandoori = new List<Quest>();
	public List<Quest> Biryani = new List<Quest>();
	public List<Quest> Cake = new List<Quest>();
	public List<Quest> Juice = new List<Quest>();
	public List<Quest> Tiffin = new List<Quest>();

}
[Serializable]
public class Quest
{
	public string ID = "";
	public string name = "";
	public string price = "";
	public string desc = "";

}

