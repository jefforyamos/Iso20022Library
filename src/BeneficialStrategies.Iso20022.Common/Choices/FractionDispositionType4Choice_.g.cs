﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FractionDispositionType4Choice.  ISO2002 ID# _Q08B8Np-Ed-ak6NoX_4Aeg_-1812394474.
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
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType4Choice.Code))]
    [KnownType(typeof(FractionDispositionType4Choice.Proprietary))]
    [IsoId("_Q08B8Np-Ed-ak6NoX_4Aeg_-1812394474")]
    [DisplayName("Fraction Disposition Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FractionDispositionType4Choice_
    #else
    public abstract partial class FractionDispositionType4Choice_
    #endif
    {
    }
}
