﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KarmaTestAdapterTests.TestResults.SuiteResultTests
{
    partial class TestResults
    {
        partial class SuiteResult
        {
            partial class Empty
            {
                [Fact(DisplayName = "DisplayName should be null")]
                public void DisplayNameShouldBeNull()
                {
                    Assert.Null(Item.DisplayName);
                }
            }

            [Fact(DisplayName = "DisplayName should not be null")]
            public void DisplayNameShouldNotBeNull()
            {
                Assert.NotNull(Item.DisplayName);
            }

            [Fact(DisplayName = "DisplayName should be correct")]
            public void DisplayNameShouldBeCorrect()
            {
                Assert.Equal("Simple tests 2 Nested tests", Item.DisplayName);
            }
        }
    }
}
