﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TerminationTypeCode.  ISO2002 ID# _YlvEw9p-Ed-ak6NoX_4Aeg_2067283309.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the timing or method for terminating the agreement - for repos.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITerminationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YlvEw9p-Ed-ak6NoX_4Aeg_2067283309")]
public partial class TerminationTypeCodeDropdownSource : EnumMetadataManager<TerminationTypeCode,ITerminationTypeCodeDropdownRow,TerminationTypeCodeDropdownRow>
{
    public TerminationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TerminationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}