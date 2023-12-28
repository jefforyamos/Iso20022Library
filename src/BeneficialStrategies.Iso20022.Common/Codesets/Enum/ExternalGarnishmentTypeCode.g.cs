﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalGarnishmentTypeCode.  ISO2002 ID# _vfkPYLf7Eee9KIDjEHK7ZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the garnishment type as published in an external document type code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vfkPYLf7Eee9KIDjEHK7ZQ")]
[Description(@"Specifies the garnishment type as published in an external document type code list.")]
[Derivations(typeof(ExternalGarnishmentType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalGarnishmentTypeCode
{
    /// <summary>
    /// Garnishment from a third party payer for Child Support
    /// Encoded/decoded by serializers as "GNCS".
    /// </summary>
    [EnumMember(Value = "GNCS")]
    [IsoId("_uTKPk_RYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a third party payer for Child Support")]
    GarnishmentForChildSupport,
    
    /// <summary>
    /// Garnishment from a direct payer for Child Support
    /// Encoded/decoded by serializers as "GNDP".
    /// </summary>
    [EnumMember(Value = "GNDP")]
    [IsoId("_uTUAkPRYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a direct payer for Child Support")]
    GarnishmentForChildSupportFromDirectPayer,
    
    /// <summary>
    /// Garnishment from a third party payer to taxing agency
    /// Encoded/decoded by serializers as "GTPP".
    /// </summary>
    [EnumMember(Value = "GTPP")]
    [IsoId("_uTUAk_RYEeuLhpyIdtJzwg")]
    [Description(@"Garnishment from a third party payer to taxing agency")]
    GarnishmentToTaxingAgency,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalGarnishmentTypeCodeMetadataExtensions
{
    private static readonly ExternalGarnishmentTypeCodeDropdownSource _dropdownSource = new ExternalGarnishmentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalGarnishmentTypeCodeDropdownRow GetMetadata(this ExternalGarnishmentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


