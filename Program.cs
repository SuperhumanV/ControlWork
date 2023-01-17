string[] beginArray = new string[5]
{'321','qwerty','Ubuntu','Debian','SentOS'};
string[] endArray = new
string[beginArray.Length];

void GetArrEnd(string[]
beginArray,string[] endArray)
{
    int count = 0;
    for(int i = 0; i< beginArray.Length;i++)
    {
        if (beginArray[i].Length<=3)
        {
            endArray[count] = beginArray[i];
            count++;
        }
    }
}
