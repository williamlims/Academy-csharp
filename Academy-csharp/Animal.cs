namespace Academy_csharp
{
    class Animal
    {
        private string nome;
        private string tipo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Animal(string a, string b)
        {
            Nome = a;
            Tipo = b;
        }

    }
}
