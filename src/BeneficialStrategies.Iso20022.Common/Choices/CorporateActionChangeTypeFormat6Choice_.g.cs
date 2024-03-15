﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionChangeTypeFormat6Choice.  ISO2002 ID# _4pLWIUGTEeWqy4niLuXETA.
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
    /// Choice between a standard code or a proprietary code to specify a type of change.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat6Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat6Choice.Proprietary))]
    [IsoId("_4pLWIUGTEeWqy4niLuXETA")]
    [DisplayName("Corporate Action Change Type Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionChangeTypeFormat6Choice_
    #else
    public abstract partial class CorporateActionChangeTypeFormat6Choice_
    #endif
    {
    }
}
