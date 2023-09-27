namespace BusinessLogic
{
    public class CostCalculator
    {
        public CostCalculator()
        {
        }

        public double CalculateTotalCost(List<Baldosa> listaBaldosas, int precioMetroCuadrado)
        {
            int COSTO_CEMENTO = 5;
            int COSTO_LADRILLO = 10;
            double totalCost = 0;
            foreach (var baldosa in listaBaldosas)
            {
                if (baldosa.Forma == "Cuadrado")
                {
                    if(baldosa.Material == "Cemento")
                    {
                        totalCost += baldosa.Medida * baldosa.Medida * precioMetroCuadrado * COSTO_CEMENTO;
                    }
                    else if (baldosa.Material == "Ladrillo")
                    {
                        totalCost += baldosa.Medida * baldosa.Medida * precioMetroCuadrado * COSTO_LADRILLO;
                    }
                }
                else if (baldosa.Forma == "Circulo")
                {
                    if(baldosa.Material == "Cemento")
                    {
                        totalCost += Math.PI * baldosa.Medida * baldosa.Medida * precioMetroCuadrado * COSTO_CEMENTO;
                    }
                    else if (baldosa.Material == "Ladrillo")
                    {
                        totalCost += Math.PI * baldosa.Medida * baldosa.Medida * precioMetroCuadrado * COSTO_LADRILLO;
                    }
                }
            }
            return totalCost;
        }
    }
}