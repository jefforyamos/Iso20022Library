﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason13FormatChoice.  ISO2002 ID# _RoMq4tp-Ed-ak6NoX_4Aeg_-549911598.
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
    /// Choice of formats to express the reason of a rejection of a movement.
    /// </summary>
    [KnownType(typeof(RejectionReason13FormatChoice.Code))]
    [KnownType(typeof(RejectionReason13FormatChoice.Proprietary))]
    [IsoId("_RoMq4tp-Ed-ak6NoX_4Aeg_-549911598")]
    [DisplayName("Rejection Reason 13 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason13FormatChoice_
    #else
    public abstract partial class RejectionReason13FormatChoice_
    #endif
    {
    }
}
