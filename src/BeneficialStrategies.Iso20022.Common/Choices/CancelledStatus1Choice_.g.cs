﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledStatus1Choice.  ISO2002 ID# _Qy2XRtp-Ed-ak6NoX_4Aeg_-1326182926.
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
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus1Choice.Reason))]
    [IsoId("_Qy2XRtp-Ed-ak6NoX_4Aeg_-1326182926")]
    [DisplayName("Cancelled Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledStatus1Choice_
    #else
    public abstract partial class CancelledStatus1Choice_
    #endif
    {
    }
}
