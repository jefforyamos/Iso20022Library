﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalSecuritiesPurposeCode.  ISO2002 ID# _5eZzoPomEe2ClqPWkEN24A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external securities purpose code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5eZzoPomEe2ClqPWkEN24A")]
[Description(@"Specifies the external securities purpose code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code set published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalSecuritiesPurposeCode
{
    /// <summary>
    /// Relates to collateral management.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_5eZzrPomEe2ClqPWkEN24A")]
    [Description(@"Relates to collateral management.")]
    COLL,
    
    /// <summary>
    /// Relates to securities lending.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_5eZztPomEe2ClqPWkEN24A")]
    [Description(@"Relates to securities lending.")]
    SECL,
    
    /// <summary>
    /// Relates to settlements.
    /// </summary>
    [EnumMember(Value = "STMT")]
    [IsoId("_5eZzqfomEe2ClqPWkEN24A")]
    [Description(@"Relates to settlements.")]
    STMT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalSecuritiesPurposeCodeMetadataExtensions
{
    private static readonly ExternalSecuritiesPurposeCodeDropdownSource _dropdownSource = new ExternalSecuritiesPurposeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalSecuritiesPurposeCodeDropdownRow GetMetadata(this ExternalSecuritiesPurposeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


