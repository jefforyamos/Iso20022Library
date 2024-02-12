﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrument1Choice.  ISO2002 ID# _pCApoEyGEeir2sRRVd9XhA.
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
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument1Choice.Security))]
    [KnownType(typeof(FinancialInstrument1Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument1Choice.OtherAsset))]
    [IsoId("_pCApoEyGEeir2sRRVd9XhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument1Choice_
    #else
    public abstract partial class FinancialInstrument1Choice_
    #endif
    {
    }
}
