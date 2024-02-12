﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AddressType1Choice.  ISO2002 ID# _B0HaACCKEeWJd9HF2tO7BA.
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
    /// Choice of formats for the type of address.
    /// </summary>
    [KnownType(typeof(AddressType1Choice.Code))]
    [KnownType(typeof(AddressType1Choice.Proprietary))]
    [IsoId("_B0HaACCKEeWJd9HF2tO7BA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Address Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AddressType1Choice_
    #else
    public abstract partial class AddressType1Choice_
    #endif
    {
    }
}
