﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PaymentRole1Choice.  ISO2002 ID# _b_Ox03hiEeidzqjNEfehPg.
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
    /// Specifies the role associated with a specific party in relation to a payment instruction.
    /// </summary>
    [KnownType(typeof(PaymentRole1Choice.Code))]
    [KnownType(typeof(PaymentRole1Choice.Proprietary))]
    [IsoId("_b_Ox03hiEeidzqjNEfehPg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Role 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentRole1Choice_
    #else
    public abstract partial class PaymentRole1Choice_
    #endif
    {
    }
}
