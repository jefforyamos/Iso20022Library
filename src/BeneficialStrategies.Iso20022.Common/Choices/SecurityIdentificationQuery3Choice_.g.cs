﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentificationQuery3Choice.  ISO2002 ID# _P1cwcdGgEeaQk737TH1Fzw.
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
    /// Query based on various identification of the security.
    /// </summary>
    [KnownType(typeof(SecurityIdentificationQuery3Choice.ISIN))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.NotAvailable))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.Index))]
    [KnownType(typeof(SecurityIdentificationQuery3Choice.NotReported))]
    [IsoId("_P1cwcdGgEeaQk737TH1Fzw")]
    [DisplayName("Security Identification Query 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentificationQuery3Choice_
    #else
    public abstract partial class SecurityIdentificationQuery3Choice_
    #endif
    {
    }
}
