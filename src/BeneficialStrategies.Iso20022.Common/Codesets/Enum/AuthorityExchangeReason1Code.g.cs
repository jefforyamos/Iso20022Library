﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthorityExchangeReason1Code.  ISO2002 ID# _nq1NEB5REeWc9bJOIIhUUw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nq1NEB5REeWc9bJOIIhUUw")]
[Description(@"Specifies the reason for the exchange with the national competent authority.")]
[DerivedFrom(typeof(AuthorityExchangeReasonCode))]
public enum AuthorityExchangeReason1Code
{
    /// <summary>
    /// Competent Authority for Instrument.
    /// Encoded/decoded by serializers as "CAFI".
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_rlz04R5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument = AuthorityExchangeReasonCode.CompetentAuthorityForInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ad Hoc Request.
    /// Encoded/decoded by serializers as "ADHR".
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_5imKETB_EeWZkK_S04LJWA")]
    [Description(@"Ad Hoc Request.")]
    AdHocRequest = AuthorityExchangeReasonCode.AdHocRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Basket Constituent.
    /// Encoded/decoded by serializers as "CABC".
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_0HVJUTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Basket Constituent.")]
    CompetentAuthorityForBasketConstituent = AuthorityExchangeReasonCode.CompetentAuthorityForBasketConstituent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as "CABB".
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_0P8SwTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch = AuthorityExchangeReasonCode.CompetentAuthorityForBuyerBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as "CADB".
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_0UjtATCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch = AuthorityExchangeReasonCode.CompetentAuthorityForDecisionMakingBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as "CADU".
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_0Z4R4TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying = AuthorityExchangeReasonCode.CompetentAuthorityForDirectUnderlying, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as "CAEB".
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_0eg6QTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch = AuthorityExchangeReasonCode.CompetentAuthorityForExecutingBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as "CAIX".
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_09euMTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex = AuthorityExchangeReasonCode.CompetentAuthorityForIndex, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as "CAMB".
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_1I3e0TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch = AuthorityExchangeReasonCode.CompetentAuthorityForMembershipBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as "CASB".
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_1NgHMTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch = AuthorityExchangeReasonCode.CompetentAuthorityForSellerBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as "CATV".
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_1UxM0TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue = AuthorityExchangeReasonCode.CompetentAuthorityForTradingVenue, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthorityExchangeReason1CodeMetadataExtensions
{
    private static readonly AuthorityExchangeReason1CodeDropdownSource _dropdownSource = new AuthorityExchangeReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthorityExchangeReason1CodeDropdownRow GetMetadata(this AuthorityExchangeReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


