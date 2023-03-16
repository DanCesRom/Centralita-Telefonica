namespace CentralTelefonica
{
    
public class Llamada : Centralita
    {
        public virtual string NumOrigen()
        {
            return "829342865";
        }

        public virtual string NumDestino()
        {
            Random rnd = new Random();
            string rnd1 = Convert.ToString(rnd.Next(809000000, 809999999));
            return rnd1.ToString();
        }

        public virtual double Duracion()
        {
            Random rnd = new Random();
            Double rnd1 = Convert.ToDouble(rnd.Next(1, 2400));
            return rnd1;
       
        }
        
        
    }
}