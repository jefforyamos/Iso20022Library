﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for MandateSuspensionReason1Choice.  ISO2002 ID# _gW_7w4PDEeahmOIR_zFG6A.
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
    /// Specifies the reason for the suspension request of a mandate.
    /// </summary>
    [KnownType(typeof(MandateSuspensionReason1Choice.Code))]
    [KnownType(typeof(MandateSuspensionReason1Choice.Proprietary))]
    [IsoId("_gW_7w4PDEeahmOIR_zFG6A")]
    [DisplayName("Mandate Suspension Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MandateSuspensionReason1Choice_
    #else
    public abstract partial class MandateSuspensionReason1Choice_
    #endif
    {
    }
}
