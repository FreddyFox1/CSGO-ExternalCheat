# CSGO External Cheat

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

public class Form : Form 
{
    private BaseVars bs;
    public Form()
    {
        InitializeComponent();
        bs = new BaseVars("csgo");
        WallhackOn();
    }
  
    private void WallhackOn()
    {
        new Thread(() =>
        {
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

