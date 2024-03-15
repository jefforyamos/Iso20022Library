﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransferCancellationRejectedStatus1Choice.  ISO2002 ID# _U0fAstp-Ed-ak6NoX_4Aeg_330240032.
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
    /// Reason for the rejected status.
    /// </summary>
    [KnownType(typeof(TransferCancellationRejectedStatus1Choice.Reason))]
    [KnownType(typeof(TransferCancellationRejectedStatus1Choice.DataSourceScheme))]
    [IsoId("_U0fAstp-Ed-ak6NoX_4Aeg_330240032")]
    [DisplayName("Transfer Cancellation Rejected Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransferCancellationRejectedStatus1Choice_
    #else
    public abstract partial class TransferCancellationRejectedStatus1Choice_
    #endif
    {
    }
}
