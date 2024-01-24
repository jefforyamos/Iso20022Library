﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingChargeTypeCode.  ISO2002 ID# _-MrKAG7iEeKo25nLKvGr8w_264081623.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external charge type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKAG7iEeKo25nLKvGr8w_264081623")]
[Description(@"Specifies the external charge type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalUndertakingChargeType1Code))]
public enum ExternalUndertakingChargeTypeCode
{
    /// <summary>
    /// Charge related to the issuance of an amendment.
    /// Encoded/decoded by serializers as "AMND".
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_uQ7a8_RYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the issuance of an amendment.")]
    Amendment,
    
    /// <summary>
    /// Charge related to the processing of a claim.
    /// Encoded/decoded by serializers as "CLAM".
    /// </summary>
    [EnumMember(Value = "CLAM")]
    [IsoId("_uQ7a9vRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the processing of a claim.")]
    Claim,
    
    /// <summary>
    /// Commission charge.
    /// Encoded/decoded by serializers as "COMM".
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uQ7a-fRYEeuLhpyIdtJzwg")]
    [Description(@"Commission charge.")]
    Commission,
    
    /// <summary>
    /// Charge for confirmation.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uREk4PRYEeuLhpyIdtJzwg")]
    [Description(@"Charge for confirmation.")]
    Confirmation,
    
    /// <summary>
    /// Courier charge.
    /// Encoded/decoded by serializers as "COUR".
    /// </summary>
    [EnumMember(Value = "COUR")]
    [IsoId("_uREk4_RYEeuLhpyIdtJzwg")]
    [Description(@"Courier charge.")]
    Courier,
    
    /// <summary>
    /// Charge related to the issuance of an undertaking.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uROV4PRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the issuance of an undertaking.")]
    IssuanceCharge,
    
    /// <summary>
    /// Miscellaneous charge.
    /// Encoded/decoded by serializers as "MISC".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_uROV4_RYEeuLhpyIdtJzwg")]
    [Description(@"Miscellaneous charge.")]
    Miscellaneous,
    
    /// <summary>
    /// Charge related to the payment processing.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uROV5vRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the payment processing.")]
    Payment,
    
    /// <summary>
    /// Postage charge.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uROV6fRYEeuLhpyIdtJzwg")]
    [Description(@"Postage charge.")]
    Postage,
    
    /// <summary>
    /// Telecommunication charge.
    /// Encoded/decoded by serializers as "TELE".
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_uROV7PRYEeuLhpyIdtJzwg")]
    [Description(@"Telecommunication charge.")]
    Telecommunication,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingChargeTypeCodeMetadataExtensions
{
    private static readonly ExternalUndertakingChargeTypeCodeDropdownSource _dropdownSource = new ExternalUndertakingChargeTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingChargeTypeCodeDropdownRow GetMetadata(this ExternalUndertakingChargeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


