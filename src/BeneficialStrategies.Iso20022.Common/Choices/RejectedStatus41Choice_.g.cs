﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectedStatus41Choice.  ISO2002 ID# _dxaPqxnyEeyroI8qKgB7Mg.
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
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus41Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus41Choice.Reason))]
    [IsoId("_dxaPqxnyEeyroI8qKgB7Mg")]
    [DisplayName("Rejected Status 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus41Choice_
    #else
    public abstract partial class RejectedStatus41Choice_
    #endif
    {
    }
}
