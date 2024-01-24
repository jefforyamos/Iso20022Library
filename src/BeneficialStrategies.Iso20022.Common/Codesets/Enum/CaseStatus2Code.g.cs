﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CaseStatus2Code.  ISO2002 ID# _a2lGB9p-Ed-ak6NoX_4Aeg_-286578843.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an investigation case.||Note: |The cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2lGB9p-Ed-ak6NoX_4Aeg_-286578843")]
[Description(@"Specifies the status of an investigation case.||Note: |The cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.")]
[DerivedFrom(typeof(CaseStatusCode))]
public enum CaseStatus2Code
{
    /// <summary>
    /// Case has been closed.
    /// Encoded/decoded by serializers as "CLSD".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_a2lGCNp-Ed-ak6NoX_4Aeg_-286578825")]
    [Description(@"Case has been closed.")]
    Closed = CaseStatusCode.Closed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case has been assigned to another party.
    /// Encoded/decoded by serializers as "ASGN".
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_a2uP8Np-Ed-ak6NoX_4Aeg_-286578808")]
    [Description(@"Case has been assigned to another party.")]
    Assigned = CaseStatusCode.Assigned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case is currently under investigation.
    /// Encoded/decoded by serializers as "INVE".
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_a2uP8dp-Ed-ak6NoX_4Aeg_-286578566")]
    [Description(@"Case is currently under investigation.")]
    UnderInvestigation = CaseStatusCode.UnderInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as "UKNW".
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2uP8tp-Ed-ak6NoX_4Aeg_-286578549")]
    [Description(@"Case has never been assigned before.")]
    Unknown = CaseStatusCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investigation is taking too long.
    /// Encoded/decoded by serializers as "ODUE".
    /// </summary>
    [EnumMember(Value = "ODUE")]
    [IsoId("_a2uP89p-Ed-ak6NoX_4Aeg_-286578548")]
    [Description(@"Investigation is taking too long.")]
    Overdue = CaseStatusCode.Overdue, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CaseStatus2CodeMetadataExtensions
{
    private static readonly CaseStatus2CodeDropdownSource _dropdownSource = new CaseStatus2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICaseStatus2CodeDropdownRow GetMetadata(this CaseStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


