using UnityEngine;

public class Constants
{
	public const string USERNAME = "user1";
	public const string PASSWORD = "pwd1";
	public const string ERROR_USERNAME = "Error: Wrong Username";
	public const string ERROR_PASSWORD = "Error: Wrong Password";

	#region Scenes Names

	public const string SCENE_LOGIN = "LoginScene";
	public const string SCENE_DEMO1 = "MainDemo1";
	public const string SCENE_DEMO2 = "MainDemo2";

	#endregion

	#region Preference strings

	public const string PREF_SCENE1_COUNT = "DemoScene1Count";
	public const string PREF_SCENE2_COUNT = "DemoScene2Count";


	#endregion

	#region URLs
	public const string REPO_URL = "https://github.com/itsharshdeep/2.5D-TestPrototype";

	#endregion
}

#region UnUsed Code

public class PrefData
{

	public static int SCENE1POINT {
		get { 
			if (PlayerPrefs.HasKey (Constants.PREF_SCENE1_COUNT))
				return PlayerPrefs.GetInt (Constants.PREF_SCENE1_COUNT);
			else
				return 0;	
			
		}
		set {
			PlayerPrefs.SetInt (Constants.PREF_SCENE1_COUNT, value);
		}
	}

	public static int SCENE2POINT {
		get { 
			if (PlayerPrefs.HasKey (Constants.PREF_SCENE2_COUNT))
				return PlayerPrefs.GetInt (Constants.PREF_SCENE2_COUNT);
			else
				return 0;	

		}
		set {
			PlayerPrefs.SetInt (Constants.PREF_SCENE2_COUNT, value);
		}
	}

}
#endregion
