using System.Security.Cryptography;

public class Hold 
{
    private int _top; 
    private int _bottom;

    public Hold() 
    {
        _top = 1;
        _bottom = 1;
    }

    public Hold (int top)
    {   
        _top = top;
        _bottom = 1;
    }

    public Hold (int top, int bottom)
    {
        _top = top ;
        _bottom = bottom;
    } 

    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }



}   