﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralisationType3Code.  ISO2002 ID# _rqcukF51Ee2a_-MvhEjKmA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral agreement between two parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rqcukF51Ee2a_-MvhEjKmA")]
[Description(@"Specifies the type of collateral agreement between two parties.")]
[DerivedFrom(typeof(CollateralisationTypeCode))]
public enum CollateralisationType3Code
{
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "FLCL".
    /// </summary>
    [EnumMember(Value = "FLCL")]
    [IsoId("_vOs4cV51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction.")]
    FullyCollateralised = CollateralisationTypeCode.FullyCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that one counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "OWCL".
    /// </summary>
    [EnumMember(Value = "OWCL")]
    [IsoId("_vTza4V51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that one counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.")]
    OneWayCollateralised = CollateralisationTypeCode.OneWayCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "OWC1".
    /// </summary>
    [EnumMember(Value = "OWC1")]
    [IsoId("_vX_-YV51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.")]
    OneWayCollateralisedCounterparty1 = CollateralisationTypeCode.OneWayCollateralisedCounterparty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "OWC2".
    /// </summary>
    [EnumMember(Value = "OWC2")]
    [IsoId("_vck8YV51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.")]
    OneWayCollateralisedCounterparty2 = CollateralisationTypeCode.OneWayCollateralisedCounterparty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty regularly posts only variation margin. 
    /// Encoded/decoded by serializers as "OWP1".
    /// </summary>
    [EnumMember(Value = "OWP1")]
    [IsoId("_vhMWoV51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty regularly posts only variation margin. ")]
    OneWayPartiallyCollateralisedCounterparty1 = CollateralisationTypeCode.OneWayPartiallyCollateralisedCounterparty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty regularly posts only variation margin.
    /// Encoded/decoded by serializers as "OWP2".
    /// </summary>
    [EnumMember(Value = "OWP2")]
    [IsoId("_vl860V51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty regularly posts only variation margin.")]
    OneWayPartiallyCollateralisedCounterparty2 = CollateralisationTypeCode.OneWayPartiallyCollateralisedCounterparty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "PRCL".
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_vqomgV51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction.")]
    PartiallyCollateralised = CollateralisationTypeCode.PartiallyCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty regularly  posts only variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "PRC1".
    /// </summary>
    [EnumMember(Value = "PRC1")]
    [IsoId("_vvppYV51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that the reporting counterparty regularly  posts only variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.")]
    PartiallyCollateralisedCounterparty1 = CollateralisationTypeCode.PartiallyCollateralisedCounterparty1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty regularly posts only variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "PRC2".
    /// </summary>
    [EnumMember(Value = "PRC2")]
    [IsoId("_v0d38V51Ee2a_-MvhEjKmA")]
    [Description(@"The collateral agreement between the counterparties stipulates that the other counterparty regularly posts only variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.")]
    PartiallyCollateralisedCounterparty2 = CollateralisationTypeCode.PartiallyCollateralisedCounterparty2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "UNCL".
    /// </summary>
    [EnumMember(Value = "UNCL")]
    [IsoId("_v_LTIV51Ee2a_-MvhEjKmA")]
    [Description(@"There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction.")]
    Uncollateralised = CollateralisationTypeCode.Uncollateralised, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralisationType3CodeMetadataExtensions
{
    private static readonly CollateralisationType3CodeDropdownSource _dropdownSource = new CollateralisationType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralisationType3CodeDropdownRow GetMetadata(this CollateralisationType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


