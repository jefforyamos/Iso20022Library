﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentificationQuery4Choice.  ISO2002 ID# _PHYIYZNeEeytjZlcgApf6A.
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
    [KnownType(typeof(SecurityIdentificationQuery4Choice.ISIN))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.AlternativeInstrumentIdentification))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.NotAvailable))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.UniqueProductIdentifier))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.Index))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.Basket))]
    [KnownType(typeof(SecurityIdentificationQuery4Choice.NotReported))]
    [IsoId("_PHYIYZNeEeytjZlcgApf6A")]
    [DisplayName("Security Identification Query 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentificationQuery4Choice_
    #else
    public abstract partial class SecurityIdentificationQuery4Choice_
    #endif
    {
    }
}
