﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentGroupStatus1Code.  ISO2002 ID# _v9bSwWXiEeap-P22vGV91g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment instructions, as published in an external payment group status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentGroupStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v9bSwWXiEeap-P22vGV91g")]
public partial class ExternalPaymentGroupStatus1CodeDropdownSource : EnumMetadataManager<ExternalPaymentGroupStatus1Code,IExternalPaymentGroupStatus1CodeDropdownRow,ExternalPaymentGroupStatus1CodeDropdownRow>
{
    public ExternalPaymentGroupStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentGroupStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
