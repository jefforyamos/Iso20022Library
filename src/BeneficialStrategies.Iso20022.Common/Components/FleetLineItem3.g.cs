﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FleetLineItem3.  ISO2002 ID# _Tw694R1TEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record FleetLineItem3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the requested product or service is allowed.
    /// True = Allowed
    /// False = Not allowed
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? AllowedItemIndicator { get; init; } 
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator FuelIndicator { get; init; } 
    /// <summary>
    /// Type of service received at the acceptor location. 
    /// </summary>
    [DataMember]
    public FleetServiceType1Code? ServiceType { get; init; } 
    /// <summary>
    /// Contains a code that identifies a category of fleet products or services. 
    /// </summary>
    [DataMember]
    public IsoMax35Text? FleetProductCategory { get; init; } 
    /// <summary>
    /// Code that identifies the type of fuel or non-fuel product or service being purchased. 
    /// </summary>
    [DataMember]
    public IsoMax15Text? FleetProductCode { get; init; } 
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [DataMember]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [DataMember]
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [DataMember]
    public IsoImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    
    #nullable disable
}
