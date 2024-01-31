﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EquityReturnParameterCode.  ISO2002 ID# _E3W44QneEeWa7rBfPECYsw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an equity derivative return parameter.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEquityReturnParameterCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_E3W44QneEeWa7rBfPECYsw")]
public partial class EquityReturnParameterCodeDropdownSource : EnumMetadataManager<EquityReturnParameterCode,IEquityReturnParameterCodeDropdownRow,EquityReturnParameterCodeDropdownRow>
{
    public EquityReturnParameterCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EquityReturnParameterCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
