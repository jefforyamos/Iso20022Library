﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GDPRDataConsent1Choice.  ISO2002 ID# _His4MJTTEemC09f0MxYkRg.
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
    /// Choice of formats for the type of consent.
    /// </summary>
    [KnownType(typeof(GDPRDataConsent1Choice.Code))]
    [KnownType(typeof(GDPRDataConsent1Choice.Proprietary))]
    [IsoId("_His4MJTTEemC09f0MxYkRg")]
    [DisplayName("GDPR Data Consent 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GDPRDataConsent1Choice_
    #else
    public abstract partial class GDPRDataConsent1Choice_
    #endif
    {
    }
}
