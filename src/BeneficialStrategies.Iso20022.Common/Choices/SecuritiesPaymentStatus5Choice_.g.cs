﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesPaymentStatus5Choice.  ISO2002 ID# _cBDuUTnAEeWV5sr121Fc8A.
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
    /// Choice of format for the status of payment of a security at a particular time.
    /// </summary>
    [KnownType(typeof(SecuritiesPaymentStatus5Choice.Code))]
    [KnownType(typeof(SecuritiesPaymentStatus5Choice.Proprietary))]
    [IsoId("_cBDuUTnAEeWV5sr121Fc8A")]
    [DisplayName("Securities Payment Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesPaymentStatus5Choice_
    #else
    public abstract partial class SecuritiesPaymentStatus5Choice_
    #endif
    {
    }
}
