﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralSubstitutionConfirmation1Code.  ISO2002 ID# _Yb5zUNp-Ed-ak6NoX_4Aeg_-794314773.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of the collateral substitution, either returned or released.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yb5zUNp-Ed-ak6NoX_4Aeg_-794314773")]
[Description(@"Provides the status of the collateral substitution, either returned or released.")]
[DerivedFrom(typeof(CollateralSubstitutionConfirmationCode))]
public enum CollateralSubstitutionConfirmation1Code
{
    /// <summary>
    /// Notification that the collateral substitution, that is new piece(s) of collateral, have been released.
    /// Encoded/decoded by serializers as "CREL".
    /// </summary>
    [EnumMember(Value = "CREL")]
    [IsoId("_Yb5zUdp-Ed-ak6NoX_4Aeg_434936971")]
    [Description(@"Notification that the collateral substitution, that is new piece(s) of collateral, have been released.")]
    CollateralSubstitutionReleased = CollateralSubstitutionConfirmationCode.CollateralSubstitutionReleased, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received.
    /// Encoded/decoded by serializers as "CRET".
    /// </summary>
    [EnumMember(Value = "CRET")]
    [IsoId("_Yb5zUtp-Ed-ak6NoX_4Aeg_-1408932018")]
    [Description(@"Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received.")]
    CollateralSubstitutionReturned = CollateralSubstitutionConfirmationCode.CollateralSubstitutionReturned, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralSubstitutionConfirmation1CodeMetadataExtensions
{
    private static readonly CollateralSubstitutionConfirmation1CodeDropdownSource _dropdownSource = new CollateralSubstitutionConfirmation1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralSubstitutionConfirmation1CodeDropdownRow GetMetadata(this CollateralSubstitutionConfirmation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


