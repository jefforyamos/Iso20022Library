﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RemittanceLocationMethod2Code.  ISO2002 ID# _ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRemittanceLocationMethod2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZsX8tNp-Ed-ak6NoX_4Aeg_-517543090")]
public partial class RemittanceLocationMethod2CodeDropdownSource : EnumMetadataManager<RemittanceLocationMethod2Code,IRemittanceLocationMethod2CodeDropdownRow,RemittanceLocationMethod2CodeDropdownRow>
{
    public RemittanceLocationMethod2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RemittanceLocationMethod2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
