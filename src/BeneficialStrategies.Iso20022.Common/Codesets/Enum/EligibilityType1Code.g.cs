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
    /// Eligibility applies at securities level.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_jBwc4e5NEeCisYr99QEiWA_958890440")]
    [Description(@"Eligibility applies at securities level.")]
    Securities = EligibilityTypeCode.Securities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Eligibility applies at the level of issuer CSD.
    /// All of the securities issued by the issuer CSD are eligible.
    /// Encoded/decoded by serializers as "ISCS".
    /// </summary>
    [EnumMember(Value = "ISCS")]
    [IsoId("_jBwc4u5NEeCisYr99QEiWA_-1194522765")]
    [Description(@"Eligibility applies at the level of issuer CSD.|All of the securities issued by the issuer CSD are eligible.")]
    IssuerCSD = EligibilityTypeCode.IssuerCSD, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Eligibility applies at country level.
    /// All of the securities issued in that country are eligible.
    /// Encoded/decoded by serializers as "CTRY".
    /// </summary>
    [EnumMember(Value = "CTRY")]
    [IsoId("_jBwc4-5NEeCisYr99QEiWA_-869405258")]
    [Description(@"Eligibility applies at country level.|All of the securities issued in that country are eligible.")]
    Country = EligibilityTypeCode.Country, // same ordinal as derivation source for type conversions
    
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


