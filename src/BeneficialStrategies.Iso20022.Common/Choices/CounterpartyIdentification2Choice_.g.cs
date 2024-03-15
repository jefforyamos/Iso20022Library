﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CounterpartyIdentification2Choice.  ISO2002 ID# _QmCKwXvSEeWrWYBng3OpVw.
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
    /// Provides the identification of the reporting agent counterparty.
    /// </summary>
    [KnownType(typeof(CounterpartyIdentification2Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification2Choice.Other))]
    [IsoId("_QmCKwXvSEeWrWYBng3OpVw")]
    [DisplayName("Counterparty Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyIdentification2Choice_
    #else
    public abstract partial class CounterpartyIdentification2Choice_
    #endif
    {
    }
}
