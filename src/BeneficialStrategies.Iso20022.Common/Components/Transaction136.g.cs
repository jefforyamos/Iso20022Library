﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction136.  ISO2002 ID# _fmsTgYv_EeuC5632vxUfGg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
public partial record Transaction136
{
    #nullable enable
    
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    public ISO8583MessageReasonCode? MessageReason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Supports message reason codes that are not defined in external code list. 
    /// </summary>
    public IsoMax256Text? AlternateMessageReason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification18 TransactionIdentification { get; init; } 
    /// <summary>
    /// Data related to the dispute.
    /// </summary>
    public DisputeData3? DisputeData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Fulfilment request instructions for the retrieval.
    /// </summary>
    public RetrievalFulfilmentInstructions2? RetrievalFulfilmentInstructions { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    public AdditionalFee2? AdditionalFee { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
