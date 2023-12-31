﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardholderAddressVerificationResult1Code.  ISO2002 ID# _TSXNegEcEeCQm6a_G2yO_w_859983869.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the Cardholder verification address checks on the street number and the Postal Code from the Cardholder's Address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSXNegEcEeCQm6a_G2yO_w_859983869")]
[Description(@"Result of the Cardholder verification address checks on the street number and the Postal Code from the Cardholder's Address.")]
[DerivedFrom(typeof(CardholderAddressVerificationResultCode))]
public enum CardholderAddressVerificationResult1Code
{
    /// <summary>
    /// Address numeric match.
    /// Encoded/decoded by serializers as "AddressMatch".
    /// </summary>
    [EnumMember(Value = "AMCH")]
    [IsoId("_TSXNewEcEeCQm6a_G2yO_w_-1881917421")]
    [Description(@"Address numeric match.")]
    AddressMatch,
    
    /// <summary>
    /// Address numerics do not match.
    /// Encoded/decoded by serializers as "AddressNotMatch".
    /// </summary>
    [EnumMember(Value = "ANMH")]
    [IsoId("_TSXNfAEcEeCQm6a_G2yO_w_-2071134870")]
    [Description(@"Address numerics do not match.")]
    AddressNotMatch,
    
    /// <summary>
    /// Address numeric not processed for technical reason.
    /// Encoded/decoded by serializers as "AddressTechnical".
    /// </summary>
    [EnumMember(Value = "ANMT")]
    [IsoId("_TSXNfQEcEeCQm6a_G2yO_w_-133909697")]
    [Description(@"Address numeric not processed for technical reason.")]
    AddressTechnical,
    
    /// <summary>
    /// Address numeric not processed for non-technical reason.
    /// Encoded/decoded by serializers as "AddressNotTechnical".
    /// </summary>
    [EnumMember(Value = "ANMO")]
    [IsoId("_TSXNfgEcEeCQm6a_G2yO_w_-656898248")]
    [Description(@"Address numeric not processed for non-technical reason.")]
    AddressNotTechnical,
    
    /// <summary>
    /// Address numeric missing in request.
    /// Encoded/decoded by serializers as "AddressMissing".
    /// </summary>
    [EnumMember(Value = "AMSS")]
    [IsoId("_TSXNfwEcEeCQm6a_G2yO_w_1280326925")]
    [Description(@"Address numeric missing in request.")]
    AddressMissing,
    
    /// <summary>
    /// Address numeric not used by issuer.
    /// Encoded/decoded by serializers as "AddressNotUsed".
    /// </summary>
    [EnumMember(Value = "ANUS")]
    [IsoId("_TSXNgAEcEeCQm6a_G2yO_w_-694884291")]
    [Description(@"Address numeric not used by issuer.")]
    AddressNotUsed,
    
    /// <summary>
    /// Postal code matches.
    /// Encoded/decoded by serializers as "PostalMatch".
    /// </summary>
    [EnumMember(Value = "PMCH")]
    [IsoId("_TSXNgQEcEeCQm6a_G2yO_w_1242340882")]
    [Description(@"Postal code matches.")]
    PostalMatch,
    
    /// <summary>
    /// Postal code does not match.
    /// Encoded/decoded by serializers as "PostalNotMatch".
    /// </summary>
    [EnumMember(Value = "PNMH")]
    [IsoId("_TSXNggEcEeCQm6a_G2yO_w_-1449634165")]
    [Description(@"Postal code does not match.")]
    PostalNotMatch,
    
    /// <summary>
    /// Postal code not processed for technical reason.
    /// Encoded/decoded by serializers as "PostalTechnical".
    /// </summary>
    [EnumMember(Value = "PNMT")]
    [IsoId("_TSg-cAEcEeCQm6a_G2yO_w_487591008")]
    [Description(@"Postal code not processed for technical reason.")]
    PostalTechnical,
    
    /// <summary>
    /// Postal code not processed for non-technical reason.
    /// Encoded/decoded by serializers as "PostalNotTechnical".
    /// </summary>
    [EnumMember(Value = "PNMO")]
    [IsoId("_TSg-cQEcEeCQm6a_G2yO_w_-2084666011")]
    [Description(@"Postal code not processed for non-technical reason.")]
    PostalNotTechnical,
    
    /// <summary>
    /// Postal code missing in request.
    /// Encoded/decoded by serializers as "PostalMissing".
    /// </summary>
    [EnumMember(Value = "PMSS")]
    [IsoId("_TSg-cgEcEeCQm6a_G2yO_w_-147440838")]
    [Description(@"Postal code missing in request.")]
    PostalMissing,
    
    /// <summary>
    /// Postal code not used by issuer.
    /// Encoded/decoded by serializers as "PostalNotUsed".
    /// </summary>
    [EnumMember(Value = "PNUS")]
    [IsoId("_TSg-cwEcEeCQm6a_G2yO_w_-1006645673")]
    [Description(@"Postal code not used by issuer.")]
    PostalNotUsed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardholderAddressVerificationResult1CodeMetadataExtensions
{
    private static readonly CardholderAddressVerificationResult1CodeDropdownSource _dropdownSource = new CardholderAddressVerificationResult1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardholderAddressVerificationResult1CodeDropdownRow GetMetadata(this CardholderAddressVerificationResult1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


