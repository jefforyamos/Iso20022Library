﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralValueReportOrError5Choice.  ISO2002 ID# _95GpHzpvEemk2e6qGBk8IQ.
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
    /// Reports on collateral values or error report in case of business processing of the related request.
    /// </summary>
    [KnownType(typeof(CollateralValueReportOrError5Choice.BusinessReport))]
    [KnownType(typeof(CollateralValueReportOrError5Choice.OperationalError))]
    [IsoId("_95GpHzpvEemk2e6qGBk8IQ")]
    [DisplayName("Collateral Value Report Or Error 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralValueReportOrError5Choice_
    #else
    public abstract partial class CollateralValueReportOrError5Choice_
    #endif
    {
    }
}
