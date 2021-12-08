namespace ex32.Entities
{
    class Alunos
    {
        public int NumeroDeMatricula { get; set; }

        public Alunos(int numeroDeMatricula)
        {
            NumeroDeMatricula = numeroDeMatricula;
        }

        public override int GetHashCode()
        {
            return NumeroDeMatricula.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Alunos))
            {
                return false;
            }

            Alunos other = obj as Alunos;
            return NumeroDeMatricula.Equals(other.NumeroDeMatricula);
        }
    }
}