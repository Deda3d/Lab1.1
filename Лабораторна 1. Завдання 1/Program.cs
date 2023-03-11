class Program
{
    static void Main(string[] args)
    {
        List<string> str = new List<string>();
        bool end = false;
        string s = null;
        while (end == false)
        {
            s = Console.ReadLine();
            if (s != "")
            {
                str.Add(s);
            }
            else end = true;
        }
        str.Sort((x, y) => x.Length.CompareTo(y.Length));
        foreach (object o in str)
        {
            Console.WriteLine(o);
        }
    }
}
//Не хотiлось в снiгу, в лiсi,
//Козацьку громаду
//З булавами, з бунчугами
//Збирать на пораду.
//Нехай душi козацькii
//В Украйнi витають –
//Там широко, там весело
//Од краю до краю...
//Як та воля, що минулась,
//Днiпр широкий – море,
//Степ i степ, ревуть пороги,
//i могили – гори, –
//Там родилась, гарцювала
//Козацькая воля;
//Там шляхтою, татарами
//Засiдала поле,
//Засiвала трупом поле,
//Поки не остило...