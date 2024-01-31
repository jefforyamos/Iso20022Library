﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RetailerMessageCode.  ISO2002 ID# _dtx60Nj4EeiojJsa6FYyew.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRetailerMessageCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dtx60Nj4EeiojJsa6FYyew")]
public partial class RetailerMessageCodeDropdownSource : EnumMetadataManager<RetailerMessageCode,IRetailerMessageCodeDropdownRow,RetailerMessageCodeDropdownRow>
{
    public RetailerMessageCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RetailerMessageCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
