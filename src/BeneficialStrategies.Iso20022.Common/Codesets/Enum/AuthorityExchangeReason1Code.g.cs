﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthorityExchangeReason1Code.  ISO2002 ID# _nq1NEB5REeWc9bJOIIhUUw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "CompetentAuthorityForInstrument".
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_rlz04R5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument,
    
    /// <summary>
    /// Ad Hoc Request.
    /// Encoded/decoded by serializers as "AdHocRequest".
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_5imKETB_EeWZkK_S04LJWA")]
    [Description(@"Ad Hoc Request.")]
    AdHocRequest,
    
    /// <summary>
    /// Competent Authority for Basket Constituent.
    /// Encoded/decoded by serializers as "CompetentAuthorityForBasketConstituent".
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_0HVJUTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Basket Constituent.")]
    CompetentAuthorityForBasketConstituent,
    
    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as "CompetentAuthorityForBuyerBranch".
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_0P8SwTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch,
    
    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as "CompetentAuthorityForDecisionMakingBranch".
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_0UjtATCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch,
    
    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as "CompetentAuthorityForDirectUnderlying".
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_0Z4R4TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying,
    
    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as "CompetentAuthorityForExecutingBranch".
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_0eg6QTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch,
    
    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as "CompetentAuthorityForIndex".
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_09euMTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex,
    
    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as "CompetentAuthorityForMembershipBranch".
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_1I3e0TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch,
    
    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as "CompetentAuthorityForSellerBranch".
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_1NgHMTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch,
    
    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as "CompetentAuthorityForTradingVenue".
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_1UxM0TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue,
    
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


