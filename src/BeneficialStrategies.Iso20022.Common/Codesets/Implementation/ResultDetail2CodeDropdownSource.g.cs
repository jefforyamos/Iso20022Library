﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResultDetail2Code.  ISO2002 ID# _oJDHgIp_EeS3NqNpgnMh2w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Detail of the response to an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResultDetail2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_oJDHgIp_EeS3NqNpgnMh2w")]
public partial class ResultDetail2CodeDropdownSource : EnumMetadataManager<ResultDetail2Code,IResultDetail2CodeDropdownRow,ResultDetail2CodeDropdownRow>
{
    public ResultDetail2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResultDetail2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}