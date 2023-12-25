﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OrganisationLegalStatusCode.  ISO2002 ID# _L3FkYBE4EeafpqhYGpTDnw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a legal entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_L3FkYBE4EeafpqhYGpTDnw")]
[Description(@"Specifies the status of a legal entity.")]
public enum OrganisationLegalStatusCode
{
    /// <summary>
    /// Unlimited trust
    /// </summary>
    [EnumMember(Value = "UNLT")]
    [IsoId("_T3gXkBE4EeafpqhYGpTDnw")]
    [Description(@"Unlimited trust")]
    UNLT,
    
    /// <summary>
    /// Unlimited company
    /// </summary>
    [EnumMember(Value = "UNLC")]
    [IsoId("_WLVbYBE4EeafpqhYGpTDnw")]
    [Description(@"Unlimited company")]
    UNLC,
    
    /// <summary>
    /// Sole proprietorship/Sole trader
    /// </summary>
    [EnumMember(Value = "SOLE")]
    [IsoId("_YLFFkBE4EeafpqhYGpTDnw")]
    [Description(@"Sole proprietorship/Sole trader")]
    SOLE,
    
    /// <summary>
    /// Public limited company (Plc.)
    /// </summary>
    [EnumMember(Value = "PCLC")]
    [IsoId("_bjMQ4BE4EeafpqhYGpTDnw")]
    [Description(@"Public limited company (Plc.)")]
    PCLC,
    
    /// <summary>
    /// Private company limited by shares (Ltd.)
    /// </summary>
    [EnumMember(Value = "PCLS")]
    [IsoId("_eVINABE4EeafpqhYGpTDnw")]
    [Description(@"Private company limited by shares (Ltd.)")]
    PCLS,
    
    /// <summary>
    /// Private company limited by guarantee (Ltd.)
    /// </summary>
    [EnumMember(Value = "PCLG")]
    [IsoId("_gidAMBE4EeafpqhYGpTDnw")]
    [Description(@"Private company limited by guarantee (Ltd.)")]
    PCLG,
    
    /// <summary>
    /// Limited partnership (LP)
    /// </summary>
    [EnumMember(Value = "LIMP")]
    [IsoId("_jHB1wBE4EeafpqhYGpTDnw")]
    [Description(@"Limited partnership (LP)")]
    LIMP,
    
    /// <summary>
    /// Limited liability partnership (LLP)
    /// </summary>
    [EnumMember(Value = "LLPP")]
    [IsoId("_lpZr4BE4EeafpqhYGpTDnw")]
    [Description(@"Limited liability partnership (LLP)")]
    LLPP,
    
    /// <summary>
    /// For example a co-operative, which does include Ltd. or charity.
    /// </summary>
    [EnumMember(Value = "IAPS")]
    [IsoId("_uHxmYBE4EeafpqhYGpTDnw")]
    [Description(@"For example a co-operative, which does include Ltd. or charity.")]
    IAPS,
    
    /// <summary>
    /// General partnership
    /// </summary>
    [EnumMember(Value = "GENP")]
    [IsoId("_woAHcBE4EeafpqhYGpTDnw")]
    [Description(@"General partnership")]
    GENP,
    
    /// <summary>
    /// Community Interest Company (CIC)
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_yyykABE4EeafpqhYGpTDnw")]
    [Description(@"Community Interest Company (CIC)")]
    CICC,
    
    /// <summary>
    /// Charity
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_4ZcqgBE4EeafpqhYGpTDnw")]
    [Description(@"Charity")]
    CHAR,
    
    /// <summary>
    /// Charitable incorporated organisation (CIO)
    /// </summary>
    [EnumMember(Value = "CIOC")]
    [IsoId("_6sK7EBE4EeafpqhYGpTDnw")]
    [Description(@"Charitable incorporated organisation (CIO)")]
    CIOC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OrganisationLegalStatusCodeMetadataExtensions
{
    private static readonly OrganisationLegalStatusCodeDropdownSource _dropdownSource = new OrganisationLegalStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOrganisationLegalStatusCodeDropdownRow GetMetadata(this OrganisationLegalStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


