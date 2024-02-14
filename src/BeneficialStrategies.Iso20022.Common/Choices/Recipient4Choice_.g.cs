﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Recipient4Choice.  ISO2002 ID# _NoPZUWi0EeS87LmvcA55sg.
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
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient4Choice.KeyTransport))]
    [KnownType(typeof(Recipient4Choice.KEK))]
    [KnownType(typeof(Recipient4Choice.KeyIdentifier))]
    [IsoId("_NoPZUWi0EeS87LmvcA55sg")]
    [DisplayName("Recipient 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Recipient4Choice_
    #else
    public abstract partial class Recipient4Choice_
    #endif
    {
    }
}
