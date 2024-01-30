﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionCapabilities7.  ISO2002 ID# _nwovca1yEeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the ATM terminal.
/// </summary>
public partial record PointOfInteractionCapabilities7
{
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the ATM performing the transaction.
    /// </summary>
    public CardDataReading4Code? CardReadData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Card writing capabilities of the terminal performing the transaction.
    /// </summary>
    public CardDataReading4Code? CardWriteData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Customer and card authentication capabilities available at the ATM.
    /// </summary>
    public CardholderVerificationCapability3Code? Authentication { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Maximum number of digits the ATM is able to accept when the cardholder enters its PIN.
    /// </summary>
    public IsoNumber? PINLengthCapabilities { get; init; } 
    /// <summary>
    /// Maximum number of characters of the approval code the ATM is able to manage.
    /// </summary>
    public IsoNumber? ApprovalCodeLength { get; init; } 
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    public IsoNumber? MaxScriptLength { get; init; } 
    /// <summary>
    /// True if the ATM is able to capture card.
    /// </summary>
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    /// <summary>
    /// Type of media the ATM is able to dispense.
    /// </summary>
    public ATMMediaType1Code? WithdrawalMedia { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of media the customer is able to deposit in the ATM.
    /// </summary>
    public ATMMediaType2Code? DepositedMedia { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    public DisplayCapabilities5? MessageCapabilities { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
