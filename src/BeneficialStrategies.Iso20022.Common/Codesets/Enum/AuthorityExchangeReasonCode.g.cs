﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthorityExchangeReasonCode.  ISO2002 ID# _YchP0B5REeWc9bJOIIhUUw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YchP0B5REeWc9bJOIIhUUw")]
[Description(@"Specifies the reason for the exchange with the national competent authority.")]
[Derivations(typeof(AuthorityExchangeReason1Code))]
public enum AuthorityExchangeReasonCode
{
    /// <summary>
    /// Competent Authority for Instrument.
    /// Encoded/decoded by serializers as "CAFI".
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_bi05cB5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument,
    
    /// <summary>
    /// Competent Authority for Headquarter.
    /// Encoded/decoded by serializers as "CAFH".
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("_fYwCIB5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Headquarter.")]
    CompetentAuthorityForHeadquarter,
    
    /// <summary>
    /// Ad Hoc Request.
    /// Encoded/decoded by serializers as "ADHR".
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_jtnwoB5REeWc9bJOIIhUUw")]
    [Description(@"Ad Hoc Request.")]
    AdHocRequest,
    
    /// <summary>
    /// Where reason code is not previously defined.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_o3J2QB5REeWc9bJOIIhUUw")]
    [Description(@"Where reason code is not previously defined.")]
    Other,
    
    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as "CADU".
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_YdD3IDCAEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying,
    
    /// <summary>
    /// Competent Authority for Basket Constituent.
    /// Encoded/decoded by serializers as "CABC".
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_5DU-sDCAEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Basket Constituent.")]
    CompetentAuthorityForBasketConstituent,
    
    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as "CABB".
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_CjK9QDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch,
    
    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as "CASB".
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_IT9QIDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch,
    
    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as "CAMB".
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_L6n00DCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch,
    
    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as "CADB".
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_P67okDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch,
    
    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as "CAEB".
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_VJYDYDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch,
    
    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as "CATV".
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_fTfuADCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue,
    
    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as "CAIX".
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_kv9WsDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthorityExchangeReasonCodeMetadataExtensions
{
    private static readonly AuthorityExchangeReasonCodeDropdownSource _dropdownSource = new AuthorityExchangeReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthorityExchangeReasonCodeDropdownRow GetMetadata(this AuthorityExchangeReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


