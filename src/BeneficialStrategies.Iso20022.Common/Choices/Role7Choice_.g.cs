﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Role7Choice.  ISO2002 ID# _5WyhAZNLEeWGlc8L7oPDIg.
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
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role7Choice.Code))]
    [KnownType(typeof(Role7Choice.Proprietary))]
    [KnownType(typeof(Role7Choice.Text))]
    [IsoId("_5WyhAZNLEeWGlc8L7oPDIg")]
    [DisplayName("Role 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Role7Choice_
    #else
    public abstract partial class Role7Choice_
    #endif
    {
    }
}
