﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ServiceTaxDesignationCode.  ISO2002 ID# _6WNctpqlEeGSON8vddiWzQ_739430745.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the taxable status of the service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WNctpqlEeGSON8vddiWzQ_739430745")]
[Description(@"Defines the taxable status of the service.")]
public enum ServiceTaxDesignationCode
{
    /// <summary>
    /// No taxes are due.
    /// Encoded/decoded by serializers as "XMPT".
    /// </summary>
    [EnumMember(Value = "XMPT")]
    [IsoId("_6WXNsJqlEeGSON8vddiWzQ_-1826168172")]
    [Description(@"No taxes are due.")]
    Exempt,
    
    /// <summary>
    /// Tax is due but at zero percent and a zero charge.
    /// Encoded/decoded by serializers as "ZERO".
    /// </summary>
    [EnumMember(Value = "ZERO")]
    [IsoId("_6WXNsZqlEeGSON8vddiWzQ_-1583318414")]
    [Description(@"Tax is due but at zero percent and a zero charge.")]
    ZeroRate,
    
    /// <summary>
    /// One or more taxes are due on this service.
    /// Encoded/decoded by serializers as "TAXE".
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_6WXNspqlEeGSON8vddiWzQ_-1665032100")]
    [Description(@"One or more taxes are due on this service.")]
    Taxable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ServiceTaxDesignationCodeMetadataExtensions
{
    private static readonly ServiceTaxDesignationCodeDropdownSource _dropdownSource = new ServiceTaxDesignationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IServiceTaxDesignationCodeDropdownRow GetMetadata(this ServiceTaxDesignationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


