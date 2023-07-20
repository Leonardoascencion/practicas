using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Collections.Generic;
int i = 0;

class Program
{
static void hacer_la_matriz()
{
string entrada = Console.ReadLine();
string[] queri = entrada.Split("");
foreach (string item in queri)
{
queri[i].ToLower();
queri [i] = Regex.Replace(queri[i],@"[^\w\s]",string.Empty);
i++;
}
Dictionary<string,Dictionary<string,int>> queriTF = new Dictionary<string,Dictionary<string,int>>();
foreach (string item in queri)
{
if(queriTF.ContainsKey(item)) queriTF[item][item]++;
else queriTF[item][item] = 1;
}
}
}

