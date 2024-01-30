﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BasketQuery1.  ISO2002 ID# _mPKjUJNeEeytjZlcgApf6A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of constituents for a basket of indexes.
/// </summary>
public partial record BasketQuery1
{
    #nullable enable
    
    /// <summary>
    /// Legal entity identifier code used to recognise the counterparty of the reporting agent for the reported transaction.
    /// </summary>
    public IsoLEIIdentifier? Structurer { get; init; } 
    /// <summary>
    /// Identifier of the custom basket assigned by the structurer allowing to link the constituents of the basket of indexes.
    /// </summary>
    public IsoMax52Text? Identifier { get; init; } 
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    
    #nullable disable
}
