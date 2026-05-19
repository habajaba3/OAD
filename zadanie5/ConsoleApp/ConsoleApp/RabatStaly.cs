public class RabatStaly : IRabat
{
    private double wartoscRabatu;

    public RabatStaly(double wartoscRabatu)
    {
        this.wartoscRabatu = wartoscRabatu;
    }

    public double Oblicz(double kwota)
    {
        double wynik = kwota - wartoscRabatu;

        if (wynik < 0)
        {
            return 0;
        }

        return wynik;
    }
}