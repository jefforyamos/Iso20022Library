﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdatedAdditionalInformation6SD3.  ISO2002 ID# _FWA4v2CUEeK8P92abE6HIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for additional information.
/// </summary>
public partial record UpdatedAdditionalInformation6SD3
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Specifies the securities account to be credited.
    /// 会社法制の見直し要綱の、22ページ第３－１－①をご参照ください。.
    /// </summary>
    public IsoMax50Text? SecuritiesCreditAccountIdentification { get; init; } 
    /// <summary>
    /// ISIN of Offeror's share when the corporate action event type code is TEND.
    /// </summary>
    public IsoISINIdentifier? OfferorShare { get; init; } 
    /// <summary>
    /// Local code of Offeror's share when the corporate action event type code is TEND.
    /// 買付者 銘柄コード.
    /// </summary>
    public IsoMax5AlphaNumericText? OfferorShareLocalCode { get; init; } 
    /// <summary>
    /// Name in the local language by which a party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax240Text? LocalLanguageName { get; init; } 
    
    #nullable disable
}
