﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrganisationType1Code.  ISO2002 ID# _g0YAgCCfEeWJd9HF2tO7BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_g0YAgCCfEeWJd9HF2tO7BA")]
[Description(@"Specifies a type of organisation.")]
[DerivedFrom(typeof(OrganisationTypeCode))]
public enum OrganisationType1Code
{
    /// <summary>
    /// Organisation is an investment fund.
    /// Encoded/decoded by serializers as "IFUN".
    /// </summary>
    [EnumMember(Value = "IFUN")]
    [IsoId("_jvGFMSCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is an investment fund.")]
    InvestmentFund = OrganisationTypeCode.InvestmentFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Organisation is a private association.
    /// Encoded/decoded by serializers as "PRIV".
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_j2YY8SCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a private association.")]
    PrivateAssociation = OrganisationTypeCode.PrivateAssociation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Organisation is a public company.
    /// Encoded/decoded by serializers as "PUBL".
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_j9rTwSCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a public company.")]
    Public = OrganisationTypeCode.Public, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Organisation is a public fund.
    /// Encoded/decoded by serializers as "PFUN".
    /// </summary>
    [EnumMember(Value = "PFUN")]
    [IsoId("_kFHYgSCfEeWJd9HF2tO7BA")]
    [Description(@"Organisation is a public fund.")]
    PublicFund = OrganisationTypeCode.PublicFund, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrganisationType1CodeMetadataExtensions
{
    private static readonly OrganisationType1CodeDropdownSource _dropdownSource = new OrganisationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrganisationType1CodeDropdownRow GetMetadata(this OrganisationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


