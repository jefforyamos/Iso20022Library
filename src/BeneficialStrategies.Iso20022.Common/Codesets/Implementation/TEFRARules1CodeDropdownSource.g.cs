﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TEFRARules1Code.  ISO2002 ID# _Yg95g9p-Ed-ak6NoX_4Aeg_126958885.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the IRS under which the security is issued.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITEFRARules1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yg95g9p-Ed-ak6NoX_4Aeg_126958885")]
public partial class TEFRARules1CodeDropdownSource : EnumMetadataManager<TEFRARules1Code,ITEFRARules1CodeDropdownRow,TEFRARules1CodeDropdownRow>
{
    public TEFRARules1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TEFRARules1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
