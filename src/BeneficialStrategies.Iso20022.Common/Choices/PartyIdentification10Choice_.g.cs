﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification10Choice.  ISO2002 ID# _QQR1tdp-Ed-ak6NoX_4Aeg_-1244141483.
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
    [KnownType(typeof(PartyIdentification10Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification10Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification10Choice.NameAndAddress))]
    [IsoId("_QQR1tdp-Ed-ak6NoX_4Aeg_-1244141483")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 10 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification10Choice_
    #else
    public abstract partial class PartyIdentification10Choice_
    #endif
    {
    }
}
