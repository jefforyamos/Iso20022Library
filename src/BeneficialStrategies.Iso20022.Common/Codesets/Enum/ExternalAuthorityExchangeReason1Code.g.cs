﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalAuthorityExchangeReason1Code.  ISO2002 ID# _M_Hh4J26Eeuwmdq0KtnICg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority, as published in an external category purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_M_Hh4J26Eeuwmdq0KtnICg")]
[Description(@"Specifies the reason for the exchange with the national competent authority, as published in an external category purpose code list. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalAuthorityExchangeReasonCode))]
public enum ExternalAuthorityExchangeReason1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AdHocRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzf8hfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    AdHocRequest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForBuyerBranch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzf8iPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForBuyerBranch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForBasketConstituant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzf8i_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForBasketConstituant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForBuyerTransmittingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzpGcvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForBuyerTransmittingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForDecisionMakingBranch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzpGdfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForDecisionMakingBranch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForDirectUnderlying".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzpGePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForDirectUnderlying,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForExecutingBranch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzpGe_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForExecutingBranch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForInstrument".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzy3cvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForInstrument,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForIndex".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uzy3dfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForIndex,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForMembershipBranch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uz8ocvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForMembershipBranch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForSellerBranch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uz8odfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForSellerBranch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForSellerTransmittingFirm".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uz8oePRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForSellerTransmittingFirm,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CompetentAuthorityForTradingVenue".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uz8oe_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    CompetentAuthorityForTradingVenue,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalAuthorityExchangeReason1CodeMetadataExtensions
{
    private static readonly ExternalAuthorityExchangeReason1CodeDropdownSource _dropdownSource = new ExternalAuthorityExchangeReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalAuthorityExchangeReason1CodeDropdownRow GetMetadata(this ExternalAuthorityExchangeReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


