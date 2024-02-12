﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for KYCCheckType1Choice.  ISO2002 ID# _HadL0RRxEeOKWo1NF21OVw.
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
    /// Choice of formats for the specification of the Know Your Customer (KYC) check type.
    /// </summary>
    [KnownType(typeof(KYCCheckType1Choice.Code))]
    [KnownType(typeof(KYCCheckType1Choice.Proprietary))]
    [IsoId("_HadL0RRxEeOKWo1NF21OVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("KYC Check Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record KYCCheckType1Choice_
    #else
    public abstract partial class KYCCheckType1Choice_
    #endif
    {
    }
}
