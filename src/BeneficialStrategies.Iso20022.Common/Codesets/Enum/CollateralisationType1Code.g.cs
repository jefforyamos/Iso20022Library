﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralisationType1Code.  ISO2002 ID# _KepsAPP6EeS_qLctCs2aRQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral agreement between two parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KepsAPP6EeS_qLctCs2aRQ")]
[Description(@"Specifies the type of collateral agreement between two parties.")]
[DerivedFrom(typeof(CollateralisationTypeCode))]
public enum CollateralisationType1Code
{
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "FLCL".
    /// </summary>
    [EnumMember(Value = "FLCL")]
    [IsoId("_Ofu70fP6EeS_qLctCs2aRQ")]
    [Description(@"The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction.")]
    FullyCollateralised = CollateralisationTypeCode.FullyCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that one counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "OWCL".
    /// </summary>
    [EnumMember(Value = "OWCL")]
    [IsoId("_Op_rEfP6EeS_qLctCs2aRQ")]
    [Description(@"The collateral agreement between the counterparties stipulates that one counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.")]
    OneWayCollateralised = CollateralisationTypeCode.OneWayCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "PRCL".
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_O1wPI_P6EeS_qLctCs2aRQ")]
    [Description(@"The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction.")]
    PartiallyCollateralised = CollateralisationTypeCode.PartiallyCollateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction.
    /// Encoded/decoded by serializers as "UNCL".
    /// </summary>
    [EnumMember(Value = "UNCL")]
    [IsoId("_O3_DwfP6EeS_qLctCs2aRQ")]
    [Description(@"There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction.")]
    Uncollateralised = CollateralisationTypeCode.Uncollateralised, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralisationType1CodeMetadataExtensions
{
    private static readonly CollateralisationType1CodeDropdownSource _dropdownSource = new CollateralisationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralisationType1CodeDropdownRow GetMetadata(this CollateralisationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


