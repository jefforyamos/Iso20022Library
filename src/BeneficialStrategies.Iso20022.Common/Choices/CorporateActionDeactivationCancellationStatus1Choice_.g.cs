﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionDeactivationCancellationStatus1Choice.  ISO2002 ID# _RiYWwNp-Ed-ak6NoX_4Aeg_1248187111.
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
    /// Choice between the different statuses of a deactivation cancellation request.
    /// </summary>
    [KnownType(typeof(CorporateActionDeactivationCancellationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionDeactivationCancellationStatus1Choice.RejectedStatus))]
    [IsoId("_RiYWwNp-Ed-ak6NoX_4Aeg_1248187111")]
    [DisplayName("Corporate Action Deactivation Cancellation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionDeactivationCancellationStatus1Choice_
    #else
    public abstract partial class CorporateActionDeactivationCancellationStatus1Choice_
    #endif
    {
    }
}
