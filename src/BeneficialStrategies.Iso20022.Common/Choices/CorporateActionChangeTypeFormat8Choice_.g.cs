﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionChangeTypeFormat8Choice.  ISO2002 ID# _c5V6a5KQEeWHWpTQn1FFVg.
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
    /// Choice between a standard code or proprietary code to specify the change type of a corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionChangeTypeFormat8Choice.Code))]
    [KnownType(typeof(CorporateActionChangeTypeFormat8Choice.Proprietary))]
    [IsoId("_c5V6a5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Change Type Format 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionChangeTypeFormat8Choice_
    #else
    public abstract partial class CorporateActionChangeTypeFormat8Choice_
    #endif
    {
    }
}
