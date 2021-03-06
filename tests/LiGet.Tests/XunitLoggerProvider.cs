﻿using System;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace LiGet.Tests
{
    //https://stackoverflow.com/questions/46169169/net-core-2-0-configurelogging-xunit-test

    public class XunitLoggerProvider : ILoggerProvider
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public XunitLoggerProvider(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper ?? throw new ArgumentNullException(nameof(testOutputHelper));
        }

        public ILogger CreateLogger(string categoryName)
            => new XunitLogger<object>(_testOutputHelper, categoryName);
        
         public ILogger<T> CreateLogger<T>(string categoryName)
            => new XunitLogger<T>(_testOutputHelper, categoryName);

        public void Dispose()
        { }
    }
}
