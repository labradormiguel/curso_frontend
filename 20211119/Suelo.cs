using System.Collections.Generic;
namespace curso_frontend
{
    public class Suelo
    {
        public List<Azulejo> azulejos { get; set; }
        public Suelo()
        {
            azulejos = new List<Azulejo>();
        }
        public void AddAzulejo(Azulejo a)
        {
            azulejos.Add(a);
        }
        public int AreaTotal()
        {
            int total = 0;
            for (int i = 0; i < azulejos.Count; i++)
            {
                total = total + azulejos[i].Area();
            }
            return total;
        }
    }
}