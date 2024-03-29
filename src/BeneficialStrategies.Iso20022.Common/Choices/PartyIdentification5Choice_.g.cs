﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification5Choice.  ISO2002 ID# _QRLNltp-Ed-ak6NoX_4Aeg_2069121051.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    [KnownType(typeof(PartyIdentification5Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification5Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification5Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification5Choice.TaxIdentificationNumber))]
    [KnownType(typeof(PartyIdentification5Choice.NationalRegistrationNumber))]
    [IsoId("_QRLNltp-Ed-ak6NoX_4Aeg_2069121051")]
    [DisplayName("Party Identification 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification5Choice_
    #else
    public abstract partial class PartyIdentification5Choice_
    #endif
    {
    }
}
