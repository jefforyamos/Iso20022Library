﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CounterpartyIdentification1Choice.  ISO2002 ID# _wlfJ0JfcEeSfnc-VXAEapg.
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
    [KnownType(typeof(CounterpartyIdentification1Choice.LEI))]
    [KnownType(typeof(CounterpartyIdentification1Choice.Other))]
    [IsoId("_wlfJ0JfcEeSfnc-VXAEapg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Counterparty Identification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CounterpartyIdentification1Choice_
    #else
    public abstract partial class CounterpartyIdentification1Choice_
    #endif
    {
    }
}
