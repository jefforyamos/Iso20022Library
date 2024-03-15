﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PortfolioCode1Choice.  ISO2002 ID# _FQG3gHixEeqKjIYaFgh_2g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a known portfolio code and a code applicable when the code is unknown.
    /// </summary>
    [KnownType(typeof(PortfolioCode1Choice.Portfolio))]
    [KnownType(typeof(PortfolioCode1Choice.NoCode))]
    [IsoId("_FQG3gHixEeqKjIYaFgh_2g")]
    [DisplayName("Portfolio Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PortfolioCode1Choice_
    #else
    public abstract partial class PortfolioCode1Choice_
    #endif
    {
    }
}
