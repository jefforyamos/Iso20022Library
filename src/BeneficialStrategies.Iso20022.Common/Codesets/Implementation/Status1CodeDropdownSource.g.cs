﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Status1Code.  ISO2002 ID# _Vp1UUNp-Ed-ak6NoX_4Aeg_358546610.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vp1UUNp-Ed-ak6NoX_4Aeg_358546610")]
public partial class Status1CodeDropdownSource : EnumMetadataManager<Status1Code,IStatus1CodeDropdownRow,Status1CodeDropdownRow>
{
    public Status1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Status1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
