public abstract class Shape
{
    private string _color;
    public Shape(string color){
        _color = color;
    }
    public string GeColor(){
        return _color;
    }
    public void SetShape(string color){
        _color = color;
    }
    public abstract float GetArea();

}