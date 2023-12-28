﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PoliticalExposureTypeCode.  ISO2002 ID# _7TMJ8RRuEeOKWo1NF21OVw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the political exposure type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPoliticalExposureTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7TMJ8RRuEeOKWo1NF21OVw")]
public partial class PoliticalExposureTypeCodeDropdownSource : EnumMetadataManager<PoliticalExposureTypeCode,IPoliticalExposureTypeCodeDropdownRow,PoliticalExposureTypeCodeDropdownRow>
{
    public PoliticalExposureTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PoliticalExposureTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}