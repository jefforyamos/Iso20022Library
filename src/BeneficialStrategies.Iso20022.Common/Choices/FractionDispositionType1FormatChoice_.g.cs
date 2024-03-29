﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FractionDispositionType1FormatChoice.  ISO2002 ID# _RmjsJdp-Ed-ak6NoX_4Aeg_-689292712.
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
    /// Choice of formats to express how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [KnownType(typeof(FractionDispositionType1FormatChoice.Code))]
    [KnownType(typeof(FractionDispositionType1FormatChoice.Proprietary))]
    [IsoId("_RmjsJdp-Ed-ak6NoX_4Aeg_-689292712")]
    [DisplayName("Fraction Disposition Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType1FormatChoice_
    #else
    public abstract partial class FractionDispositionType1FormatChoice_
    #endif
    {
    }
}
