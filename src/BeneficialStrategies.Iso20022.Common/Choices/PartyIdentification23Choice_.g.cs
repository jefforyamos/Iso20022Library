﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification23Choice.  ISO2002 ID# _QReIgdp-Ed-ak6NoX_4Aeg_-1086683076.
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
    [KnownType(typeof(PartyIdentification23Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification23Choice.ProprietaryIdentification))]
    [IsoId("_QReIgdp-Ed-ak6NoX_4Aeg_-1086683076")]
    [DisplayName("Party Identification 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyIdentification23Choice_
    #else
    public abstract partial class PartyIdentification23Choice_
    #endif
    {
    }
}
