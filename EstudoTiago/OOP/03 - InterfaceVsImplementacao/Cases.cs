using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {

        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {

        }
    }

    public class UsoImplementação
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementação
    {
        public TesteInterfaceImplementação()
        {
            var repImp = new UsoImplementação();
            repImp.Processo();

            var repAbs = new UsoAbstracao(new Repositorio());
            repAbs.Processo();

            var repAbsFake = new UsoAbstracao(new RepositorioFake());
            repAbsFake.Processo();
        }
    }
}

