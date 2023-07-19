
    class Animal
    {
        public string? Nome { get; set; }
        public virtual void ExibeNome()
        {
            Console.WriteLine($"\nMeu nome é {Nome}");
        }
    }
