using System;

namespace APIcatalogo.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() : base("Este Jogo já está cadastrado")
        {}
    }
}