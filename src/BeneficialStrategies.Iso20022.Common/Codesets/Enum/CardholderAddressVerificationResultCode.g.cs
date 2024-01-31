﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardholderAddressVerificationResultCode.  ISO2002 ID# _TWF26gEcEeCQm6a_G2yO_w_1762343535.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the cardholder verification address checks on the street number and the postal code from the cardholder's address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWF26gEcEeCQm6a_G2yO_w_1762343535")]
[Description(@"Result of the cardholder verification address checks on the street number and the postal code from the cardholder's address.")]
[Derivations(typeof(CardholderAddressVerificationResult1Code))]
public enum CardholderAddressVerificationResultCode
{
    /// <summary>
    /// Address numeric match.
    /// Encoded/decoded by serializers as "AMCH".
    /// </summary>
    [EnumMember(Value = "AMCH")]
    [IsoId("_TWF26wEcEeCQm6a_G2yO_w_-126591173")]
    [Description(@"Address numeric match.")]
    AddressMatch,
    
    /// <summary>
    /// Address numerics do not match.
    /// Encoded/decoded by serializers as "ANMH".
    /// </summary>
    [EnumMember(Value = "ANMH")]
    [IsoId("_TWF27AEcEeCQm6a_G2yO_w_-472821746")]
    [Description(@"Address numerics do not match.")]
    AddressNotMatch,
    
    /// <summary>
    /// Address numeric not processed for technical reason.
    /// Encoded/decoded by serializers as "ANMT".
    /// </summary>
    [EnumMember(Value = "ANMT")]
    [IsoId("_TWF27QEcEeCQm6a_G2yO_w_-483920523")]
    [Description(@"Address numeric not processed for technical reason.")]
    AddressTechnical,
    
    /// <summary>
    /// Address numeric not processed for non-technical reason.
    /// Encoded/decoded by serializers as "ANMO".
    /// </summary>
    [EnumMember(Value = "ANMO")]
    [IsoId("_TWF27gEcEeCQm6a_G2yO_w_1261228387")]
    [Description(@"Address numeric not processed for non-technical reason.")]
    AddressNotTechnical,
    
    /// <summary>
    /// Address numeric missing in request.
    /// Encoded/decoded by serializers as "AMSS".
    /// </summary>
    [EnumMember(Value = "AMSS")]
    [IsoId("_TWF27wEcEeCQm6a_G2yO_w_1300981109")]
    [Description(@"Address numeric missing in request.")]
    AddressMissing,
    
    /// <summary>
    /// Address numeric not used by issuer.
    /// Encoded/decoded by serializers as "ANUS".
    /// </summary>
    [EnumMember(Value = "ANUS")]
    [IsoId("_TWF28AEcEeCQm6a_G2yO_w_1535767635")]
    [Description(@"Address numeric not used by issuer.")]
    AddressNotUsed,
    
    /// <summary>
    /// Postal code matches.
    /// Encoded/decoded by serializers as "PMCH".
    /// </summary>
    [EnumMember(Value = "PMCH")]
    [IsoId("_TWF28QEcEeCQm6a_G2yO_w_403706914")]
    [Description(@"Postal code matches.")]
    PostalMatch,
    
    /// <summary>
    /// Postal code does not match.
    /// Encoded/decoded by serializers as "PNMH".
    /// </summary>
    [EnumMember(Value = "PNMH")]
    [IsoId("_TWF28gEcEeCQm6a_G2yO_w_1351396796")]
    [Description(@"Postal code does not match.")]
    PostalNotMatch,
    
    /// <summary>
    /// Postal code not processed for technical reason.
    /// Encoded/decoded by serializers as "PNMT".
    /// </summary>
    [EnumMember(Value = "PNMT")]
    [IsoId("_TWPA0AEcEeCQm6a_G2yO_w_1805484065")]
    [Description(@"Postal code not processed for technical reason.")]
    PostalTechnical,
    
    /// <summary>
    /// Postal code not processed for non-technical reason.
    /// Encoded/decoded by serializers as "PNMO".
    /// </summary>
    [EnumMember(Value = "PNMO")]
    [IsoId("_TWPA0QEcEeCQm6a_G2yO_w_1717862763")]
    [Description(@"Postal code not processed for non-technical reason.")]
    PostalNotTechnical,
    
    /// <summary>
    /// Postal code missing in request.
    /// Encoded/decoded by serializers as "PMSS".
    /// </summary>
    [EnumMember(Value = "PMSS")]
    [IsoId("_TWPA0gEcEeCQm6a_G2yO_w_-50079235")]
    [Description(@"Postal code missing in request.")]
    PostalMissing,
    
    /// <summary>
    /// Postal code not used by issuer.
    /// Encoded/decoded by serializers as "PNUS".
    /// </summary>
    [EnumMember(Value = "PNUS")]
    [IsoId("_TWPA0wEcEeCQm6a_G2yO_w_-61178012")]
    [Description(@"Postal code not used by issuer.")]
    PostalNotUsed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardholderAddressVerificationResultCodeMetadataExtensions
{
    private static readonly CardholderAddressVerificationResultCodeDropdownSource _dropdownSource = new CardholderAddressVerificationResultCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardholderAddressVerificationResultCodeDropdownRow GetMetadata(this CardholderAddressVerificationResultCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


