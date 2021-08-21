using System;

namespace APIcatalogo.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException() : base("Este jogo não está cadastrado")
        {}
    }
}