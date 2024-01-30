﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTransactionTransmission2.  ISO2002 ID# _gW374OqLEeSsk6KxwbYJ9w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the securities order transmission attributes.
/// </summary>
public partial record SecuritiesTransactionTransmission2
{
    #nullable enable
    
    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    public required IsoTrueFalseIndicator TransmissionIndicator { get; init; } 
    /// <summary>
    /// Identifies the buyer transmitting the order to the reporting firm. 
    /// Usage: Only required for reporting firms reporting transactions on behalf of order transmitting firm.
    /// </summary>
    public IsoLEIIdentifier? TransmittingBuyer { get; init; } 
    /// <summary>
    /// Identifies the seller transmitting the order to the reporting firm. 
    /// Usage: Only required for reporting firms reporting transactions on behalf of order transmitting firm.
    /// </summary>
    public IsoLEIIdentifier? TransmittingSeller { get; init; } 
    
    #nullable disable
}
