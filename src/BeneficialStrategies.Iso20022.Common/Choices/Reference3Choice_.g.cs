﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reference3Choice.  ISO2002 ID# _d0qV3ALyEeutW5-TpeYJhA.
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
    /// Identification of the message to be cancelled.
    /// </summary>
    [KnownType(typeof(Reference3Choice.ClientCollateralInstructionIdentification))]
    [KnownType(typeof(Reference3Choice.ClientCollateralTransactionIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralProposalIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralProposalResponseIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralSubstitutionConfirmationIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralSubstitutionRequestIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralSubstitutionResponseIdentification))]
    [KnownType(typeof(Reference3Choice.CommonTransactionIdentification))]
    [KnownType(typeof(Reference3Choice.DisputeNotificationIdentification))]
    [KnownType(typeof(Reference3Choice.InterestPaymentRequestIdentification))]
    [KnownType(typeof(Reference3Choice.InterestPaymentResponseIdentification))]
    [KnownType(typeof(Reference3Choice.InterestPaymentStatementIdentification))]
    [KnownType(typeof(Reference3Choice.MarginCallRequestIdentification))]
    [KnownType(typeof(Reference3Choice.MarginCallResponseIdentification))]
    [KnownType(typeof(Reference3Choice.TripartyAgentServiceProviderCollateralInstructionIdentification))]
    [KnownType(typeof(Reference3Choice.TripartyAgentServiceProviderCollateralTransactionIdentification))]
    [IsoId("_d0qV3ALyEeutW5-TpeYJhA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reference 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reference3Choice_
    #else
    public abstract partial class Reference3Choice_
    #endif
    {
    }
}
