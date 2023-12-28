﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PrePaymentSpeed1Code.  ISO2002 ID# _aIOyQ9p-Ed-ak6NoX_4Aeg_-288880820.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Speed of unscheduled partial of complete payment of the principal amount outstanding on a debt obligation before its due date.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPrePaymentSpeed1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aIOyQ9p-Ed-ak6NoX_4Aeg_-288880820")]
public partial class PrePaymentSpeed1CodeDropdownSource : EnumMetadataManager<PrePaymentSpeed1Code,IPrePaymentSpeed1CodeDropdownRow,PrePaymentSpeed1CodeDropdownRow>
{
    public PrePaymentSpeed1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PrePaymentSpeed1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}