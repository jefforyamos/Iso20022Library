﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherAsset.  ISO2002 ID# _qD51dZy1Eem54rMzia0iag.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument62Choice;

/// <summary>
/// Identification of another kind of asset in the holding that is not a security or cash.
/// </summary>
public partial record OtherAsset : IFinancialInstrument62Choice
{
    #nullable enable
    /// <summary>
    /// Type of asset.
    /// </summary>
    public required IOtherAsset2Choice OtherAssetType { get; init; } 
    /// <summary>
    /// Technical identification of the asset.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the asset.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Description of the asset.
    /// </summary>
    public IsoMax35Text? Description { get; init; } 
    /// <summary>
    /// Additional identification of the asset.
    /// </summary>
    // public IReadOnlyCollection<IsoMax35Text> OtherIdentification { get; init; }
    /// <summary>
    /// Additional information about the other asset.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
