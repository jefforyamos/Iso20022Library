﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EUSavingsDirective1Code.  ISO2002 ID# _aiUGM9p-Ed-ak6NoX_4Aeg_511985802.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter "Variable" if the status of the fund is likely to change from time to time.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEUSavingsDirective1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aiUGM9p-Ed-ak6NoX_4Aeg_511985802")]
public partial class EUSavingsDirective1CodeDropdownSource : EnumMetadataManager<EUSavingsDirective1Code,IEUSavingsDirective1CodeDropdownRow,EUSavingsDirective1CodeDropdownRow>
{
    public EUSavingsDirective1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EUSavingsDirective1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
