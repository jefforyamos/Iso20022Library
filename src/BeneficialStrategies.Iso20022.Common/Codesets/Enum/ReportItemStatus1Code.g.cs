﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportItemStatus1Code.  ISO2002 ID# _NSTaoEisEeSlHoYg_EudVQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NSTaoEisEeSlHoYg_EudVQ")]
[Description(@"Specifies the status of an entry in a report.")]
[DerivedFrom(typeof(ReportItemStatusCode))]
public enum ReportItemStatus1Code
{
    /// <summary>
    /// Entry has been accepted by the receiver of the report.
    /// Encoded/decoded by serializers as "ACPD".
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_VMcTwUi5EeSlHoYg_EudVQ")]
    [Description(@"Entry has been accepted by the receiver of the report.")]
    Accepted = ReportItemStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry has been rejected by the receiver of the report.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_VbdnMUi5EeSlHoYg_EudVQ")]
    [Description(@"Entry has been rejected by the receiver of the report.")]
    Rejected = ReportItemStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReportItemStatus1CodeMetadataExtensions
{
    private static readonly ReportItemStatus1CodeDropdownSource _dropdownSource = new ReportItemStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReportItemStatus1CodeDropdownRow GetMetadata(this ReportItemStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


