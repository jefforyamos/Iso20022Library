﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BillingStatementStatusCode.  ISO2002 ID# _6VUE1pqlEeGSON8vddiWzQ_861577519.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the status of the billing statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6VUE1pqlEeGSON8vddiWzQ_861577519")]
[Description(@"Defines the status of the billing statement.")]
public enum BillingStatementStatusCode
{
    /// <summary>
    /// Statement is the original statement.
    /// Encoded/decoded by serializers as "ORGN".
    /// </summary>
    [EnumMember(Value = "ORGN")]
    [IsoId("_6VUE15qlEeGSON8vddiWzQ_25393892")]
    [Description(@"Statement is the original statement.")]
    Original,
    
    /// <summary>
    /// Statement replaces the original statement.
    /// Encoded/decoded by serializers as "RPLC".
    /// </summary>
    [EnumMember(Value = "RPLC")]
    [IsoId("_6Vd10JqlEeGSON8vddiWzQ_1981252080")]
    [Description(@"Statement replaces the original statement.")]
    Replace,
    
    /// <summary>
    /// Statement is a test statement.
    /// Encoded/decoded by serializers as "TEST".
    /// </summary>
    [EnumMember(Value = "TEST")]
    [IsoId("_6Vd10ZqlEeGSON8vddiWzQ_612239661")]
    [Description(@"Statement is a test statement.")]
    Test,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BillingStatementStatusCodeMetadataExtensions
{
    private static readonly BillingStatementStatusCodeDropdownSource _dropdownSource = new BillingStatementStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBillingStatementStatusCodeDropdownRow GetMetadata(this BillingStatementStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

