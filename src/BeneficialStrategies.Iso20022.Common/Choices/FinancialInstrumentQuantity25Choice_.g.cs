﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity25Choice.  ISO2002 ID# _AOzcUYIiEeW_KPkCyw2GUA.
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
    /// Defines the format for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity25Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity25Choice.NominalValue))]
    [KnownType(typeof(FinancialInstrumentQuantity25Choice.MonetaryValue))]
    [IsoId("_AOzcUYIiEeW_KPkCyw2GUA")]
    [DisplayName("Financial Instrument Quantity 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity25Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity25Choice_
    #endif
    {
    }
}
