﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesStatementType1Code.  ISO2002 ID# _ZF7Astp-Ed-ak6NoX_4Aeg_-1354761740.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the statement is an accounting or a custody statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZF7Astp-Ed-ak6NoX_4Aeg_-1354761740")]
[Description(@"Specifies whether the statement is an accounting or a custody statement.")]
[DerivedFrom(typeof(SecuritiesStatementTypeCode))]
public enum SecuritiesStatementType1Code
{
    /// <summary>
    /// Statement is a custody statement.
    /// Encoded/decoded by serializers as "Custody".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZF7As9p-Ed-ak6NoX_4Aeg_-1354761291")]
    [Description(@"Statement is a custody statement.")]
    Custody,
    
    /// <summary>
    /// Statement is an accounting statement.
    /// Encoded/decoded by serializers as "Accounting".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_ZF7AtNp-Ed-ak6NoX_4Aeg_-1354760395")]
    [Description(@"Statement is an accounting statement.")]
    Accounting,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesStatementType1CodeMetadataExtensions
{
    private static readonly SecuritiesStatementType1CodeDropdownSource _dropdownSource = new SecuritiesStatementType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesStatementType1CodeDropdownRow GetMetadata(this SecuritiesStatementType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


