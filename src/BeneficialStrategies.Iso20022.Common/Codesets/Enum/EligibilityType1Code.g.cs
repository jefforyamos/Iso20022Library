﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EligibilityType1Code.  ISO2002 ID# _jBwc4O5NEeCisYr99QEiWA_1266829801.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of eligibility.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jBwc4O5NEeCisYr99QEiWA_1266829801")]
[Description(@"Defines the type of eligibility.")]
[DerivedFrom(typeof(EligibilityTypeCode))]
public enum EligibilityType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Securities".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jBwc4e5NEeCisYr99QEiWA_958890440")]
    [Description(@"??")]
    Securities,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IssuerCSD".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jBwc4u5NEeCisYr99QEiWA_-1194522765")]
    [Description(@"??")]
    IssuerCSD,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Country".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jBwc4-5NEeCisYr99QEiWA_-869405258")]
    [Description(@"??")]
    Country,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EligibilityType1CodeMetadataExtensions
{
    private static readonly EligibilityType1CodeDropdownSource _dropdownSource = new EligibilityType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEligibilityType1CodeDropdownRow GetMetadata(this EligibilityType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


