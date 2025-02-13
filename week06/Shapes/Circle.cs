class Circle : Shape
{
    private float _radio;
    public Circle(string color, float radio): base(color){
        _radio = radio;
    }
    public override float GetArea()
    {
        return 3.1416f * (float)Math.Pow(_radio, 2);
    }
}