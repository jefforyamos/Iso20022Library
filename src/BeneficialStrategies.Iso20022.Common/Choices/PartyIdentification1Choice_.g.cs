﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification1Choice.  ISO2002 ID# _QQR1v9p-Ed-ak6NoX_4Aeg_-1748201287.
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
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification1Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification1Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification1Choice.NameAndAddress))]
    [IsoId("_QQR1v9p-Ed-ak6NoX_4Aeg_-1748201287")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification1Choice_
    #else
    public abstract partial class PartyIdentification1Choice_
    #endif
    {
    }
}
