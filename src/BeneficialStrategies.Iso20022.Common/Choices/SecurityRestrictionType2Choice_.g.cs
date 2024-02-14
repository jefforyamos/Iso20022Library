﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityRestrictionType2Choice.  ISO2002 ID# _c8LMVeLxEeWOD7aAy2fAcA.
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
    /// Choice between the type of restriction.
    /// </summary>
    [KnownType(typeof(SecurityRestrictionType2Choice.RestrictionType))]
    [KnownType(typeof(SecurityRestrictionType2Choice.ProprietaryRestriction))]
    [IsoId("_c8LMVeLxEeWOD7aAy2fAcA")]
    [DisplayName("Security Restriction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityRestrictionType2Choice_
    #else
    public abstract partial class SecurityRestrictionType2Choice_
    #endif
    {
    }
}
