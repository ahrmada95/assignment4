using System;

public class Player
{

    //members
    public string name { get; private set; }
    public string alias { get; private set; }
    public string team { get; set; }
    public int mem_id { get; set; }
    public string role { get; set; }
    public int adr { get; set; }
    public int hs_per { get; set; }
    public string[] fav_maps;

    public Player()
    {
        name = "name";
        alias = "alias";
        team = "team";
        mem_id = 00000;
        role = "role";
        adr = 0;
        hs_per = 0;
        fav_maps = new string[] {"Inferno", "Nuke", "Mirage"};
    }

    public Player(string p_name, string p_alias)
    {
        name = p_name;
        alias = p_alias;
        team = "team";
        mem_id = 00000;
        role = "role";
        adr = 0;
        hs_per = 0;
        fav_maps = new string[] {"Inferno", "Nuke", "Mirage"};
    }

    public string this[int index]
    {
        get {return fav_maps[index];}
        set {fav_maps[index] = value;}
        
    }


    public static void Main(string[] args)
    {
        string s1mple_name = "Oleksandr Kostyliev";
        string s1mple_alias = "s1mple";

        new Player(s1mple_name, s1mple_alias);
    }
}



