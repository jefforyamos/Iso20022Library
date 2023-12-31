﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Reconciliation1Code.  ISO2002 ID# _T9SaIISIEeW47-F5RGn37Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_T9SaIISIEeW47-F5RGn37Q")]
[Description(@"Specifies the process type used for the trade repository reconciliation.")]
[DerivedFrom(typeof(ReconciliationCode))]
public enum Reconciliation1Code
{
    /// <summary>
    /// Trade repository has both sides of the trade reported and all fields match.
    /// Encoded/decoded by serializers as "DualSidedMatched".
    /// </summary>
    [EnumMember(Value = "DSMA")]
    [IsoId("_ZATBAYSIEeW47-F5RGn37Q")]
    [Description(@"Trade repository has both sides of the trade reported and all fields match.")]
    DualSidedMatched,
    
    /// <summary>
    /// Trade repository has both sides of the trade reported but not all fields match.
    /// Encoded/decoded by serializers as "DualSidedNonMatched".
    /// </summary>
    [EnumMember(Value = "DSNM")]
    [IsoId("_ZLK0QYSIEeW47-F5RGn37Q")]
    [Description(@"Trade repository has both sides of the trade reported but not all fields match.")]
    DualSidedNonMatched,
    
    /// <summary>
    /// Trade was not required to be submitted for reconciliation.
    /// Encoded/decoded by serializers as "NotSubmittedToReconciliation".
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_ZdxAIoSIEeW47-F5RGn37Q")]
    [Description(@"Trade was not required to be submitted for reconciliation.")]
    NotSubmittedToReconciliation,
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.
    /// Encoded/decoded by serializers as "SingleSidedEEAMatched".
    /// </summary>
    [EnumMember(Value = "SSMA")]
    [IsoId("_ZtHqwoSIEeW47-F5RGn37Q")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, has already performed the comparison of the reports, and the result has been successful according to the specification of the inter-TR reconciliation process.")]
    SingleSidedEEAMatched,
    
    /// <summary>
    /// Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.
    /// Encoded/decoded by serializers as "SingleSidedEEAPaired".
    /// </summary>
    [EnumMember(Value = "SSPA")]
    [IsoId("_Z8YOwoSIEeW47-F5RGn37Q")]
    [Description(@"Trade repository has one side of the trade, knows which trade repository holds the other side of the trade, and either has already performed comparison of the reports, or is in the process of doing so.")]
    SingleSidedEEAPaired,
    
    /// <summary>
    /// Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.
    /// Encoded/decoded by serializers as "SingleSidedNonEEA".
    /// </summary>
    [EnumMember(Value = "SSNE")]
    [IsoId("_aUga4oSIEeW47-F5RGn37Q")]
    [Description(@"Trade repository has one side of the trade and knows that the other side does not have a reporting obligation.")]
    SingleSidedNonEEA,
    
    /// <summary>
    /// Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.
    /// Encoded/decoded by serializers as "SingleSidedEEAUnpaired".
    /// </summary>
    [EnumMember(Value = "SSUN")]
    [IsoId("_afMA4YSIEeW47-F5RGn37Q")]
    [Description(@"Trade repository has one side of the trade, knows that the other side is EEA counterparty and does not know which TR holds the other side of the trade.")]
    SingleSidedEEAUnpaired,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Reconciliation1CodeMetadataExtensions
{
    private static readonly Reconciliation1CodeDropdownSource _dropdownSource = new Reconciliation1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliation1CodeDropdownRow GetMetadata(this Reconciliation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


