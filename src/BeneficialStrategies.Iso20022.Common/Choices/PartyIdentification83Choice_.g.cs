﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification83Choice.  ISO2002 ID# _H6bfUC6HEeSQQqw1BT_aMg.
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
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification83Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification83Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification83Choice.NameAndAddress))]
    [IsoId("_H6bfUC6HEeSQQqw1BT_aMg")]
    [DisplayName("Party Identification 83 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification83Choice_
    #else
    public abstract partial class PartyIdentification83Choice_
    #endif
    {
    }
}
