﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementStatus1Choice.  ISO2002 ID# _UYUpJ9p-Ed-ak6NoX_4Aeg_-484323016.
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
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus1Choice.Code))]
    [KnownType(typeof(SettlementStatus1Choice.Proprietary))]
    [IsoId("_UYUpJ9p-Ed-ak6NoX_4Aeg_-484323016")]
    [DisplayName("Settlement Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus1Choice_
    #else
    public abstract partial class SettlementStatus1Choice_
    #endif
    {
    }
}
