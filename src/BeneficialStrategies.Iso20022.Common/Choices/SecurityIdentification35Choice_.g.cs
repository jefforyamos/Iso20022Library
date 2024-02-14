﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecurityIdentification35Choice.  ISO2002 ID# _Zlr-rQ1HEeqV4s5SpzR1dQ.
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
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification35Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification35Choice.Name))]
    [KnownType(typeof(SecurityIdentification35Choice.Index))]
    [IsoId("_Zlr-rQ1HEeqV4s5SpzR1dQ")]
    [DisplayName("Security Identification 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecurityIdentification35Choice_
    #else
    public abstract partial class SecurityIdentification35Choice_
    #endif
    {
    }
}
