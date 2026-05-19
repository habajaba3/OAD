public class RabatProcentowy : IRabat
{
    private double procent;

    public RabatProcentowy(double procent)
    {
        this.procent = procent;
    }

    public double Oblicz(double kwota)
    {
        double wynik = kwota - (kwota * procent / 100);

        if (wynik < 0)
        {
            return 0;
        }

        return wynik;
    }
}