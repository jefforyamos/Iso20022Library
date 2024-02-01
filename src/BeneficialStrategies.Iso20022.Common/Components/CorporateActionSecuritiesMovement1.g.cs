﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSecuritiesMovement1.  ISO2002 ID# _UIYIptp-Ed-ak6NoX_4Aeg_1464286927.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the securities movements.
/// </summary>
public partial record CorporateActionSecuritiesMovement1
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the posting.
    /// </summary>
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    /// <summary>
    /// Quantity of securities that is posted.
    /// </summary>
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    public SecuritiesAccount8[] AccountDetails { get; init; } = [];
    
    #nullable disable
}
