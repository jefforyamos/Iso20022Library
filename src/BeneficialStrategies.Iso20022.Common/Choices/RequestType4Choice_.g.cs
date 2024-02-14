﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RequestType4Choice.  ISO2002 ID# _ivV-XZIhEeect698_YsnIA.
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
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(RequestType4Choice.PaymentControl))]
    [KnownType(typeof(RequestType4Choice.Enquiry))]
    [KnownType(typeof(RequestType4Choice.Proprietary))]
    [IsoId("_ivV-XZIhEeect698_YsnIA")]
    [DisplayName("Request Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RequestType4Choice_
    #else
    public abstract partial class RequestType4Choice_
    #endif
    {
    }
}
