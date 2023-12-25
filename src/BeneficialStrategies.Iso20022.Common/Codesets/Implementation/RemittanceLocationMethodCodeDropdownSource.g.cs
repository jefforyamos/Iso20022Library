﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RemittanceLocationMethodCode.  ISO2002 ID# _ZshGodp-Ed-ak6NoX_4Aeg_-702329779.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRemittanceLocationMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZshGodp-Ed-ak6NoX_4Aeg_-702329779")]
public partial class RemittanceLocationMethodCodeDropdownSource : EnumMetadataManager<RemittanceLocationMethodCode,IRemittanceLocationMethodCodeDropdownRow,RemittanceLocationMethodCodeDropdownRow>
{
    public RemittanceLocationMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RemittanceLocationMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
