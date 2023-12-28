﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CurrencyDesignation1Code.  ISO2002 ID# _Bru94Ad2EeSPHJIdUs1USg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a currency is settled offshore or onshore.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICurrencyDesignation1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Bru94Ad2EeSPHJIdUs1USg")]
public partial class CurrencyDesignation1CodeDropdownSource : EnumMetadataManager<CurrencyDesignation1Code,ICurrencyDesignation1CodeDropdownRow,CurrencyDesignation1CodeDropdownRow>
{
    public CurrencyDesignation1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CurrencyDesignation1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}