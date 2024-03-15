﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyOrCurrency1Choice.  ISO2002 ID# _eY4Ls1K0EeOsJr32EK1NAQ.
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
    /// Choice of a depostory or settlement currency.
    /// </summary>
    [KnownType(typeof(PartyOrCurrency1Choice.Depository))]
    [KnownType(typeof(PartyOrCurrency1Choice.SettlementCurrency))]
    [IsoId("_eY4Ls1K0EeOsJr32EK1NAQ")]
    [DisplayName("Party Or Currency 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyOrCurrency1Choice_
    #else
    public abstract partial class PartyOrCurrency1Choice_
    #endif
    {
    }
}
