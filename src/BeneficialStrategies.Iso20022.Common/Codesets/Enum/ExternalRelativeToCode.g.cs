﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalRelativeToCode.  ISO2002 ID# _-MYPE27iEeKo25nLKvGr8w_-1433191435.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPE27iEeKo25nLKvGr8w_-1433191435")]
[Description(@"Specifies the external relative to code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalRelativeToCode
{
    /// <summary>
    /// Percentage rate expressed relative to the value of goods.
    /// Encoded/decoded by serializers as "GOOD".
    /// </summary>
    [EnumMember(Value = "GOOD")]
    [IsoId("_uQCDEPRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the value of goods.")]
    ValueOfGoods,
    
    /// <summary>
    /// Percentage rate expressed relative to the payment amount.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uQCDE_RYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the payment amount.")]
    PaymentAmount,
    
    /// <summary>
    /// Percentage rate expressed relative to the undertaking amount.
    /// Encoded/decoded by serializers as "UNDG".
    /// </summary>
    [EnumMember(Value = "UNDG")]
    [IsoId("_uQCDFvRYEeuLhpyIdtJzwg")]
    [Description(@"Percentage rate expressed relative to the undertaking amount.")]
    UndertakingAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalRelativeToCodeMetadataExtensions
{
    private static readonly ExternalRelativeToCodeDropdownSource _dropdownSource = new ExternalRelativeToCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalRelativeToCodeDropdownRow GetMetadata(this ExternalRelativeToCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

