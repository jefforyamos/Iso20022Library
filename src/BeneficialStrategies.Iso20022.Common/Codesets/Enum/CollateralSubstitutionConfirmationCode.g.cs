﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralSubstitutionConfirmationCode.  ISO2002 ID# _Yb5zU9p-Ed-ak6NoX_4Aeg_33978882.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of the collateral substitution, either returned or released.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yb5zU9p-Ed-ak6NoX_4Aeg_33978882")]
[Description(@"Provides the status of the collateral substitution, either returned or released.")]
[Derivations(typeof(CollateralSubstitutionConfirmation1Code))]
public enum CollateralSubstitutionConfirmationCode
{
    /// <summary>
    /// Notification that the collateral substitution, that is new piece(s) of collateral, have been released.
    /// Encoded/decoded by serializers as "CREL".
    /// </summary>
    [EnumMember(Value = "CREL")]
    [IsoId("_Yb5zVNp-Ed-ak6NoX_4Aeg_-808634352")]
    [Description(@"Notification that the collateral substitution, that is new piece(s) of collateral, have been released.")]
    CollateralSubstitutionReleased,
    
    /// <summary>
    /// Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received.
    /// Encoded/decoded by serializers as "CRET".
    /// </summary>
    [EnumMember(Value = "CRET")]
    [IsoId("_Yb5zVdp-Ed-ak6NoX_4Aeg_-760306748")]
    [Description(@"Confirmation that the collateral substitution, that is new piece(s) of collateral, have been received.")]
    CollateralSubstitutionReturned,
    
}
