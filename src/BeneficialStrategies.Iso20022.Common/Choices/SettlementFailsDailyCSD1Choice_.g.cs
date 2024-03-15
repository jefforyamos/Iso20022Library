﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementFailsDailyCSD1Choice.  ISO2002 ID# _OxcU0zOaEeqBfed1bmSPqg.
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
    /// Specifies the details on the settlement fails split per intra-CSD and cross-CSD instructions or explicit no data report.
    /// </summary>
    [KnownType(typeof(SettlementFailsDailyCSD1Choice.DataSetAction))]
    [KnownType(typeof(SettlementFailsDailyCSD1Choice.Data))]
    [IsoId("_OxcU0zOaEeqBfed1bmSPqg")]
    [DisplayName("Settlement Fails Daily CSD 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementFailsDailyCSD1Choice_
    #else
    public abstract partial class SettlementFailsDailyCSD1Choice_
    #endif
    {
    }
}
