﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReferToFundOrderDesk1Code.  ISO2002 ID# _Zaydc9p-Ed-ak6NoX_4Aeg_347400994.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the operation is only possible in restricted circumstances.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReferToFundOrderDesk1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zaydc9p-Ed-ak6NoX_4Aeg_347400994")]
public partial class ReferToFundOrderDesk1CodeDropdownSource : EnumMetadataManager<ReferToFundOrderDesk1Code,IReferToFundOrderDesk1CodeDropdownRow,ReferToFundOrderDesk1CodeDropdownRow>
{
    public ReferToFundOrderDesk1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReferToFundOrderDesk1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
