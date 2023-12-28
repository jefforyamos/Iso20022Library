﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrganisationLegalStatus1Code.  ISO2002 ID# _JqD2wH6rEeePx-IqKegQ8Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a legal entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JqD2wH6rEeePx-IqKegQ8Q")]
[Description(@"Specifies the status of a legal entity.")]
[DerivedFrom(typeof(OrganisationLegalStatusCode))]
public enum OrganisationLegalStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CharitableIncorporatedOrganisation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TbNnwX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    CharitableIncorporatedOrganisation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Charity".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ti8ncX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    Charity,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommunityInterestCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_To5ecX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    CommunityInterestCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GeneralPartnership".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_T0zMcX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    GeneralPartnership,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IndustrialAndProvidentSociety".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_T7fqUX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    IndustrialAndProvidentSociety,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LimitedLiabilityPartnership".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UDE5AX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    LimitedLiabilityPartnership,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrivateCompanyLimitedByGuarantee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UI4mEX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    PrivateCompanyLimitedByGuarantee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LimitedPartnership".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UUCtMX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    LimitedPartnership,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrivateCompanyLimitedByShares".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UkQTcX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    PrivateCompanyLimitedByShares,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PublicLimitedCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UqW7cX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    PublicLimitedCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SoleProprietorship".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UxWUQX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    SoleProprietorship,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnlimitedCompany".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U3JaQX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    UnlimitedCompany,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnlimitedTrust".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U89HUX6rEeePx-IqKegQ8Q")]
    [Description(@"??")]
    UnlimitedTrust,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrganisationLegalStatus1CodeMetadataExtensions
{
    private static readonly OrganisationLegalStatus1CodeDropdownSource _dropdownSource = new OrganisationLegalStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrganisationLegalStatus1CodeDropdownRow GetMetadata(this OrganisationLegalStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


