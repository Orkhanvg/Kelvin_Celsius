namespace Kelvin_Celsius.Model
{
    class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)

        {
        Degree = degree;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree+273);
        }
    }
}
