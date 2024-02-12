﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantity19Choice.  ISO2002 ID# _dPPy8fmWEeCcAY_zfcalaA.
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
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.Code))]
    [IsoId("_dPPy8fmWEeCcAY_zfcalaA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Quantity 19 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity19Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity19Choice_
    #endif
    {
    }
}
