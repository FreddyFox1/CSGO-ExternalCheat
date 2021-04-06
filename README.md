# CSGO External Cheat

```This code is written for educational and entertainment purposes and does not encourage use. The author is not responsible for its use and possible blocking in the game```


<p>External cheat for game Counter-Strike Global Offensive this is a file with extension *.exe, which using HANDLE process of CS GO to is READING and WRITING in RAM some values</p>

This project include:
<ul>
  <li>Simple form for cheat</li>
  <li>Library for using in your project</li>
</ul>


## Example using
```CSharp
using Engine.General;
using Engine.Globals;

public class Cheat 
{
    //Create base variable for using cheat
    private BaseVars bs;
    public Cheat()
    {
        //Initialize variable with process name 'csgo'
        bs = new BaseVars("csgo");
        WallhackOn();
    }
  
    private void WallhackOn()
    {
        new Thread(() =>
        {
            //Send base variable to Engine
            Engine.General.Wallhack.OnWallHack(bs);
        })
        {
            IsBackground = true,
            Priority = ThreadPriority.Normal
        }.Start();
    }
}
```
<h3>Cheat in game</h3>
<img src="https://user-images.githubusercontent.com/35505083/108830013-eb3e1700-75d9-11eb-9119-f4d759f0d35d.jpg" alt="Меню чита" height="300"/>


