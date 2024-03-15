﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceRateType3FormatChoice.  ISO2002 ID# _RnAYE9p-Ed-ak6NoX_4Aeg_1859127225.
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
    /// Choice of formats to express the type of price rate.
    /// </summary>
    [KnownType(typeof(PriceRateType3FormatChoice.Code))]
    [KnownType(typeof(PriceRateType3FormatChoice.Proprietary))]
    [IsoId("_RnAYE9p-Ed-ak6NoX_4Aeg_1859127225")]
    [DisplayName("Price Rate Type 3 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateType3FormatChoice_
    #else
    public abstract partial class PriceRateType3FormatChoice_
    #endif
    {
    }
}
