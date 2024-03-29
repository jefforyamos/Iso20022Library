﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CorporateActionMovementStatus1Choice.  ISO2002 ID# _RiPM1dp-Ed-ak6NoX_4Aeg_-2034263409.
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
    /// Choice between the different statuses of a movement.
    /// </summary>
    [KnownType(typeof(CorporateActionMovementStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionMovementStatus1Choice.FailedStatus))]
    [KnownType(typeof(CorporateActionMovementStatus1Choice.RejectedStatus))]
    [IsoId("_RiPM1dp-Ed-ak6NoX_4Aeg_-2034263409")]
    [DisplayName("Corporate Action Movement Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionMovementStatus1Choice_
    #else
    public abstract partial class CorporateActionMovementStatus1Choice_
    #endif
    {
    }
}
