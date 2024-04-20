using System;
namespace ProiectAA
{
    public class SimData
    {
        public string getCommand() {
            string command = "-redir:sim {OutputFile}.res -max:inst {NrInstructions} -cache:{CacheType} {CacheDetails} -fetch:ifqsie {IFQsize} -fetch:mplat {Mplat} -issue:inorder {IssueInOrder} -issue_width {IssueWidth} -ruu:size {RUU} -lsq:size {LSQ} {benchmark}";

            command.Replace("{NrInstructions}", NrInstructions)
                .Replace("{CacheType}", CacheType)
                .Replace("{CacheDetails}", getCacheDetails())
                .Replace("{IFQsize}", IFQsize)
                .Replace("{Mplat}", Mplat)
                .Replace("{IssueInOrder}", IssueInOrder)
                .Replace("{IssueWidth}", IssueWidth)
                .Replace("{RUU}", RUU)
                .Replace("{LSQ}", LSQ);

            return command;
        }

        private string getCacheDetails()
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