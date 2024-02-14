﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification243Choice.  ISO2002 ID# _vOLN0QauEe2phaVG0lYKTw.
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
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification243Choice.BIC))]
    [KnownType(typeof(PartyIdentification243Choice.ProprietaryIdentification))]
    [IsoId("_vOLN0QauEe2phaVG0lYKTw")]
    [DisplayName("Party Identification 243 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification243Choice_
    #else
    public abstract partial class PartyIdentification243Choice_
    #endif
    {
    }
}
