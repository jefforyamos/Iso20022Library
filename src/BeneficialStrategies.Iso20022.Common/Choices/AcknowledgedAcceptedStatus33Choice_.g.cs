﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgedAcceptedStatus33Choice.  ISO2002 ID# _HqnHhZwZEeqtp-LOti013g.
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
    [KnownType(typeof(AcknowledgedAcceptedStatus33Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus33Choice.Reason))]
    [IsoId("_HqnHhZwZEeqtp-LOti013g")]
    [DisplayName("Acknowledged Accepted Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgedAcceptedStatus33Choice_
    #else
    public abstract partial class AcknowledgedAcceptedStatus33Choice_
    #endif
    {
    }
}
