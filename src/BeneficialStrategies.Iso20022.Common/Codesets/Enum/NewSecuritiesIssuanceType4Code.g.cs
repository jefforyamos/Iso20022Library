﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NewSecuritiesIssuanceType4Code.  ISO2002 ID# _8eWckKFQEeSK_vfd3NHBGg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds newly issued.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8eWckKFQEeSK_vfd3NHBGg")]
[Description(@"Specifies the type of securities proceeds newly issued.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType4Code
{
    /// <summary>
    /// New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "RefundedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_OQnkUaFREeSK_vfd3NHBGg")]
    [Description(@"New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.")]
    RefundedSecurityIndicator,
    
    /// <summary>
    /// New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as "NonRefundedSecurityIndicator".
    /// </summary>
    [EnumMember(Value = "NREF")]
    [IsoId("_OgPUs6FREeSK_vfd3NHBGg")]
    [Description(@"New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonRefundedSecurityIndicator,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NewSecuritiesIssuanceType4CodeMetadataExtensions
{
    private static readonly NewSecuritiesIssuanceType4CodeDropdownSource _dropdownSource = new NewSecuritiesIssuanceType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INewSecuritiesIssuanceType4CodeDropdownRow GetMetadata(this NewSecuritiesIssuanceType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


