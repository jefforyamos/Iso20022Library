﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModificationStatusReason1Choice.  ISO2002 ID# _L89WiYlsEeePr-EGJjGYzQ.
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
    /// Specifies the reason for the transaction modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatusReason1Choice.Code))]
    [KnownType(typeof(ModificationStatusReason1Choice.Proprietary))]
    [IsoId("_L89WiYlsEeePr-EGJjGYzQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modification Status Reason 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationStatusReason1Choice_
    #else
    public abstract partial class ModificationStatusReason1Choice_
    #endif
    {
    }
}
