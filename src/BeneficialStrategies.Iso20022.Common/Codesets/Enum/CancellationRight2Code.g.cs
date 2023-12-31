﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CancellationRight2Code.  ISO2002 ID# _VkKxMNp-Ed-ak6NoX_4Aeg_1274144417.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VkKxMNp-Ed-ak6NoX_4Aeg_1274144417")]
[Description(@"Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.")]
[DerivedFrom(typeof(CancellationRightCode))]
public enum CancellationRight2Code
{
    /// <summary>
    /// Investor is entitled to a "cooling off" period with cancellation rights under compliance rules.
    /// Encoded/decoded by serializers as "Entitled".
    /// </summary>
    [EnumMember(Value = "VALI")]
    [IsoId("_VkKxMdp-Ed-ak6NoX_4Aeg_1687884304")]
    [Description(@"Investor is entitled to a ""cooling off"" period with cancellation rights under compliance rules.")]
    Entitled,
    
    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution's only client.
    /// Encoded/decoded by serializers as "ExecutionOnly".
    /// </summary>
    [EnumMember(Value = "NOXO")]
    [IsoId("_VkKxMtp-Ed-ak6NoX_4Aeg_1687884598")]
    [Description(@"Investor is not entitled to cancellation rights under compliance rules, as the investor is an execution's only client.")]
    ExecutionOnly,
    
    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights.
    /// Encoded/decoded by serializers as "WaiverAgreement".
    /// </summary>
    [EnumMember(Value = "NOWA")]
    [IsoId("_VkKxM9p-Ed-ak6NoX_4Aeg_1687884616")]
    [Description(@"Investor is not entitled to cancellation rights under compliance rules as the investor has agreed to waive those rights.")]
    WaiverAgreement,
    
    /// <summary>
    /// Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution.
    /// Encoded/decoded by serializers as "Institutional".
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_VkKxNNp-Ed-ak6NoX_4Aeg_1687884658")]
    [Description(@"Investor is not entitled to cancellation rights under compliance rules as the investor is a financial institution.")]
    Institutional,
    
    /// <summary>
    /// Another type of cancellation right.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkKxNdp-Ed-ak6NoX_4Aeg_593992752")]
    [Description(@"Another type of cancellation right.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CancellationRight2CodeMetadataExtensions
{
    private static readonly CancellationRight2CodeDropdownSource _dropdownSource = new CancellationRight2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICancellationRight2CodeDropdownRow GetMetadata(this CancellationRight2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


