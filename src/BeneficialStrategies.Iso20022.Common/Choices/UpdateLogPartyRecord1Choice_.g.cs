﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UpdateLogPartyRecord1Choice.  ISO2002 ID# _xPtUfWjNEeiRg5NzP0jkQg.
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
    /// Specifies the details related to an update of an individual record in the static data of a party.
    /// </summary>
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Address))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.ContactDetails))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.OpeningDate))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.ClosingDate))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Type))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.TechnicalAddress))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.MarketSpecificAttribute))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Name))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.ResidenceType))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.LockStatus))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Restriction))]
    [KnownType(typeof(UpdateLogPartyRecord1Choice.Other))]
    [IsoId("_xPtUfWjNEeiRg5NzP0jkQg")]
    [DisplayName("Update Log Party Record 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateLogPartyRecord1Choice_
    #else
    public abstract partial class UpdateLogPartyRecord1Choice_
    #endif
    {
    }
}
