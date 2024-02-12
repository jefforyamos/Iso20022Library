﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NettingIdentification2Choice.  ISO2002 ID# _CEeXwQN1Ee2-vqzwMUAewg.
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
    /// Choice between a netting group identification or an individual trading party.
    /// </summary>
    [KnownType(typeof(NettingIdentification2Choice.TradeParty))]
    [KnownType(typeof(NettingIdentification2Choice.NettingGroupIdentification))]
    [IsoId("_CEeXwQN1Ee2-vqzwMUAewg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Netting Identification 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NettingIdentification2Choice_
    #else
    public abstract partial class NettingIdentification2Choice_
    #endif
    {
    }
}
