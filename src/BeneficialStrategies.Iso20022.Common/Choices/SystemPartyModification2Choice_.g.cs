﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SystemPartyModification2Choice.  ISO2002 ID# _x87oIYv-Eei289CGNqs21g.
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
    /// Identifies which information are involved by a modification request for party reference data.
    /// </summary>
    [KnownType(typeof(SystemPartyModification2Choice.SystemPartyDate))]
    [KnownType(typeof(SystemPartyModification2Choice.PartyIdentification))]
    [KnownType(typeof(SystemPartyModification2Choice.PartyName))]
    [KnownType(typeof(SystemPartyModification2Choice.ContactDetails))]
    [KnownType(typeof(SystemPartyModification2Choice.TechnicalAddress))]
    [KnownType(typeof(SystemPartyModification2Choice.PartyAddress))]
    [KnownType(typeof(SystemPartyModification2Choice.ResidenceType))]
    [KnownType(typeof(SystemPartyModification2Choice.LockStatus))]
    [KnownType(typeof(SystemPartyModification2Choice.SystemRestriction))]
    [KnownType(typeof(SystemPartyModification2Choice.MarketSpecificAttribute))]
    [IsoId("_x87oIYv-Eei289CGNqs21g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("System Party Modification 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemPartyModification2Choice_
    #else
    public abstract partial class SystemPartyModification2Choice_
    #endif
    {
    }
}
