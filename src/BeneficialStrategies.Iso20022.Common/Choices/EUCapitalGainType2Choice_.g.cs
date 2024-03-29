﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EUCapitalGainType2Choice.  ISO2002 ID# _f57zwNoqEeCWg-hsBVGrDA_-1171256508.
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
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType2Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType2Choice.Proprietary))]
    [IsoId("_f57zwNoqEeCWg-hsBVGrDA_-1171256508")]
    [DisplayName("EU Capital Gain Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUCapitalGainType2Choice_
    #else
    public abstract partial class EUCapitalGainType2Choice_
    #endif
    {
    }
}
