﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification29Choice.  ISO2002 ID# _QFGgcNp-Ed-ak6NoX_4Aeg_-162334661.
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
    /// Identification of a party by BIC or by name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification29Choice.BIC))]
    [KnownType(typeof(PartyIdentification29Choice.NameAndAddress))]
    [IsoId("_QFGgcNp-Ed-ak6NoX_4Aeg_-162334661")]
    [DisplayName("Party Identification 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification29Choice_
    #else
    public abstract partial class PartyIdentification29Choice_
    #endif
    {
    }
}
