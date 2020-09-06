using Alura.DesignPatterns.App.Entities;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ISSCalculaSpeed
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
