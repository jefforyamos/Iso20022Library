﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionNumberCode.  ISO2002 ID# _aP_AENp-Ed-ak6NoX_4Aeg_1603970622.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code identifying special corporate action option numbers.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionNumberCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aP_AENp-Ed-ak6NoX_4Aeg_1603970622")]
public partial class OptionNumberCodeDropdownSource : EnumMetadataManager<OptionNumberCode,IOptionNumberCodeDropdownRow,OptionNumberCodeDropdownRow>
{
    public OptionNumberCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionNumberCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
