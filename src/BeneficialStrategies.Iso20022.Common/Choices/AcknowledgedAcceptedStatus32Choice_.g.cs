﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgedAcceptedStatus32Choice.  ISO2002 ID# _K3A-kekHEemm4qhb2yFPOw.
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
    [KnownType(typeof(AcknowledgedAcceptedStatus32Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus32Choice.Reason))]
    [IsoId("_K3A-kekHEemm4qhb2yFPOw")]
    [DisplayName("Acknowledged Accepted Status 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgedAcceptedStatus32Choice_
    #else
    public abstract partial class AcknowledgedAcceptedStatus32Choice_
    #endif
    {
    }
}
