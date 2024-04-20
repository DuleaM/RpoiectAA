using System;
namespace ProiectAA
{
    public class SimData
    {
        public string getCommand() {
            return "";
        }
        private string getCache()
        {
            return $"{CacheType}:{CacheSets}:{CacheBlockSize}:{CacheAsoc}:l";
        }
        //BENCHMARK
        public string Benchmark { get; set; }

        //SIM GENERAL
        public string NrInstructions { get; set; }
        public string IssueInOrder { get; set; }
        public string IssueWidth { get; set; }
        public string IFQsize { get; set; }
        public string Mplat { get; set; }
        public string RUU { get; set; }
        public string LSQ { get; set; }

        //CACHE
        public string CacheType { get; set; }
        public string CacheSets { get; set; }
        public string CacheBlockSize { get; set; }
        public string CacheAsoc { get; set; }

    }
}