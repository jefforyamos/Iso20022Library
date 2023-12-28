﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionStatementReportingTypeCode.  ISO2002 ID# _bTCYiNp-Ed-ak6NoX_4Aeg_263893387.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of statement reporting on account holdings for corporate action events eg. reporting on multiple accounts or multiple events.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTCYiNp-Ed-ak6NoX_4Aeg_263893387")]
[Description(@"Type of statement reporting on account holdings for corporate action events eg. reporting on multiple accounts or multiple events.")]
public enum CorporateActionStatementReportingTypeCode
{
    /// <summary>
    /// The reporting is for a single event and for multiple accounts.
    /// Encoded/decoded by serializers as "MASE".
    /// </summary>
    [EnumMember(Value = "MASE")]
    [IsoId("_bTMJgNp-Ed-ak6NoX_4Aeg_358501091")]
    [Description(@"The reporting is for a single event and for multiple accounts.")]
    MultipleAccounts,
    
    /// <summary>
    /// The reporting is for multiple events for a single account.
    /// Encoded/decoded by serializers as "SAME".
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("_bTMJgdp-Ed-ak6NoX_4Aeg_761162779")]
    [Description(@"The reporting is for multiple events for a single account.")]
    MultipleEvents,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionStatementReportingTypeCodeMetadataExtensions
{
    private static readonly CorporateActionStatementReportingTypeCodeDropdownSource _dropdownSource = new CorporateActionStatementReportingTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionStatementReportingTypeCodeDropdownRow GetMetadata(this CorporateActionStatementReportingTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

