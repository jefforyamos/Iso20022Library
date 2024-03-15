﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PriceValueType5FormatChoice.  ISO2002 ID# _RnAYFtp-Ed-ak6NoX_4Aeg_-475448184.
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
    /// Choice of formats to express the value of a price.
    /// </summary>
    [KnownType(typeof(PriceValueType5FormatChoice.Code))]
    [KnownType(typeof(PriceValueType5FormatChoice.Proprietary))]
    [IsoId("_RnAYFtp-Ed-ak6NoX_4Aeg_-475448184")]
    [DisplayName("Price Value Type 5 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceValueType5FormatChoice_
    #else
    public abstract partial class PriceValueType5FormatChoice_
    #endif
    {
    }
}
