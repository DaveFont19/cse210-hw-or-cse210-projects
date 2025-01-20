class Fraction
{
    private int _top, _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber){
       _top = wholeNumber;
       _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _bottom = bottom;
        _top = top;
    }
    public string GetFractionString(){
        string fractionComplete = $"{_top} / {_bottom}";
        return fractionComplete;
    }
    public double GetDecimalValue(){
        return (double) _top / (double) _bottom; 
    }
}