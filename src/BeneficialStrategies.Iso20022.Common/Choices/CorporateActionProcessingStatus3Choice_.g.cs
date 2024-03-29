﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionProcessingStatus3Choice.  ISO2002 ID# _PL-N8QuIEeGnWuuxuI2McQ.
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
    /// Specifies the status of the details of the corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionProcessingStatus3Choice.Code))]
    [KnownType(typeof(CorporateActionProcessingStatus3Choice.Proprietary))]
    [IsoId("_PL-N8QuIEeGnWuuxuI2McQ")]
    [DisplayName("Corporate Action Processing Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionProcessingStatus3Choice_
    #else
    public abstract partial class CorporateActionProcessingStatus3Choice_
    #endif
    {
    }
}
