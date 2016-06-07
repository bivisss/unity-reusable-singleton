# Unity Reusable Singleton
Singleton design pattern that can be extended on subclasses.

Using this script, You will not need to write the singleton initializers in your classes. Just make your class extends Singleton and it will automatically have the singleton features.

This is a MonoBehaviour script, so you can use the Coroutines.

## How to use

1. Copy Singleton.cs script to your project.
2. Make your class extends Singleton.

  Example:
  ```unity
  public class MySingletonExample : Singleton<MySingletonExample> {
  	protected MySingletonExample () {} // guarantee this will be always a singleton only - can't use the constructor!
  
  	public string globalVar;
  
	void Awake () {
  		Debug.Log("Awoke Singleton Instance: " + gameObject.GetInstanceID());
  	}
  }
  ```
3. Now you can call your singleton class by Instance:

  ````unity
  MySingletonExample.Instance.globalVar = "A";
  Debug.Log ("globalVar: " + MySingletonExample.Instance.globalVar);
  ````

## Creating Singleton from Prefab

You can also use this Singleton from a Prefab, so you can set the properties values on Editor and have them loaded with your singleton:

1. Create a game object and add your Singleton Class to it.

  ![alt my-singleton-example-prefab](https://cloud.githubusercontent.com/assets/1541562/15846536/977572ae-2c54-11e6-81fc-eb19742bedb6.png)

2. Convert your game object to prefab and put it on Resources Folder. The prefab needs to have the same name as your Singleton Class (MySingletonExample in this example)

  ![alt resources-folder](https://cloud.githubusercontent.com/assets/1541562/15846537/97793664-2c54-11e6-85d6-2e62ed25244b.png)

3. Remove the Game Object from Scene (It will be created when you call MySingletonExample.Instance).

Now, when you call your singleton it will check for existing prefab with the same name on Resources folder to instantiate it. If none prefab is found, the singleton will be created as new.

#### Sources:
This script is based on following article http://wiki.unity3d.com/index.php/Singleton
