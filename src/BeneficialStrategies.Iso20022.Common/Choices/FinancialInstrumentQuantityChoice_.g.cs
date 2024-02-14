﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FinancialInstrumentQuantityChoice.  ISO2002 ID# _Sn-F2Np-Ed-ak6NoX_4Aeg_1265174989.
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
    [KnownType(typeof(FinancialInstrumentQuantityChoice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantityChoice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantityChoice.AmortisedValue))]
    [IsoId("_Sn-F2Np-Ed-ak6NoX_4Aeg_1265174989")]
    [DisplayName("Financial Instrument Quantity Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantityChoice_
    #else
    public abstract partial class FinancialInstrumentQuantityChoice_
    #endif
    {
    }
}
