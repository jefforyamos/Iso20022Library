﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CaseStatusCode.  ISO2002 ID# _a2uP9Np-Ed-ak6NoX_4Aeg_-1002966557.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an investigation case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2uP9Np-Ed-ak6NoX_4Aeg_-1002966557")]
[Description(@"Specifies the status of an investigation case.")]
[Derivations(typeof(CaseStatus2Code))]
public enum CaseStatusCode
{
    /// <summary>
    /// Case has been closed.
    /// Encoded/decoded by serializers as "CLSD".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_a2uP9dp-Ed-ak6NoX_4Aeg_-1002966531")]
    [Description(@"Case has been closed.")]
    Closed,
    
    /// <summary>
    /// Case has been assigned to another party.
    /// Encoded/decoded by serializers as "ASGN".
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_a2uP9tp-Ed-ak6NoX_4Aeg_-1002966514")]
    [Description(@"Case has been assigned to another party.")]
    Assigned,
    
    /// <summary>
    /// Case is currently under investigation.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_a2uP99p-Ed-ak6NoX_4Aeg_-1002966497")]
    [Description(@"Case is currently under investigation.")]
    UnderInvestigation,
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as "UKNW".
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2uP-Np-Ed-ak6NoX_4Aeg_-1002966479")]
    [Description(@"Case has never been assigned before.")]
    Unknown,
    
    /// <summary>
    /// Investigation is taking too long.
    /// Encoded/decoded by serializers as "ODUE".
    /// </summary>
    [EnumMember(Value = "ODUE")]
    [IsoId("_a24A8Np-Ed-ak6NoX_4Aeg_-960484981")]
    [Description(@"Investigation is taking too long.")]
    Overdue,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CaseStatusCodeMetadataExtensions
{
    private static readonly CaseStatusCodeDropdownSource _dropdownSource = new CaseStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICaseStatusCodeDropdownRow GetMetadata(this CaseStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


