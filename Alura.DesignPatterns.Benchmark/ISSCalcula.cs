using Alura.DesignPatterns.App.Entities;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;

namespace Alura.DesignPatterns.Benchmark
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ISSCalcula
    {
        Orcamento orcamento = new Orcamento((decimal)1000.0);
        ISS iss = new ISS();

        [Benchmark]
        public void ISSCalculaComOrcamentoTipoDecimal()
        {
            iss.Calcula(orcamento);
        }
    }
}
