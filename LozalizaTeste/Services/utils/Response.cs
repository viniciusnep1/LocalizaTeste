using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LozalizaTeste
{
    public class Response
    {
        public object Result { get; internal set; }

        public bool IsOk { get; internal set; }

        public string Mensagem { get; internal set; }

        public Exception Exception { get; internal set; }


        public Response()
        {
            IsOk = true;
            Exception = null;
            Mensagem = "Operação concluída com sucesso";
        }

        public Response(object entidade) : this()
        {
            Result = entidade;
        }

        public Response(object entidade, string mensagem) : this(mensagem)
        {
            Result = entidade;
        }

        public Response(string mensagem)
            : this()
        {
            Mensagem = mensagem;
        }

        public Response(bool isOk, string mensagem)
            : this(mensagem)
        {
            IsOk = isOk;
        }

        public Response(Exception erro)
        {
            IsOk = false;
            Exception = erro;
        }

    }
}