﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditLine3.  ISO2002 ID# _oZe7n4Z5Eee8r9VKRbnJSg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the credit line.
/// </summary>
public partial record CreditLine3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the credit line is included in the balance.
    /// </summary>
    public required IsoTrueFalseIndicator Included { get; init; } 
    /// <summary>
    /// Type of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    public CreditLineType1Choice_? Type { get; init; } 
    /// <summary>
    /// Amount of money of the credit line.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Date of the credit line provided when multiple credit lines may be provided.
    /// </summary>
    public DateAndDateTime2Choice_? Date { get; init; } 
    
    #nullable disable
}
