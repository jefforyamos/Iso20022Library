﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalBusinessProcess8Code.  ISO2002 ID# _4f5gkJcDEee8S7xwGG7Veg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event such as an automatic market claim.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4f5gkJcDEee8S7xwGG7Veg")]
[Description(@"Specifies the additional business process linked to a corporate action event such as an automatic market claim.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
public enum AdditionalBusinessProcess8Code
{
    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as "CONS".
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_6Jrh0ZcDEee8S7xwGG7Veg")]
    [Description(@"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).")]
    Consent = AdditionalBusinessProcessCode.Consent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "FPRE".
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_6XEdkZcDEee8S7xwGG7Veg")]
    [Description(@"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.")]
    FullPrefunding = AdditionalBusinessProcessCode.FullPrefunding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as "PPUT".
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_6vBqkZcDEee8S7xwGG7Veg")]
    [Description(@"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.")]
    PartialMandatoryPutRedemption = AdditionalBusinessProcessCode.PartialMandatoryPutRedemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as "PPRE".
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_66odoZcDEee8S7xwGG7Veg")]
    [Description(@"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.")]
    PartialPreFunding = AdditionalBusinessProcessCode.PartialPreFunding, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalBusinessProcess8CodeMetadataExtensions
{
    private static readonly AdditionalBusinessProcess8CodeDropdownSource _dropdownSource = new AdditionalBusinessProcess8CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalBusinessProcess8CodeDropdownRow GetMetadata(this AdditionalBusinessProcess8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


