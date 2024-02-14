﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CertificationType1Choice.  ISO2002 ID# _c49DwxdEEeK5g-3oYI0_9Q.
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
    /// Choice of formats for the specification of the certificate type.
    /// </summary>
    [KnownType(typeof(CertificationType1Choice.Code))]
    [KnownType(typeof(CertificationType1Choice.Proprietary))]
    [IsoId("_c49DwxdEEeK5g-3oYI0_9Q")]
    [DisplayName("Certification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CertificationType1Choice_
    #else
    public abstract partial class CertificationType1Choice_
    #endif
    {
    }
}
