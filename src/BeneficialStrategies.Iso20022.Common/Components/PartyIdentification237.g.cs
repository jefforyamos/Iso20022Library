﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification237.  ISO2002 ID# _NbXONfNyEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification237
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public required NameAndAddress17 NameAndAddress { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification198Choice Identification { get; init; } 
    /// <summary>
    /// Country in which the company is incorporated or legally registered. 
    /// </summary>
    public CountryCode? CountryOfIncorporation { get; init; } 
    /// <summary>
    /// Year during which the legal entity was officially incorporated.
    /// </summary>
    public IsoISOYear? YearOfIncorporation { get; init; } 
    /// <summary>
    /// Economical activity of the  investor.
    /// </summary>
    public IsoISICIdentifier? ActivityIndicator { get; init; } 
    /// <summary>
    /// Type of investor.
    /// </summary>
    public IInvestorType1Choice? InvestorType { get; init; } 
    /// <summary>
    /// Information about the ownership on an asset.
    /// </summary>
    public Ownership1? Ownership { get; init; } 
    
    #nullable disable
}
