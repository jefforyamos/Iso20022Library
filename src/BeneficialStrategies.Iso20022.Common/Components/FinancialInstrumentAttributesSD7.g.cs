﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributesSD7.  ISO2002 ID# _1esTQDL3EeKU9IrkkToqcw_-24344462.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[DataContract]
[XmlType]
public partial record FinancialInstrumentAttributesSD7
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [DataMember]
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Name of the issuer.
    /// </summary>
    [DataMember]
    public IsoMax70Text? IssuerDescription { get; init; } 
    /// <summary>
    /// Country of incorporation of the issuer.
    /// </summary>
    [DataMember]
    public CountryCode? CountryOfIncorporation { get; init; } 
    /// <summary>
    /// Indicates if the stock exchange associated to place of listing code is primary.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? PrimaryExchangeFlag { get; init; } 
    /// <summary>
    /// Indicates whether the event has been registered with US Securities Exchange Commission (SEC).
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? SECRegisteredFlag { get; init; } 
    
    #nullable disable
}
