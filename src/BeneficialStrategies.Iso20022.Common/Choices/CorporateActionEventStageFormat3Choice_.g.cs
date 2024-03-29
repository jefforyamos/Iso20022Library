﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionEventStageFormat3Choice.  ISO2002 ID# _Dw-HQeHPEd-1Ktb5rVaajw.
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
    /// Choice between a standard code or proprietary code to specify the event stage type.
    /// </summary>
    [KnownType(typeof(CorporateActionEventStageFormat3Choice.Code))]
    [KnownType(typeof(CorporateActionEventStageFormat3Choice.Proprietary))]
    [IsoId("_Dw-HQeHPEd-1Ktb5rVaajw")]
    [DisplayName("Corporate Action Event Stage Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionEventStageFormat3Choice_
    #else
    public abstract partial class CorporateActionEventStageFormat3Choice_
    #endif
    {
    }
}
