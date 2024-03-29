﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason18FormatChoice.  ISO2002 ID# _RoV009p-Ed-ak6NoX_4Aeg_-1965302584.
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
    /// Choice of formats to express the reason of a rejection of an election advice.
    /// </summary>
    [KnownType(typeof(RejectionReason18FormatChoice.Code))]
    [KnownType(typeof(RejectionReason18FormatChoice.Proprietary))]
    [IsoId("_RoV009p-Ed-ak6NoX_4Aeg_-1965302584")]
    [DisplayName("Rejection Reason 18 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason18FormatChoice_
    #else
    public abstract partial class RejectionReason18FormatChoice_
    #endif
    {
    }
}
