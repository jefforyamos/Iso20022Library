﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentMethod1Choice.  ISO2002 ID# _jFLkUu5NEeCisYr99QEiWA_-1587075302.
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
    /// Method of payment for the remittance of the CSD or the NCB to the invoicing party.
    /// </summary>
    [KnownType(typeof(PaymentMethod1Choice.Code))]
    [KnownType(typeof(PaymentMethod1Choice.Proprietary))]
    [IsoId("_jFLkUu5NEeCisYr99QEiWA_-1587075302")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Method 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentMethod1Choice_
    #else
    public abstract partial class PaymentMethod1Choice_
    #endif
    {
    }
}
