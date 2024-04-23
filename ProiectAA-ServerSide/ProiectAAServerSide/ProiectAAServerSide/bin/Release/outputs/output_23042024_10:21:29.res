sim-outorder: SimpleScalar/PISA Tool Set version 3.0 of November, 2000.
Copyright (c) 1994-2000 by Todd M. Austin.  All Rights Reserved.
This version of SimpleScalar is licensed for academic non-commercial use only.

sim: command line: /home/dulea/Documents/University/RpoiectAA/ProiectAA-ServerSide/ProiectAAServerSide/ProiectAAServerSide/bin/Release/sim/sim-outorder -redir:sim outputs/output_23042024_10:21:29.res -max:inst 5000000 -cache:il1 il1:128:16:1:l -fetch:ifqsize 4 -fetch:mplat 3 -issue:inorder true -issue:width 16 -ruu:size 16 benchs/ss/su2cor.ss 

sim: simulation started @ Tue Apr 23 10:21:29 2024, options follow:

sim-outorder: This simulator implements a very detailed out-of-order issue
superscalar processor with a two-level memory system and speculative
execution support.  This simulator is a performance simulator, tracking the
latency of all pipeline operations.

# -config                     # load configuration from a file
# -dumpconfig                 # dump configuration to a file
# -h                    false # print help message    
# -v                    false # verbose operation     
# -d                    false # enable debug message  
# -i                    false # start in Dlite debugger
-seed                       1 # random number generator seed (0 for timer seed)
# -q                    false # initialize and terminate immediately
# -chkpt               <null> # restore EIO trace execution from <fname>
# -redir:sim     outputs/output_23042024_10:21:29.res # redirect simulator output to file (non-interactive only)
# -redir:prog          <null> # redirect simulated program output to file
-nice                       0 # simulator scheduling priority
-max:inst             5000000 # maximum number of inst's to execute
-fastfwd                    0 # number of insts skipped before timing starts
# -ptrace              <null> # generate pipetrace, i.e., <fname|stdout|stderr> <range>
-fetch:ifqsize              4 # instruction fetch queue size (in insts)
-fetch:mplat                3 # extra branch mis-prediction latency
-fetch:speed                1 # speed of front-end of machine relative to execution core
-bpred                  bimod # branch predictor type {nottaken|taken|perfect|bimod|2lev|comb}
-bpred:bimod     2048 # bimodal predictor config (<table size>)
-bpred:2lev      1 1024 8 0 # 2-level predictor config (<l1size> <l2size> <hist_size> <xor>)
-bpred:comb      1024 # combining predictor config (<meta_table_size>)
-bpred:ras                  8 # return address stack size (0 for no return stack)
-bpred:btb       512 4 # BTB config (<num_sets> <associativity>)
# -bpred:spec_update       <null> # speculative predictors update in {ID|WB} (default non-spec)
-decode:width               4 # instruction decode B/W (insts/cycle)
-issue:width               16 # instruction issue B/W (insts/cycle)
-issue:inorder           true # run pipeline with in-order issue
-issue:wrongpath         true # issue instructions down wrong execution paths
-commit:width               4 # instruction commit B/W (insts/cycle)
-ruu:size                  16 # register update unit (RUU) size
-lsq:size                   8 # load/store queue (LSQ) size
-cache:dl1       dl1:128:32:4:l # l1 data cache config, i.e., {<config>|none}
-cache:dl1lat               1 # l1 data cache hit latency (in cycles)
-cache:dl2       ul2:1024:64:4:l # l2 data cache config, i.e., {<config>|none}
-cache:dl2lat               6 # l2 data cache hit latency (in cycles)
-cache:il1       il1:128:16:1:l # l1 inst cache config, i.e., {<config>|dl1|dl2|none}
-cache:il1lat               1 # l1 instruction cache hit latency (in cycles)
-cache:il2                dl2 # l2 instruction cache config, i.e., {<config>|dl2|none}
-cache:il2lat               6 # l2 instruction cache hit latency (in cycles)
-cache:flush            false # flush caches on system calls
-cache:icompress        false # convert 64-bit inst addresses to 32-bit inst equivalents
-mem:lat         18 2 # memory access latency (<first_chunk> <inter_chunk>)
-mem:width                  8 # memory access bus width (in bytes)
-tlb:itlb        itlb:16:4096:4:l # instruction TLB config, i.e., {<config>|none}
-tlb:dtlb        dtlb:32:4096:4:l # data TLB config, i.e., {<config>|none}
-tlb:lat                   30 # inst/data TLB miss latency (in cycles)
-res:ialu                   4 # total number of integer ALU's available
-res:imult                  1 # total number of integer multiplier/dividers available
-res:memport                2 # total number of memory system ports available (to CPU)
-res:fpalu                  4 # total number of floating point ALU's available
-res:fpmult                 1 # total number of floating point multiplier/dividers available
# -pcstat              <null> # profile stat(s) against text addr's (mult uses ok)
-bugcompat              false # operate in backward-compatible bugs mode (for testing only)

  Pipetrace range arguments are formatted as follows:

    {{@|#}<start>}:{{@|#|+}<end>}

  Both ends of the range are optional, if neither are specified, the entire
  execution is traced.  Ranges that start with a `@' designate an address
  range to be traced, those that start with an `#' designate a cycle count
  range.  All other range values represent an instruction count range.  The
  second argument, if specified with a `+', indicates a value relative
  to the first argument, e.g., 1000:+100 == 1000:1100.  Program symbols may
  be used in all contexts.

    Examples:   -ptrace FOO.trc #0:#1000
                -ptrace BAR.trc @2000:
                -ptrace BLAH.trc :1500
                -ptrace UXXE.trc :
                -ptrace FOOBAR.trc @main:+278

  Branch predictor configuration examples for 2-level predictor:
    Configurations:   N, M, W, X
      N   # entries in first level (# of shift register(s))
      W   width of shift register(s)
      M   # entries in 2nd level (# of counters, or other FSM)
      X   (yes-1/no-0) xor history and address for 2nd level index
    Sample predictors:
      GAg     : 1, W, 2^W, 0
      GAp     : 1, W, M (M > 2^W), 0
      PAg     : N, W, 2^W, 0
      PAp     : N, W, M (M == 2^(N+W)), 0
      gshare  : 1, W, 2^W, 1
  Predictor `comb' combines a bimodal and a 2-level predictor.

  The cache config parameter <config> has the following format:

    <name>:<nsets>:<bsize>:<assoc>:<repl>

    <name>   - name of the cache being defined
    <nsets>  - number of sets in the cache
    <bsize>  - block size of the cache
    <assoc>  - associativity of the cache
    <repl>   - block replacement strategy, 'l'-LRU, 'f'-FIFO, 'r'-random

    Examples:   -cache:dl1 dl1:4096:32:1:l
                -dtlb dtlb:128:4096:32:r

  Cache levels can be unified by pointing a level of the instruction cache
  hierarchy at the data cache hiearchy using the "dl1" and "dl2" cache
  configuration arguments.  Most sensible combinations are supported, e.g.,

    A unified l2 cache (il2 is pointed at dl2):
      -cache:il1 il1:128:64:1:l -cache:il2 dl2
      -cache:dl1 dl1:256:32:1:l -cache:dl2 ul2:1024:64:2:l

    Or, a fully unified cache hierarchy (il1 pointed at dl1):
      -cache:il1 dl1
      -cache:dl1 ul1:256:32:1:l -cache:dl2 ul2:1024:64:2:l



sim: ** starting performance simulation **
warning: syscall: sigvec ignored
warning: syscall: sigvec ignored
warning: syscall: sigvec ignored
warning: syscall: sigvec ignored
warning: syscall: sigvec ignored
warning: syscall: sigvec ignored

sim: ** simulation statistics **
sim_num_insn                5000000 # total number of instructions committed
sim_num_refs                1420081 # total number of loads and stores committed
sim_num_loads                826894 # total number of loads committed
sim_num_stores          593187.0000 # total number of stores committed
sim_num_branches             767204 # total number of branches committed
sim_elapsed_time                  1 # total simulation time in seconds
sim_inst_rate          5000000.0000 # simulation speed (in insts/sec)
sim_total_insn              5614222 # total number of instructions executed
sim_total_refs              1515644 # total number of loads and stores executed
sim_total_loads              836358 # total number of loads executed
sim_total_stores        679286.0000 # total number of stores executed
sim_total_branches           768180 # total number of branches executed
sim_cycle                   5959040 # total simulation time in cycles
sim_IPC                      0.8391 # instructions per cycle
sim_CPI                      1.1918 # cycles per instruction
sim_exec_BW                  0.9421 # total instructions (mis-spec + committed) per cycle
sim_IPB                      6.5172 # instruction per branch
IFQ_count                  20216855 # cumulative IFQ occupancy
IFQ_fcount                  4756280 # cumulative IFQ full count
ifq_occupancy                3.3926 # avg IFQ occupancy (insn's)
ifq_rate                     0.9421 # avg IFQ dispatch rate (insn/cycle)
ifq_latency                  3.6010 # avg IFQ occupant latency (cycle's)
ifq_full                     0.7982 # fraction of time (cycle's) IFQ was full
RUU_count                  17071041 # cumulative RUU occupancy
RUU_fcount                        0 # cumulative RUU full count
ruu_occupancy                2.8647 # avg RUU occupancy (insn's)
ruu_rate                     0.9421 # avg RUU dispatch rate (insn/cycle)
ruu_latency                  3.0407 # avg RUU occupant latency (cycle's)
ruu_full                     0.0000 # fraction of time (cycle's) RUU was full
LSQ_count                   5307293 # cumulative LSQ occupancy
LSQ_fcount                        0 # cumulative LSQ full count
lsq_occupancy                0.8906 # avg LSQ occupancy (insn's)
lsq_rate                     0.9421 # avg LSQ dispatch rate (insn/cycle)
lsq_latency                  0.9453 # avg LSQ occupant latency (cycle's)
lsq_full                     0.0000 # fraction of time (cycle's) LSQ was full
sim_slip                   27578226 # total number of slip cycles
avg_sim_slip                 5.5156 # the average slip between issue and retirement
bpred_bimod.lookups          858546 # total number of bpred lookups
bpred_bimod.updates          767204 # total number of updates
bpred_bimod.addr_hits        584631 # total number of address-predicted hits
bpred_bimod.dir_hits         585839 # total number of direction-predicted hits (includes addr-hits)
bpred_bimod.misses           181365 # total number of misses
bpred_bimod.jr_hits            2194 # total number of address-predicted hits for JR's
bpred_bimod.jr_seen            2870 # total number of JR's seen
bpred_bimod.jr_non_ras_hits.PP          170 # total number of address-predicted hits for non-RAS JR's
bpred_bimod.jr_non_ras_seen.PP          798 # total number of non-RAS JR's seen
bpred_bimod.bpred_addr_rate    0.7620 # branch address-prediction rate (i.e., addr-hits/updates)
bpred_bimod.bpred_dir_rate    0.7636 # branch direction-prediction rate (i.e., all-hits/updates)
bpred_bimod.bpred_jr_rate    0.7645 # JR address-prediction rate (i.e., JR addr-hits/JRs seen)
bpred_bimod.bpred_jr_non_ras_rate.PP    0.2130 # non-RAS JR addr-pred rate (ie, non-RAS JR hits/JRs seen)
bpred_bimod.retstack_pushes         2262 # total number of address pushed onto ret-addr stack
bpred_bimod.retstack_pops         2116 # total number of address popped off of ret-addr stack
bpred_bimod.used_ras.PP         2072 # total number of RAS predictions used
bpred_bimod.ras_hits.PP         2024 # total number of RAS hits
bpred_bimod.ras_rate.PP    0.9768 # RAS prediction rate (i.e., RAS hits/used RAS)
il1.accesses                6365899 # total number of accesses
il1.hits                    6337583 # total number of hits
il1.misses                    28316 # total number of misses
il1.replacements              28188 # total number of replacements
il1.writebacks                    0 # total number of writebacks
il1.invalidations                 0 # total number of invalidations
il1.miss_rate                0.0044 # miss rate (i.e., misses/ref)
il1.repl_rate                0.0044 # replacement rate (i.e., repls/ref)
il1.wb_rate                  0.0000 # writeback rate (i.e., wrbks/ref)
il1.inv_rate                 0.0000 # invalidation rate (i.e., invs/ref)
dl1.accesses                1420080 # total number of accesses
dl1.hits                    1400723 # total number of hits
dl1.misses                    19357 # total number of misses
dl1.replacements              18845 # total number of replacements
dl1.writebacks                18602 # total number of writebacks
dl1.invalidations                 0 # total number of invalidations
dl1.miss_rate                0.0136 # miss rate (i.e., misses/ref)
dl1.repl_rate                0.0133 # replacement rate (i.e., repls/ref)
dl1.wb_rate                  0.0131 # writeback rate (i.e., wrbks/ref)
dl1.inv_rate                 0.0000 # invalidation rate (i.e., invs/ref)
ul2.accesses                  66275 # total number of accesses
ul2.hits                      62150 # total number of hits
ul2.misses                     4125 # total number of misses
ul2.replacements                472 # total number of replacements
ul2.writebacks                  221 # total number of writebacks
ul2.invalidations                 0 # total number of invalidations
ul2.miss_rate                0.0622 # miss rate (i.e., misses/ref)
ul2.repl_rate                0.0071 # replacement rate (i.e., repls/ref)
ul2.wb_rate                  0.0033 # writeback rate (i.e., wrbks/ref)
ul2.inv_rate                 0.0000 # invalidation rate (i.e., invs/ref)
itlb.accesses               6365899 # total number of accesses
itlb.hits                   6365856 # total number of hits
itlb.misses                      43 # total number of misses
itlb.replacements                 0 # total number of replacements
itlb.writebacks                   0 # total number of writebacks
itlb.invalidations                0 # total number of invalidations
itlb.miss_rate               0.0000 # miss rate (i.e., misses/ref)
itlb.repl_rate               0.0000 # replacement rate (i.e., repls/ref)
itlb.wb_rate                 0.0000 # writeback rate (i.e., wrbks/ref)
itlb.inv_rate                0.0000 # invalidation rate (i.e., invs/ref)
dtlb.accesses               1420081 # total number of accesses
dtlb.hits                   1420018 # total number of hits
dtlb.misses                      63 # total number of misses
dtlb.replacements                 0 # total number of replacements
dtlb.writebacks                   0 # total number of writebacks
dtlb.invalidations                0 # total number of invalidations
dtlb.miss_rate               0.0000 # miss rate (i.e., misses/ref)
dtlb.repl_rate               0.0000 # replacement rate (i.e., repls/ref)
dtlb.wb_rate                 0.0000 # writeback rate (i.e., wrbks/ref)
dtlb.inv_rate                0.0000 # invalidation rate (i.e., invs/ref)
sim_invalid_addrs                 0 # total non-speculative bogus addresses seen (debug var)
ld_text_base             0x00400000 # program text (code) segment base
ld_text_size                 259904 # program text (code) size in bytes
ld_data_base             0x10000000 # program initialized data segment base
ld_data_size                8743296 # program init'ed `.data' and uninit'ed `.bss' size in bytes
ld_stack_base            0x7fffc000 # program stack segment base (highest address in stack)
ld_stack_size                 16384 # program initial stack size
ld_prog_entry            0x00400140 # program entry point (initial PC)
ld_environ_base          0x7fff8000 # program environment base address address
ld_target_big_endian              0 # target executable endian-ness, non-zero if big endian
mem.page_count                  127 # total number of pages allocated
mem.page_mem                   508k # total size of memory pages allocated
mem.ptab_misses                 136 # total first level page table misses
mem.ptab_accesses          38474057 # total page table accesses
mem.ptab_miss_rate           0.0000 # first level page table miss rate

