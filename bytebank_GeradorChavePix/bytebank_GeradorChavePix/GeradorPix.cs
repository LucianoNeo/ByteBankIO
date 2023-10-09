namespace bytebank_GeradorChavePix
{
    public static class GeradorPix
    {
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        public static List<string> GetChavesPix(int numeroChaves)
        {
            var chaves = new List<string>();
            if (numeroChaves <= 0) return null;
            else
            {
                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}