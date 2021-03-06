﻿// Copyright (c) Dapplo and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using BenchmarkDotNet.Running;

namespace Dapplo.Windows.Tests.Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //BenchmarkRunner.Run<ClipboardBenchmarks>();
            //BenchmarkRunner.Run<EnumerateWindowsBenchmark>();
            //BenchmarkRunner.Run<InteropWindowBenchmark>();
            BenchmarkRunner.Run<ScreenboundsBenchmark>();
            Console.ReadKey();
        }
    }
}
