﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ConsentStatus2Choice.  ISO2002 ID# _0jhc8QlIEeGATtfOBToyew_-1079502867.
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
    /// Choice of consent status.
    /// </summary>
    [KnownType(typeof(ConsentStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConsentStatus2Choice.Reason))]
    [IsoId("_0jhc8QlIEeGATtfOBToyew_-1079502867")]
    [DisplayName("Consent Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConsentStatus2Choice_
    #else
    public abstract partial class ConsentStatus2Choice_
    #endif
    {
    }
}
