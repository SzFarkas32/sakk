public class Negyzet
{
    bool empty;
    string color;
    int indexX;
    int indexY;
    Babu babu;

    public Negyzet(int x, int y, string color)
    {
        indexX = x;
        indexY = y;
        this.color = color;
        empty = true;
        babu = null;
    }

    public Negyzet(int x, int y, string color, Babu babu)
    {
        indexX = x;
        indexY = y;
        this.color = color;
        empty = false;
        this.babu = babu;
    }
}
