﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionOrRepairStatus4Choice.  ISO2002 ID# _UUmmwtp-Ed-ak6NoX_4Aeg_2139855666.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus4Choice.Reason))]
    [IsoId("_UUmmwtp-Ed-ak6NoX_4Aeg_2139855666")]
    [DisplayName("Rejection Or Repair Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionOrRepairStatus4Choice_
    #else
    public abstract partial class RejectionOrRepairStatus4Choice_
    #endif
    {
    }
}
