﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingCancellationReason1Choice.  ISO2002 ID# _Qx8_Ydp-Ed-ak6NoX_4Aeg_21307425.
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
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason1Choice.Code))]
    [KnownType(typeof(PendingCancellationReason1Choice.Proprietary))]
    [IsoId("_Qx8_Ydp-Ed-ak6NoX_4Aeg_21307425")]
    [DisplayName("Pending Cancellation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingCancellationReason1Choice_
    #else
    public abstract partial class PendingCancellationReason1Choice_
    #endif
    {
    }
}
