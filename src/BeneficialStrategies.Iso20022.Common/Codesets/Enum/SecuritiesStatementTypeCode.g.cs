﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesStatementTypeCode.  ISO2002 ID# _ZF7Atdp-Ed-ak6NoX_4Aeg_-1780504534.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the statement is an accounting or a custody statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZF7Atdp-Ed-ak6NoX_4Aeg_-1780504534")]
[Description(@"Specifies whether the statement is an accounting or a custody statement.")]
[Derivations(typeof(SecuritiesStatementType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum SecuritiesStatementTypeCode
{
    /// <summary>
    /// Statement is a custody statement.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZF7Attp-Ed-ak6NoX_4Aeg_-1780504515")]
    [Description(@"Statement is a custody statement.")]
    Custody,
    
    /// <summary>
    /// Statement is an accounting statement.
    /// Encoded/decoded by serializers as "ACCT".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_ZF7At9p-Ed-ak6NoX_4Aeg_-1780504491")]
    [Description(@"Statement is an accounting statement.")]
    Accounting,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesStatementTypeCodeMetadataExtensions
{
    private static readonly SecuritiesStatementTypeCodeDropdownSource _dropdownSource = new SecuritiesStatementTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesStatementTypeCodeDropdownRow GetMetadata(this SecuritiesStatementTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


