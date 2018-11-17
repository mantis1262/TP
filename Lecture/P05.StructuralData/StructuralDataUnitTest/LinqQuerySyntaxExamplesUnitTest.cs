﻿//____________________________________________________________________________
//
//  Copyright (C) 2018, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/TP
//____________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP.StructuralData.LINQQueryAndMethodsSyntax;

namespace TP.StructuralDataUnitTest
{

  [TestClass]
  public class LinqQuerySyntaxExamplesUnitTest
  {

    [TestMethod]
    public void FromClauseExample1Test()
    {
      Assert.AreEqual<string>("grape", LinqQuerySyntaxExamples.QuerySyntax());
      Assert.AreEqual<string>("grape", LinqQuerySyntaxExamples.ForeachExample());
    }
    [TestMethod]
    public void FromClauseExample2Test()
    {
      Assert.AreEqual<string>(string.Empty, LinqQuerySyntaxExamples.QuerySyntaxSideEffect());
    }
    [TestMethod]
    public void FromClauseExample3Test()
    {
      Assert.AreEqual<string>("Name1:11000,00; Name3:130000,00", LinqQuerySyntaxExamples.AnonymousType());
    }

  }
}

