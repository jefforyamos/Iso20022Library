﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RetailerService8Code.  ISO2002 ID# _YfHZUN6lEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of specific services for DeviceRequest.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRetailerService8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YfHZUN6lEeiwsev40qZGEQ")]
public partial class RetailerService8CodeDropdownSource : EnumMetadataManager<RetailerService8Code,IRetailerService8CodeDropdownRow,RetailerService8CodeDropdownRow>
{
    public RetailerService8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RetailerService8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}