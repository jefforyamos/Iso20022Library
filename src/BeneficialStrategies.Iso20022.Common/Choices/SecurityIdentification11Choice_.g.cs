﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification11Choice.  ISO2002 ID# _RCMa0dp-Ed-ak6NoX_4Aeg_191397587.
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
    /// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification11Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification11Choice.OtherIdentification))]
    [IsoId("_RCMa0dp-Ed-ak6NoX_4Aeg_191397587")]
    [DisplayName("Security Identification 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification11Choice_
    #else
    public abstract partial class SecurityIdentification11Choice_
    #endif
    {
    }
}
