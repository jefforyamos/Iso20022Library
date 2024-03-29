﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reference1Choice.  ISO2002 ID# _QmxqItp-Ed-ak6NoX_4Aeg_261203016.
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
    /// Choice between the identification of the MarginCallRequest message, the MarginCallResponse message, the CollateralProposal message, the CollateralProposalResponse message, the CollateralSubstitutionRequest message or the MarginCallDisputeNotification message.
    /// </summary>
    [KnownType(typeof(Reference1Choice.MarginCallRequestIdentification))]
    [KnownType(typeof(Reference1Choice.MarginCallResponseIdentification))]
    [KnownType(typeof(Reference1Choice.CollateralProposalIdentification))]
    [KnownType(typeof(Reference1Choice.CollateralProposalResponseIdentification))]
    [KnownType(typeof(Reference1Choice.DisputeNotificationIdentification))]
    [KnownType(typeof(Reference1Choice.CollateralSubstitutionRequestIdentification))]
    [IsoId("_QmxqItp-Ed-ak6NoX_4Aeg_261203016")]
    [DisplayName("Reference 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reference1Choice_
    #else
    public abstract partial class Reference1Choice_
    #endif
    {
    }
}
