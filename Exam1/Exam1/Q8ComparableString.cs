using System.Drawing;

namespace Exam1;

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (x==null && y=="")
        {
            return -1;
        }
        else if (x=="" && y==null)
        {
            return 1;
        }
        else if (x==null && y==null)
        {
            return 0;
        }
        else if (x==null)
        {
            return -1;
        }
        else if (y==null)
        {
            return 1;
        }
        else
        {
            if (x.Length.CompareTo(y.Length)==0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i].CompareTo(y[i])>0)
                    {
                        return 1;
                    }
                    else if(x[i].CompareTo(y[i])<0)
                    {
                        return -1;
                    }
                }
                return 0;
            }
            else
            {
                return x.Length.CompareTo(y.Length);
            }
        }
        return 0;
    }
}

public class Q8ComparableString
{
    public string Str{get;set;}
    public Q8ComparableString(string str)
    {
        Str=str;
    }

    public static bool operator>(Q8ComparableString str1, Q8ComparableString str2)=>!(str1<str2);
        
    public static bool operator<(Q8ComparableString str1, Q8ComparableString str2)
    {
        if (str1.Str==null && str2.Str=="")
        {
            return true;
        }
        else if (str1.Str=="" && str2.Str==null)
        {
            return false;
        }
        else if (str1.Str==null && str2.Str==null)
        {
            return false;
        }
        else if (str1.Str==null)
        {
            return true;
        }
        else if (str2.Str==null)
        {
            return false;
        }
        else
        {
            if (str1.Str.Length==str2.Str.Length)
            {
                bool flag=true;
                foreach (var itemx in str1.Str)
                {
                    foreach (var itemy in str2.Str)
                    {
                        if(itemx!=itemy)
                        {
                            flag=false;
                        }
                    }
                }
                if(flag==true)
                    return false;
                else if (flag==false)
                {
                    for (int i = 0; i < str1.Str.Length; i++)
                    {
                        if(str1.Str[i].CompareTo(str2.Str[i])>0)
                            return false;
                    }
                }
            }
            else
            {
                if (str1.Str.Length.CompareTo(str2.Str.Length)>0)
                {
                    return false;
                }
                return true;
            }
        }
        return false;
    } 
    public static bool operator==(Q8ComparableString str1, Q8ComparableString str2)
    { 
        if (str1.Str.Length == str2.Str.Length)
        {
            bool flag=true;
            for (int i = 0; i < str1.Str.Length; i++)
            {
                if(str1.Str[i]!=str2.Str[i])
                {
                    flag=false;
                    return flag;
                }

            }
            return flag;
        }
        else
        {
            return false;
        }
    }
    public static bool operator!=(Q8ComparableString str1,Q8ComparableString str2)=>!(str1.Str==str2.Str);

}